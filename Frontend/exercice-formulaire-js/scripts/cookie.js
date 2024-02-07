validButton.addEventListener("click", validation);

function validation(){
    document.cookie = 'cname=' + lastName.value + '; path=./;';
    document.cookie = 'cfirstname=' + firstName.value + '; path=./;';
    document.cookie = 'cmail=' + mail.value + '; path=./;';
    document.cookie = 'cday=' + dayNumber.value + '; path=./;';
    document.cookie = 'cmonth=' + currentMonth.value + '; path=./;';
    document.cookie = 'cyear=' + currentYear.value + '; path=./;';
    document.cookie = 'cpseudo=' + pseudoInput.value + '; path=./;';
    window.location.href = "../accueil.html";
}


const mailValue = ('; '+document.cookie).split(`; cmail=`).pop().split(';')[0];
