/*
 * Author        : Hamus Lee
 * Dependency    : jQuery
 * Compatibility : jQuery v1.3.2
 * Compatibility : MSIE 6/7/8, FF 3/3.5, Safari 4
 */

	$(document).ready(function(){
  $('a[href*=#]').click(function() {
    if (location.pathname.replace(/^\//,'') == this.pathname.replace(/^\//,'')
    && location.hostname == this.hostname) {
      var $target = $(this.hash);
      $target = $target.length && $target
      || $('[name=' + this.hash.slice(1) +']');
      if ($target.length) {
        var targetOffset = $target.offset().top;
        $('html,body')
        .animate({scrollTop: targetOffset}, 500);
       return false;
      }
    }
  });
});