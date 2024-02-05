const quantities = document.querySelectorAll('.quantity');
const unitPrices = document.querySelectorAll('.unitPrice');
const prices = document.querySelectorAll('.price');
const totalPrice = document.getElementById('total');
let temp = 0;


for(let i = 0; i < quantities.length; i++){
    quantities[i].addEventListener("change", function(){
        updateValues(quantities[i].value, unitPrices[i].value , i)
    });
    unitPrices[i].addEventListener("change", function(){
        updateValues(quantities[i].value, unitPrices[i].value , i)
    });
}

function updateValues(number1, number2, i){
    prices[i].value = number1 * number2;
}

