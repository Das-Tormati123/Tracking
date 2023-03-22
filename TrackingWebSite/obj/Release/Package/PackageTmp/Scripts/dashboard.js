var navbarClass = '.nav-item';
$(navbarClass).on('click', changeUIElements);
function changeUIElements() {
    $(navbarClass).removeClass("active");
    $(navbarClass).addClass("active");
}