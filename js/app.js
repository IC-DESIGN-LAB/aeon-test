$('.slider').slick({
  dots: false,
  infinite: true,
  speed: 1800,
  slidesToShow: 1,
  centerMode: true,
  arrows: true,
  autoplay: false,
  autoplaySpeed: 500,
  focusOnSelect: true,
  variableWidth: true,
  prevArrow: $('.prev-arrow'),
  nextArrow: $('.next-arrow'),
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
