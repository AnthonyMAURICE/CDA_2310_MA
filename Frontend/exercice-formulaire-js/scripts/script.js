const lastName = document.querySelector('#login');
const email = document.querySelector('#mail');
const firstName = document.querySelector('#first-name');
const signe = ["Capricorne","Verseau","Poisson","Belier","Taureau","Gémeaux","Cancer","Lion","Vierge","Balance","Scorpion","Sagittaire"];
const validButton = document.querySelector('#validate');
const pseudoInput = document.querySelector('#pseudo');


function loginAsNumber(stringToNumber){
    let login = stringToNumber.toUpperCase();
    let valNum = 0;
    const charValue = (log) => log.charCodeAt(0) - 64;
    for(let i = 0; i < stringToNumber.length; i++){
        valNum += charValue(login[i]);
    }
    return valNum;
}

function astro(){
    monthIndex = months.indexOf(currentMonth.value);
    return signe[monthIndex];
}

lastName.addEventListener("change", function(){
    loginAsNumber(lastName.value);
});
currentMonth.addEventListener("change", astro);


function formok(){
    if(lastName.value != "" && email.value != "" && firstName.value != "" && checkDayIsNumber()){
        validButton.removeAttribute("disabled");
        validate();
        return true;
    }else{
        validButton.setAttribute("disabled", "true");
        return false;
    }
}

lastName.addEventListener("change", formok);
email.addEventListener("change", formok);
firstName.addEventListener("change", formok);
dayNumber.addEventListener("change", checkDayIsNumber);

function validate(){
    const pseudo = astro() + loginAsNumber(lastName.value) + loginAsNumber(firstName.value);
    pseudoInput.value = pseudo;
}

function checkDayIsNumber(){
    if(!isNaN(dayNumber.value)){
        return true;
    }else{
        return false;
    }
}

