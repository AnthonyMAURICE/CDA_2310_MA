const elements = document.querySelectorAll('.form-element');
const lastName = document.querySelector('#login');
const email = document.querySelector('#mail');
const firstName = document.querySelector('#first-name');
const signe = ["Capricorne","Verseau","Poisson","Belier","Taureau","Gémeaux","Cancer","Lion","Vierge","Balance","Scorpion","Sagittaire"];
const validButton = document.querySelector('#validate');
const resetButton = document.querySelector('#reset');
const pseudoInput = document.querySelector('#pseudo');
const inputs = document.querySelectorAll('.input')

currentMonth.addEventListener("change", astro);
resetButton.addEventListener("click", resetPage)

for(let input of inputs){
    input.setAttribute('required', 'true')
}

for(let element of elements){
    element.addEventListener("change", formok);
}

function isValid(formObject){
    const arrayFromObject = Object.values(formObject);
        if(arrayFromObject.every((formElem) => formElem.checkValidity())){
            return true;
        }else{
            return false;
        }
    
}

function nameAsNumber(stringToNumber){
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

function formok(){
    if(isValid(inputs) && !isNaN(dayNumber.value) && controlDate()){
        validButton.disabled = false;
        pseudoConstructor();
        return true;
    }else{
        validButton.disabled = true;
        return false;
    }
}

function controlDate(){
    let dateComp = Date.parse(currentYear.value + "-" + months.indexOf(currentMonth.value.toLowerCase()) + "-" + dayNumber.value);
    if(dateNow.getTime() < dateComp){
        return false;
    }else{
        return true;
    }
}

function pseudoConstructor(){
    const pseudo = astro() + nameAsNumber(lastName.value) + nameAsNumber(firstName.value);
    pseudoInput.value = pseudo;
}

function resetPage(){
    location.reload()
}