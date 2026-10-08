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

    title_text.style.marginTop = (action * 0.5 - 250) + 'px';
    tree_1.style.left = action * 0.5 + 'px';
    tree_2.style.left = action * -0.5 + 'px';
    bush.style.top = action * 0.05 + 'px';
});