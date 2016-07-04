// jQuery to collapse the navbar on scroll
$(window).scroll(function()
{
    if ($(".navbar").offset().top > 50)
    {
        $(".navbar-fixed-top").addClass("top-nav-collapse");
    }

    else
    {
        $(".navbar-fixed-top").removeClass("top-nav-collapse");
    }
});

// jQuery for page scrolling feature
$(function()
{
    $('a.page-scroll').bind('click', function(event)
    {
        var $anchor = $(this);
        $('html, body').stop().animate(
        {
            scrollTop: $($anchor.attr('href')).offset().top
        }, 1500, 'easeInOutExpo');
        
        event.preventDefault();
    });
});

// Change Color on Course Hover
$('.completed').hover(function()
{
    $('.completed').removeClass('current');
    $(this).addClass('current');
});

// This is a Carousel
$('.arrow-next').click(function() {
    var currentRating = $('.active-rating');
    var nextRating = currentRating.next();

    var currentDot = $('.active-dot');
    var nextDot = currentDot.next();

    if(nextRating.length === 0) {
      nextRating = $('.rating').first();
      nextDot = $('.dot').first();
    }
    
    currentRating.fadeOut(600).removeClass('active-rating');
    nextRating.fadeIn(600).addClass('active-rating');

    currentDot.removeClass('active-dot');
    nextDot.addClass('active-dot');
  });


  $('.arrow-prev').click(function() {
    var currentRating = $('.active-rating');
    var prevRating = currentRating.prev();

    var currentDot = $('.active-dot');
    var prevDot = currentDot.prev();

    if(prevRating.length === 0) {
      prevRating = $('.rating').last();
      prevDot = $('.dot').last();
    }
    
    currentRating.fadeOut(600).removeClass('active-rating');
    prevRating.fadeIn(600).addClass('active-rating');

    currentDot.removeClass('active-dot');
    prevDot.addClass('active-dot');
  });