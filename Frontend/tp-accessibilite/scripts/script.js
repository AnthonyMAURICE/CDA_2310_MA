let storage = localStorage

const dialog = document.querySelector('dialog');
const dialogBtn = document.querySelector('.btn-access')
const closeBtn = document.querySelector('.close-dialog')
const body = document.querySelector('body')
const dysButton = document.querySelector('#adapted-font')
let dysBool = storage.getItem("dys") != null ? storage.getItem("dys") : false
let lineBool = storage.getItem("line") != null ? storage.getItem("line") : false
let justifyBool = storage.getItem("justify") != null ? storage.getItem("justify") : false
let imagesBool = storage.getItem("img") != null ? storage.getItem("img") : false

dialogBtn.addEventListener('click', () => {
    dialog.showModal();
})

closeBtn.addEventListener('click', () =>{
    dialog.close()
})

if(storage.getItem("dys") != null){
    document.addEventListener("DOMContentLoaded", function(){
        console.log("test")
        storage.getItem("dys") ? dysButton.checked = true : dysButton.checked = false;
        fontDys()
    })
}

document.querySelectorAll('.font').forEach(function(font){
    font.addEventListener('change', fontDys)
})

function fontDys(){
    dysBool = !dysBool
    console.log(dysBool)
    dysBool ? body.style.fontFamily = "dysFont": body.style.fontFamily = "Arial, Helvetica, sans-serif"
    storage.setItem("dys", dysBool)
}

