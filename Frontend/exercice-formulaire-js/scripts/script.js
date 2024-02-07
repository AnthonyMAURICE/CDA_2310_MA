const lastName = document.getElementById("login");
const email = document.getElementById("mail");
const firstName = document.getElementById("first-name");
const signe = ["Capricorne","Verseau","Poisson","Belier","Taureau","Gémeaux","Cancer","Lion","Vierge","Balance","Scorpion","Sagittaire"];
const validButton = document.getElementById("validate");
const pseudoInput = document.getElementById("pseudo");

function loginAsNumber(stringToNumber){
    console.log(stringToNumber)
    let login = stringToNumber.toUpperCase();
    let valNum = 0;
    const charValue = (log) => log.charCodeAt(0) - 64;
    for(let i = 0; i < stringToNumber.length; i++){
        valNum += charValue(login[i])
    }
    return valNum
}

function astro(){
    monthIndex = months.indexOf(currentMonth.value)
    return signe[monthIndex]
}

lastName.addEventListener("change", function(){
    loginAsNumber(lastName.value)
});
currentMonth.addEventListener("change", astro);


function formok(){
    if(lastName.value != "" && email.value != "" && firstName.value != ""){
        validButton.removeAttribute("disabled");
        validate();
        return true;
    }else{
        validButton.setAttribute("disabled", "true");
        return false;
    }
}

lastName.addEventListener("change", formok)
email.addEventListener("change", formok)
firstName.addEventListener("change", formok)

function validate(){
    console.log(lastName.value)
    const pseudo = astro() + loginAsNumber(lastName.value) + loginAsNumber(firstName.value);
    pseudoInput.value = pseudo;
}

