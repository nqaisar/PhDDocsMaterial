function getJiveEvents(placeId) {
	var sortOrder = new Array();
	var today = new Date().getTime();
	
	$.getJSON("/jive/api/core/v3/contents/?filter=place(/jive/api/core/v3/places/" + placeId + ")&amp;filter=type(event)", {abridged: true}).done(function(data) {
		
		if(data.status != "") {			
			$("a.event-path").attr("href", data.results.list[0].parentPlace.html);
			
			$.each(data.results.list, function(index, item) {
				// Reformat Date strings from Jive
				item.startDate = Date.fromISO(item.startDate);
				item.endDate = Date.fromISO(item.endDate);
				
				//Create a new Object to hold properties from Jive API
				var events = new Object();
				events.eventOrder = item.startDate;
				events.url = item.resources.html.ref;
				events.title = item.subject;
				events.type = item.eventType;
				
				events.calMonth = function() {
					return new Date(item.startDate).toDateString().slice(4, 7);	
				}
				
				events.calDate = function() {
					return new Date(item.startDate).toDateString().slice(8, 10);	
				}
					
				if(item.startDate <= today && item.endDate >= today || item.startDate > today) {
					events.eventItem = "<a class='event-link' href='" + events.url + "' target='_blank'><div class='event-holder clearfix'><div class='cal-box'><p class='event-month'>" + events.calMonth() + "</p><p class='event-date'>" + events.calDate() + "</p></div><p class='event-title'>" + events.title + "</p><p class='event-venue'>Venue: " + events.type + "</p></div></a>";
					
					sortOrder.push(events);	
				}
				
			}); //End each loop
			
			// Function to re-order events based on event date
			sortOrder.sort(function (a, b) {
				if (a.eventOrder > b.eventOrder) {
					return 1;
				}
				
				if (a.eventOrder < b.eventOrder) {
					return -1;
				}
				
				return 0;
			});
			
			$.each(sortOrder, function(index, item) {
				$("#events").append(item.eventItem);	
			});
			
		}else {
			$("#events").append("No events to report");	
		}
	}); //End getJSON function
	
	// Start function for IE fix for ISO formatted Date strings
	Date.fromISO= (function(){
		var testIso = '2011-11-24T09:00:27+0200';
		
		// Chrome
		var diso= Date.parse(testIso);
		if(diso===1322118027000) return function(s){
			return new Date(Date.parse(s));
		}
		
		// JS 1.8 gecko
		var noOffset = function(s) {
		  var day= s.slice(0,-5).split(/\D/).map(function(itm){
			return parseInt(itm, 10) || 0;
		  });
		  day[1]-= 1;
		  day= new Date(Date.UTC.apply(Date, day));  
		  var offsetString = s.slice(-5)
		  var offset = parseInt(offsetString,10)/100; 
		  if (offsetString.slice(0,1)=="+") offset*=-1;
		  day.setHours(day.getHours()+offset);
		  return day.getTime();
		}
		
		if (noOffset(testIso)===1322118027000) {
		   return noOffset;
		}
		  
		return function(s){ // kennebec@SO + QTax@SO
			var day, tz, 
			rx = /^(\d{4}\-\d\d\-\d\d([tT][\d:\.]*)?)([zZ]|([+\-])(\d\d):?(\d\d))?$/,
				
			p= rx.exec(s) || [];
			if(p[1]){
				day= p[1].split(/\D/).map(function(itm){
					return parseInt(itm, 10) || 0;
				});
				day[1]-= 1;
				day= new Date(Date.UTC.apply(Date, day));
				if(!day.getDate()) return NaN;
				if(p[5]){
					tz= parseInt(p[5], 10)/100*60;
					if(p[6]) tz += parseInt(p[6], 10);
					if(p[4]== "+") tz*= -1;
					if(tz) day.setUTCMinutes(day.getUTCMinutes()+ tz);
				}
				
				return day;
			}
			
			return NaN;
		}
	})() // End function for IE fix for ISO formatted Date strings
	
} //End getJiveEvents function

