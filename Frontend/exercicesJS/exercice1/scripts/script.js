const btn = document.getElementById("counter");
const zero = document.getElementById("zero");
let click = 0;

btn.addEventListener('click', counter);
zero.addEventListener('click', toZero);

function counter(){
    click++;
    display(click);
}

function toZero(){
    click = 0;
    display(click);
}

function display(click){
    document.querySelector("span").innerHTML = click;
}