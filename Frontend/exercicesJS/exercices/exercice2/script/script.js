const dateInput = document.getElementById('date');
const timeInput = document.getElementById('time');
const dateBtn = document.getElementById('btn-date');
const timeBtn = document.getElementById('btn-time');

document.addEventListener("DOMContentLoaded", function(){
    setInterval("displayTime()", 500)
});

dateBtn.addEventListener("click", displayDate);
timeBtn.addEventListener("click", displayTime);

function displayDate(){
    let date = new Date()
    dateInput.value = date.toLocaleDateString();
}

function displayTime(){
    let time = new Date()
    let seconds = time.getSeconds() < 10? "0" + time.getSeconds(): time.getSeconds();
    let minutes = time.getMinutes()< 10? "0" + time.getMinutes(): time.getMinutes();
    let hours = time.getHours()< 10? "0" + time.getHours(): time.getHours();
    timeInput.value = hours + ":" + minutes + ":" + seconds;
}