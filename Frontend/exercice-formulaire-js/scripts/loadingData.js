const dayNumber = document.querySelector('#list-days');
const currentYear = document.querySelector('#list-year');
const currentMonth = document.querySelector('#list-month');
const dateNow = new Date();
const months = [...Array(12).keys()].map(key => new Date(0, key).toLocaleString('fr', { month: 'long' }));

dob();

function dob(){
    for(let k = 1915; k < dateNow.getFullYear(); k++){
        currentYear.appendChild(years(k));
    }
    for(let j = 0; j < months.length; j++){
        currentMonth.appendChild(month(j));
    }
    monthCheck(currentYear, currentMonth);
}

currentMonth.addEventListener("change", function(){
    monthCheck(currentYear, currentMonth);
})
currentYear.addEventListener("change", function(){
    monthCheck(currentYear, currentMonth);
})

function days(day){
    dayNumber.replaceChildren()
    for(let i = 0; i < day; i++){
        dayNumber.appendChild(daysNumbers(i));
    }
}

function daysNumbers(i){
    const option = document.createElement('option');
    const day = document.createTextNode(i+1);
    option.appendChild(day);
    return option;
}

function month(j){
    const option = document.createElement('option');
    const monthItem = document.createTextNode(months[j]);
    option.appendChild(monthItem);
    return option;
}

function years(k){
    const option = document.createElement('option');
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

function monthCheck(year, month){
    if(month.value == "février"){
        if(bissextile(year.value)){
            days(29);
        }else{
            days(28);
        }
    }else if(thrityDaysMonths()){
        days(30);
    }else{
        days(31);
    }
}

function thrityDaysMonths(){
    if(currentMonth.value == "avril" || currentMonth.value == "juin" || currentMonth.value == "septembre" || currentMonth.value == "novembre"){
        return true;
    }else{
        return false;
    }
}