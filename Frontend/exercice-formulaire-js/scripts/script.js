const inputs = document.querySelectorAll('input');
const selects = document.querySelectorAll('select');
const lastName = document.querySelector('#login');
const email = document.querySelector('#mail');
const firstName = document.querySelector('#first-name');
const signe = ["Capricorne","Verseau","Poisson","Belier","Taureau","Gémeaux","Cancer","Lion","Vierge","Balance","Scorpion","Sagittaire"];
const validButton = document.querySelector('#validate');
const resetButton = document.querySelector('#vreset');
const pseudoInput = document.querySelector('#pseudo');

for(let input of inputs){
    input.addEventListener("change", formok);
}

for(let select of selects){
    select.addEventListener("change", formok);
}

currentMonth.addEventListener("change", astro);
reset.addEventListener("click", resetPage)

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

currentMonth.addEventListener("change", astro);

function formok(){
    if(lastName.value != "" && email.value != "" && firstName.value != ""){
        validButton.removeAttribute("disabled");
        pseudoConstructor();
        return true;
    }else{
        validButton.setAttribute("disabled", "true");
        return false;
    }
}


function pseudoConstructor(){
    const pseudo = astro() + nameAsNumber(lastName.value) + nameAsNumber(firstName.value);
    pseudoInput.value = pseudo;
}

function resetPage(){
    location.reload()
}