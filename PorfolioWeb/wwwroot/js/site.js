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


// Obtener todos los elementos de enlace de la barra de navegación
const navLinks = document.querySelectorAll('.navbar__link');

// Agregar un controlador de eventos de clic a cada enlace
navLinks.forEach(link => {
    link.addEventListener('click', function () {
        // Eliminar la clase 'selected' de todos los enlaces
        navLinks.forEach(link => {
            link.classList.remove('selected');
        });

        // Agregar la clase 'selected' al enlace actual
        this.classList.add('selected');
    });
});




const navbar = document.querySelector(".headerContainer");

window.addEventListener("scroll", function () {
    console.log("entra aca");
    const scrollPosition = window.scrollY;

    if (scrollPosition > navbar.offsetHeight) {
        navbar.classList.add("scrolled");
    } else {
        navbar.classList.remove("scrolled");
    }
});