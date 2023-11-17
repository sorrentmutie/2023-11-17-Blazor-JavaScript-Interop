let myModale;

window.apriModale = function (id) {
    myModale = new bootstrap.Modal(document.getElementById(id));
    myModale.show();
}

window.chiudiModale = function () {
    if (myModale) {
        myModale.hide();
    }
}