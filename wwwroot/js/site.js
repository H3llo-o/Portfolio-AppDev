// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let title_text = document.getElementById('title_text');
let tree_1 = document.getElementById('tree_1');
let tree_2 = document.getElementById('tree_2');
let ground = document.getElementById('ground');
let sky_bg = document.getElementById('sky_bg');
let bush = document.getElementById('bush');

window.addEventListener('scroll', () => {
    let action = window.scrollY;

    text.style.marginTop = action * 2.5 + 'px';
});