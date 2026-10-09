// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let title_text = document.getElementById('title_text');
let tree_1 = document.getElementById('tree_1');
let tree_2 = document.getElementById('tree_2');
let ground = document.getElementById('ground');
let sky_bg = document.getElementById('sky_bg');
let bush = document.getElementById('bush');

window.addEventListener('scroll', () => {                           // Active for the whole window
    let action = window.scrollY;

    title_text.style.marginTop = (action * 0.8 - 250) + 'px';
    tree_1.style.left = action * 0.5 + 'px';
    tree_2.style.left = action * -0.5 + 'px';
    bush.style.top = action * 0.05 + 'px';
});

let self_picture = document.getElementById('self-picture');
let title_desc_2 = document.getElementById('title-desc-2');
let title_desc_3 = document.getElementById('title-desc-3');
let horizontal_pan = document.getElementById('panning');

horizontal_pan.addEventListener('scroll', () => {                   // Works for the specific div
    let new_action = horizontal_pan.scrollTop;

    self_picture.style.left = (new_action * -0.3 + 2250) + 'px';
    title_desc_2.style.left = (new_action * -0.45 + 2250) + 'px';
    title_desc_3.style.left = (new_action * 0.07 + 2250) + 'px';
});
