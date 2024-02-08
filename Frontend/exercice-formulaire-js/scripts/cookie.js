validButton.addEventListener("click", setCookie);

function setCookie(){
    let now = new Date();
    let time = now.getTime();
    let expireTime = time + 1000*3600;
    now.setTime(expireTime);
    document.cookie = 'cname=' + lastName.value +";" + 'expires='+now.toUTCString()+ '; path=./;';
    document.cookie = 'cfirstname=' + firstName.value +";" + 'expires='+now.toUTCString()+ '; path=./;';
    document.cookie = 'cmail=' + mail.value +";" + 'expires='+now.toUTCString()+ '; path=./;';
    document.cookie = 'cday=' + dayNumber.value + '; path=./;';
    document.cookie = 'cmonth=' + currentMonth.value +";" + 'expires='+now.toUTCString()+ '; path=./;';
    document.cookie = 'cmonthvalue=' + (months.indexOf(currentMonth.value) + 1) +";" + 'expires='+now.toUTCString()+ '; path=./;';
    document.cookie = 'cyear=' + currentYear.value +";" + 'expires='+now.toUTCString()+ '; path=./;';
    document.cookie = 'cpseudo=' + pseudoInput.value +";" + 'expires='+now.toUTCString()+ '; path=./;';
    window.location.href = "../accueil.html";
}

const mailValue = ('; '+document.cookie).split(`; cmail=`).pop().split(';')[0];