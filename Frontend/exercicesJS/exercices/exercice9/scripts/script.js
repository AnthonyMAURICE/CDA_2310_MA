const formulaire = document.querySelector('form');
const btn = document.querySelectorAll('button')
const inputs = document.querySelectorAll('input');
let controledInputs = false;
window.addEventListener("load", updateMouseHexa);

for(button of btn){
    button.addEventListener("click", function(){
        updateColor(this);
    });
}

formulaire.addEventListener("mouseleave", control);

function control(){
    let pattern = /^[a-fA-F0-9_]+$/;
    let hexColor = "#";
    let rgb = "rgb(";
    let iteration = inputs.length;
    for(let input of inputs){
        if(input.value.length == 2 && pattern.test(input.value)){
            hexColor += input.value;
        }else{
            if(!isNaN(Number(input.value))&& input.value >= 0 && input.value <= 255){
                --iteration? rgb += Number(input.value) + ", " : rgb += Number(input.value) + ")";
            }
            updateMouseRgb(rgb)
        }
        updateMouseHexa(hexColor);
    }
}

function updateColor(_btn){
    formulaire.style.backgroundColor = _btn.id;
}

function updateMouseRgb(rgb){
    console.log(rgb);
    formulaire.style.backgroundColor = rgb;
}

function updateMouseHexa(hex){
    formulaire.style.backgroundColor = hex;
}