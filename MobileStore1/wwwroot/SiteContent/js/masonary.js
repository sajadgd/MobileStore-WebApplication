$(document).ready(function(){
    var $container = $('#masonary-content');
    $container.isotope({
        filter: '*',
        animationOptions: {
            duration: 750,
            easing: 'linear',
            queue: false,
        }
    });
	
$("#masonay-nav > ul > li > a").click(function(){ 
      if ($("#masonay-nav > ul > li > a").hasClass('active')) {
        $("#masonay-nav > ul > li > a").removeClass('active'); 
      }
    $(this).addClass('active');
 });
 
$('#masonay-nav a').click(function(){
    var selector = $(this).attr('data-filter');
    $container.isotope({ 
        filter: selector,
        animationOptions: {
            duration: 750,
            easing: 'linear',
            queue: false, 
        }
    });
  return false;
});

});