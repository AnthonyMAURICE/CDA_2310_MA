validButton.addEventListener("click", controlDate);

function setCookie(cname, cvalue, maxAge){
    document.cookie = cname + "=" + cvalue + "; max-age= "+ maxAge+"; path=./;"; 
}

function changePage(){
    setCookie("cname", lastName.value, 86400);
    setCookie("cfirstname", firstName.value, 86400);
    setCookie("cday", dayNumber.value, 86400);
    setCookie("cmonth", currentMonth.value, 86400);
    setCookie("cmonthvalue", (months.indexOf(currentMonth.value) + 1), 86400);
    setCookie("cyear", currentYear.value, 86400);
    setCookie("cpseudo", pseudoInput.value, 86400);
    setCookie("cmail", mail.value, 86400);
    window.location.href = "../accueil.html";
}

function controlDate(){
    let dateComp = Date.parse(currentYear.value + "-" + months.indexOf(currentMonth.value) + "-" + dayNumber.value);
    if(dateNow.getTime() < dateComp){
        alert("Date invalide !")
        location.reload()
    }else{
        changePage();
    }
}