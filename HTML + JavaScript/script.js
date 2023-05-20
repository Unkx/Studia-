window.addEventListener('scroll', function() {
  var nav = document.querySelector('.sticky-nav');
  if (window.pageYOffset > nav.offsetTop) {
    nav.classList.add('sticky');
  } else {
    nav.classList.remove('sticky');
  }
});