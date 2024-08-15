$(document).ready(function(){

	// Show billboard region
	$('a.hide,#isoFilters a').bind("click", function(){
		$('a.hide').css('display', 'none');
		$('div.billboard').slideUp('fast');
		$('div.billboard-inner').slideUp('fast');
		$('div.callsToAction').slideUp('fast');
		$('div.homeIntro').slideUp('fast');
		$('a.show').css('display', 'block');
		 
	});

	// Hide billboard region
	$('a.show').bind("click", function(){
		$('a.show').css('display', 'none');
		$('div.billboard').slideDown('fast');
		$('div.billboard-inner').slideDown('fast');
		$('div.callsToAction').slideDown('fast');
		$('div.homeIntro').slideDown('fast');
		$('a.hide').css('display', 'block');
	});

	// Show language select menu
	$('.active.flag-container, .flag-container').mouseover(function() {
		$('.flag-container').css("display", "block");
	});

	// Hide language select menu
	$('.active.flag-container, .flag-container').mouseout(function() {
		$('.flag-container').css("display", "none");
		$('.flag-container.active').css("display", "block");
	});
	
	 
});