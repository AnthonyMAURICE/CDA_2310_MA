const dateInput = document.querySelector('#date');
const timeInput = document.querySelector('#time');
const dateBtn = document.querySelector('#btn-date');
const timeBtn = document.querySelector('#btn-time');
dateBtn.addEventListener("click", displayDate);
timeBtn.addEventListener("click", displayTime);

function displayDate(){
    const date = dateConstruct();
    dateInput.value = date.toLocaleDateString();
}

function dateConstruct(){
    return new Date();
}

function displayTime(){
    const time = dateConstruct();
    let seconds = time.getSeconds() < 10? "0" + time.getSeconds(): time.getSeconds();
    let minutes = time.getMinutes()< 10? "0" + time.getMinutes(): time.getMinutes();
    let hours = time.getHours()< 10? "0" + time.getHours(): time.getHours();
    timeInput.value = hours + ":" + minutes + ":" + seconds;
    setInterval("displayTime()", 1000);
}