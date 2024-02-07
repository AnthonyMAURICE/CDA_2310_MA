const formulaire = document.querySelector('form');
const btn = document.querySelectorAll('.btn-color')
const inputs = document.querySelectorAll('.colorInput');
const hex = document.getElementById('hex');
const rgbButton = document.getElementById('rgb');

window.addEventListener("load", controlHexa);

for(button of btn){
    button.addEventListener("click", function(){
        updateColor(this);
    });
}

formulaire.addEventListener("mouseleave", function(){
    if(hex.checked == true){
        controlHexa();
    }else if(rgbButton.checked == true){
        controlRGB();
    }
});

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
    updateMouseColor(hexColor)
}

function controlRGB(){
    console.log("test")
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
    console.log(rgb)
    updateMouseColor(rgb)
}

function updateColor(_btn){
    formulaire.style.backgroundColor = _btn.id;
}

function updateMouseColor(color){
    formulaire.style.backgroundColor = color;
}
