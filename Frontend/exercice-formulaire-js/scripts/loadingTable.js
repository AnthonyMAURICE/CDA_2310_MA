const main = document.querySelector('main');
const table = document.querySelector('#table');
const monthIndex = getCookie("cmonthvalue");
let monthValue = "";
let yearValue = "";
let dayValue = "";
const date = new Date();

function loadTable(){
    const tRow = document.createElement('tr');
    tRow.appendChild(getName());
    tRow.appendChild(getFirstN());
    tRow.appendChild(getBirth());
    tRow.appendChild(getPseudo());
    table.appendChild(tRow);
    main.appendChild(displayDays());
}

loadTable();

function getName(){
    const tElementName = document.createElement('td');
    const nameValue = document.createTextNode(getCookie("cname"));
    tElementName.appendChild(nameValue);
    return tElementName;
}

function getFirstN(){
    const tElementFirstName = document.createElement('td');
    const firstNameValue = document.createTextNode(getCookie("cfirstname"));
    tElementFirstName.appendChild(firstNameValue);
    return tElementFirstName;
}

function getBirth(){
    const tBirth = document.createElement('td');
    dayValue = getCookie("cday");
    monthValue = getCookie("cmonth");
    yearValue = getCookie("cyear");
    const dateValue = document.createTextNode( dayValue + " " + monthValue + " " + yearValue);
    tBirth.appendChild(dateValue);
    return tBirth;
}

function getPseudo(){
    const tPseudo = document.createElement('td');
    const pseudoValue = document.createTextNode(getCookie("cpseudo"));
    tPseudo.appendChild(pseudoValue);
    return tPseudo;
}

function daysTillBirthday(months, days){
    const dateToCompare = Date.parse(date.getFullYear() + "-" + months + "-" + days);
    let diff = Math.floor((dateToCompare - Date.parse(date)) / 86400000);
    if(diff < 0){
        bissextile(date.getFullYear()? diff += 366: diff += 365);
    }
    return diff;
}

function bissextile(year){
    if(year%4 == 0 && ((year % 100) != 0 || (year % 400) == 0)){
        return true;
    }else{
        return false;
    }
}

function displayDays(){
    const disDay = document.createElement('p')
    const daysUntil = document.createTextNode(isNaN(daysTillBirthday(monthIndex, dayValue))? "Bon anniversaire !" : "Nombre de jours avant votre prochain anniversaire : " + daysTillBirthday(monthIndex, dayValue));
    disDay.appendChild(daysUntil);
    return disDay;
}

function getCookie(cname){
    let name = cname + "=";
    let decodedCookie = decodeURIComponent(document.cookie);
    let ca = decodedCookie.split(';');
    for(let i = 0; i <ca.length; i++) {
        let c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}