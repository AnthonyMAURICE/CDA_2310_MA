const formulaire = document.querySelector('form');
const btn = document.querySelectorAll('.btn-color')
const inputs = document.querySelectorAll('input');
const hex = document.getElementById('hex');
const rgbButton = document.getElementById('rgb');

window.addEventListener("load", updateMouseColor);

for(button of btn){
    button.addEventListener("click", function(){
        updateColor(this);
    });
}

hex.addEventListener("click", controlHexa);
rgbButton.addEventListener("click", controlRGB);

function controlHexa(){
    let pattern = /^[a-fA-F0-9_]+$/;
    let hexColor = "#";
    for(let input of inputs){
        if(input.value.length == 2 && pattern.test(input.value)){
            hexColor += input.value;
        }else{
            input.value = "error";
        }
    }
    formulaire.addEventListener("mouseleave", function(){
        updateMouseColor(hexColor)
    });
}

function controlRGB(){
    let rgb = "rgb(";
    let iterator = inputs.length;
    for(let input of inputs){
        if(!isNaN(Number(input.value))){
            rgb += Number(input.value) + (--iterator? ", ": "");
        }else{
            input.value = "error";
        }
    }
    rgb += ")";
    formulaire.addEventListener("mouseleave", function(){
        updateMouseColor(rgb)
    });
}

function updateColor(_btn){
    formulaire.style.backgroundColor = _btn.id;
}

function updateMouseColor(color){
    formulaire.style.backgroundColor = color;
}
