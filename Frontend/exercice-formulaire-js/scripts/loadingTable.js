const table = document.querySelector('#table')
let monthValue = "";
let yearValue = "";
let dayValue = "";
const date = new Date()

function loadTable(){
    const tRow = document.createElement('tr')
    tRow.appendChild(getName())
    tRow.appendChild(getFirstN())
    tRow.appendChild(getBirth())
    tRow.appendChild(getPseudo())
    table.appendChild(tRow)
}

loadTable();

displayDays();

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
    dayValue = ('; '+document.cookie).split(`; cday=`).pop().split(';')[0] 
    monthValue = ('; '+document.cookie).split(`; cmonth=`).pop().split(';')[0]
    yearValue = ('; '+document.cookie).split(`; cyear=`).pop().split(';')[0]
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

function daysTillBirthday(months, days, year){
    const oneDay = 1000 * 60 * 60 * 24;
    const dateToCompare = new Date(months +" "+ days +" "+ year)
    let diff = dateToCompare.getTime() - date.getTime();

    let diffDay = Math.round(diff / oneDay);
    if(diffDay < 0){
        diffDay += 365
    }
    console.log(diffDay)
    return diffDay;
}

function displayDays(){
    const disDay = document.createElement('p')
    const daysUntil = document.createTextNode("Nombre de jours avant votre prochain anniversaire : " + daysTillBirthday(monthValue, dayValue, yearValue))
    disDay.appendChild(daysUntil);
}