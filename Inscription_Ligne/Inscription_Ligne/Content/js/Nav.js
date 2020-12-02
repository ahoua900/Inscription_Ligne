var iconOpen = document.getElementById("icon-open");
var sidebar = document.getElementById("menu");

sidebar.addEventListener('click', function (e) {
    e.stopPropagation();
})

iconOpen.addEventListener('click', function (e) {
    e.stopPropagation();
    sidebar.classList.toggle("menu-active");
})


window.addEventListener('click', function (e) {
    sidebar.classList.remove('menu-active');
})