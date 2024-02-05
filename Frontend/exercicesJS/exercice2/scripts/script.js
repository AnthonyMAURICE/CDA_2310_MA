const upButton = document.getElementById("up");
const downButton = document.getElementById("down");
const span = document.querySelector("span");

const fontSize = window.getComputedStyle(document.querySelector('p')).style.fontSize;

console.log(fontSize)






function display(fontSize){
    span.innerText = fontSize;
}