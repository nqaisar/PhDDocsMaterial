function getJiveContent(elementId, placeId, count) {
	$.getJSON("/jive/api/core/v3/contents/recent?filter=place(/jive/api/core/v3/places/" + placeId + ")", {
		count: count,
		fields: "author, content, published, subject, updated, parentPlace, replyCount",
		abridged: true
	}).done(function (data) {
		if(data.status != "") {
			$("a.jive-path").attr("href", data.results.list[0].parentPlace.html);
			
			$.each(data.results.list, function(index, item) {
				var activity = "<div class='item-holder clearfix'><div class='jive-avatar'><img src='" + item.author.resources.avatar.ref + "'><p class='jive-subcontent jive-user'><a href='" + item.author.resources.html.ref + "' target='_blank'>" + item.author.displayName + "</a></p><p class='jive-subcontent'><img src='/images/crankset/bubbletalk.png' /> " + item.replyCount + "</p></div><div class='jive-body'><p class='jive-title'><a href='" + item.resources.html.ref + "' target='_blank'>" + item.subject + "</a></p><p class='jive-summary'>" + item.content.text + "</p><p class='jive-subcontent'>Space: <a href='" + item.parentPlace.html + "' target='_blank'>" + item.parentPlace.name + "</a></p><p class='jive-subcontent'>" + parseJiveDate(item.updated) + "</p></div></div>";
				
				$(elementId).append(activity);
			});
		}else {
			$(".jive-window").html("<p class='error-msg'>Jive stream is temporarily unavailable!</p>");
			console.log("Jive stream is temporarily unavailable!");	
		}
	});	
}

function parseJiveDate(dateString) {	
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
					//        rx = /^(\d{4}\-\d\d\-\d\d([tT][\d:\.]*)?)([zZ]|([+\-])(\d{4}))?$/,
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
					})()
    var d = Date.fromISO(dateString);
	var newDate = new Date(d);
	return newDate.toDateString().slice(4);
}