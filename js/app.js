$('.slider').slick({
  dots: false,
  infinite: true,
  speed: 1800,
  slidesToShow: 1,
  centerMode: true,
  arrows: true,
  autoplay: true,
  autoplaySpeed: 500,
  focusOnSelect: true,
  variableWidth: true,
  prevArrow: '<button class="prev-arrow slick-arrow"></button>',
  nextArrow: '<button class="next-arrow slick-arrow"></button>',
  responsive: [{
  breakpoint: 960,
    settings: {
      slidesToShow: 1,
      slidesToScroll: 1,
      variableWidth: false,
      centerPadding: '15px',
    }
  }]
});

$('.submylist-tab li').each(function(e) {
  var t = $(this).attr('id');
  $(this).on("click", function(e) {
      $('#' + t + '-show').css('display', 'block');
      $('.submylist-wrap').children('#' + t + '-show').siblings().css('display', 'none');
      $(this).addClass("tab-active");
      $(this).siblings().removeClass("tab-active");
  });
});

$('.logout-close').click(function() {
  $('.logout').fadeOut();
});