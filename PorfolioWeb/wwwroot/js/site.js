// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function MostrarOcultar(id) {
    var elementoPorId = document.getElementById(id);
    if (elementoPorId.style.display == 'none') {
        elementoPorId.style.display = 'block';
    } else {
        elementoPorId.style.display = 'none'
    }
     
}
