const main = document.querySelector('main');
const table = document.querySelector('#table');
const monthIndex = ('; '+document.cookie).split(`; cmonthvalue=`).pop().split(';')[0];
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
    const nameValue = document.createTextNode(('; '+document.cookie).split(`; cname=`).pop().split(';')[0]);
    tElementName.appendChild(nameValue);
    return tElementName;
}

function getFirstN(){
    const tElementFirstName = document.createElement('td');
    const firstNameValue = document.createTextNode(('; '+document.cookie).split(`; cfirstname=`).pop().split(';')[0]);
    tElementFirstName.appendChild(firstNameValue);
    return tElementFirstName;
}

function getBirth(){
    const tBirth = document.createElement('td');
    dayValue = ('; '+document.cookie).split(`; cday=`).pop().split(';')[0];
    monthValue = ('; '+document.cookie).split(`; cmonth=`).pop().split(';')[0];
    yearValue = ('; '+document.cookie).split(`; cyear=`).pop().split(';')[0];
    
    const dateValue = document.createTextNode( dayValue + " " + monthValue + " " + yearValue);
    tBirth.appendChild(dateValue);
    return tBirth;
}

function getPseudo(){
    const tPseudo = document.createElement('td');
    const pseudoValue = document.createTextNode(('; '+document.cookie).split(`; cpseudo=`).pop().split(';')[0]);
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