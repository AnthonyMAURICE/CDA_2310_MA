const lists = document.querySelectorAll('.list');
const dayNumber = document.querySelector('#list-days');
const currentYear = document.querySelector('#list-year');
const currentMonth = document.querySelector('#list-month');
const dateNow = new Date();
const months = [...Array(12).keys()].map(key => new Date(0, key).toLocaleString('fr', { month: 'long' }));

dob();

for(let list of lists){
    list.addEventListener("change", function(){
    monthCheck(currentYear, currentMonth);
    })
}

function dob(){
    for(let k = 1915; k <= dateNow.getFullYear(); k++){
        currentYear.appendChild(years(k));
    }
    for(let j = 0; j < months.length; j++){
        currentMonth.appendChild(month(j));
    }
    monthCheck(currentYear, currentMonth);
}

function monthCheck(year, month){
    if(month.value == "Février"){
        if(bissextile(year.value)){
            days(29);
        }else{
            days(28);
        }
    }else if(thirtyDaysMonths()){
        days(30);
    }else{
        days(31);
    }
}

function days(day){
    dayNumber.replaceChildren();
    for(let i = 0; i <= day; i++){
        dayNumber.appendChild(daysNumbers(i));
    }
}

function daysNumbers(i){
    const option = document.createElement('option');
    if(i == 0){
        const choiceText = document.createTextNode("Choisissez votre jour");
        option.appendChild(choiceText);
    }else{
        const day = (i < 10) ? document.createTextNode("0" + i): document.createTextNode(i);
        option.value = i
        option.appendChild(day);
    }
    return option;
}

function month(j){
    const option = document.createElement('option');
    months[j] = capitalizeFirstLetter(months[j])
    const monthItem = document.createTextNode(months[j]);
    option.value = months[j];
    option.appendChild(monthItem);
    return option;
}

function capitalizeFirstLetter(string) {
    return string.charAt(0).toUpperCase() + string.slice(1);
}

function years(k){
    const option = document.createElement('option');
    option.value = k;
    const yearsList = document.createTextNode(k);
    option.appendChild(yearsList);
    return option;
}

function bissextile(year){
    if(year%4 == 0 && ((year % 100) != 0 || (year % 400) == 0)){
        return true;
    }else{
        return false;
    }
}

function thirtyDaysMonths(){
    if(currentMonth.value == "Avril" || currentMonth.value == "Juin" || currentMonth.value == "Septembre" || currentMonth.value == "Novembre"){
        return true;
    }else{
        return false;
    }
}
