/*część wspólna*/
/*navbar część wspólna */
window.addEventListener('scroll', function() {
  var nav = document.querySelector('.sticky-nav');
  if (window.pageYOffset > nav.offsetTop) {
    nav.classList.add('sticky');
  } else {
    nav.classList.remove('sticky');
  }
});
/*koniec części wspólnej*/

/* część <historia.html> */
function ShowAndHide() {
  var x = document.getElementById('SectionName');
  if (x.style.display == 'none') {
      x.style.display = 'block';
  } else {
      x.style.display = 'none';
  }
}
/* część <historia.html> */