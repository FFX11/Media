
window.applyTheme = function (themeClass, isDarkMode) {
        document.body.className = themeClass;
    var movieCards = document.querySelectorAll('.card');
    movieCards.forEach(function (card) {
        card.style.backgroundColor = isDarkMode ? '#333' : '#fff';
        card.style.body = isDarkMode ? '#333' : '#fff';
        card.style.color = isDarkMode ? '#fff' : '#333'; // Text color for better contrast
    });
};


window.openTrailerModal = function () {
    var modal = new bootstrap.Modal(document.getElementById('trailerModal'));
    modal.show();
};