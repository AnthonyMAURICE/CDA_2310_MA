const quantities = document.querySelectorAll('.quantity');
const unitPrices = document.querySelectorAll('.unitPrice');
const prices = document.querySelectorAll('.price');
const totalPrice = document.getElementById('total');

for(let i = 0; i < quantities.length; i++){
    quantities[i].addEventListener("change", function(){
        updateValues(Number(quantities[i].value), unitPrices[i].value , i)
    });
    unitPrices[i].addEventListener("change", function(){
        updateValues(Number(quantities[i].value), unitPrices[i].value , i)
    });
}

function updateValues(number1, number2, i){
    if(!isNaN(number1) && Number.isInteger(number1) && !isNaN(number2)){
        prices[i].value = number1 * number2;
        setTotal();
    }else{
        prices[i].value = "error";
    }
    for(let price of prices){
        price.addEventListener("change", function(){
            updateValues(number1, number2, i);
        })
    }
}

function setTotal(){
    let temp = 0;
    for(let price of prices){
        temp += Number(price.value)
    }
    if(isNaN(temp)){
        temp = "error";
    }
    totalPrice.value = temp;
    totalPrice.addEventListener("change", setTotal);
}
