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
function ShowAndHide(buttonId, sectionId) {
  var section = document.getElementById(sectionId);
  var button = document.getElementById(buttonId);

  if (section.style.display === "none") {
    section.style.display = "block";
    button.innerHTML = "Hide";
  } else {
    section.style.display = "none";
    button.innerHTML = "Show";
  }
}
/* część <historia.html> */