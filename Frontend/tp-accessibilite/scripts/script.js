let storage = localStorage

const dialog = document.querySelector('dialog');
const dialogBtn = document.querySelector('.btn-access')
const closeBtn = document.querySelector('.close-dialog')
const body = document.querySelector('body')
let dysBool = storage.getItem('dys')
let lineBool = storage.getItem('line')
let justifyBool = storage.getItem('justify-suppressed')

dialogBtn.addEventListener('click', () => {
    dialog.showModal();
})

closeBtn.addEventListener('click', () =>{
    dialog.close()
})

document.addEventListener('DOMContentLoaded', function(){
    defaultParam()
})

function defaultParam(){
    if(storage.getItem('dys') != null){
        dysBool == "true" ? fontRadio[1].checked = true : fontRadio[0].checked = true
    }else{
        fontRadio[0].checked = true
    }
    if(storage.getItem('line') != null){
        lineBool == "true" ? lineRadio[1].checked = true : lineRadio[0].checked = true
    }else{
        lineRadio[0].checked = true
    }
    if(storage.getItem('justify-suppressed') != null){
        justifyBool == "true" ? justifyRadio[1].checked = true : justifyRadio[0].checked = true
    }else{
        justifyRadio[0].checked = true
    }
    fontChange()
    lineChange()
    justifyChange()
}

let fontRadio = document.querySelectorAll('.font')
for(let i = 0; i < fontRadio.length; i++){
    fontRadio[i].addEventListener('change', fontChange)
}

let lineRadio = document.querySelectorAll('.interligne')
for(let i = 0; i < lineRadio.length; i++){
    lineRadio[i].addEventListener('change', lineChange)
}

let justifyRadio = document.querySelectorAll('.justify')
for(let i = 0; i < justifyRadio.length; i++){
    justifyRadio[i].addEventListener('change', justifyChange)
}

function fontChange(){
    if(fontRadio[1].checked){
        body.style.fontFamily = "dysFont"
        storage.setItem('dys', 'true')
    }else{
        body.style.fontFamily = "Arial, Helvetica, sans-serif"
        storage.setItem('dys', 'false')
    }
}

function lineChange(){
    if(lineRadio[1].checked){
        body.style.lineHeight = 1.8
        storage.setItem('line', 'true')
    }else{
        body.style.lineHeight = 1.2
        storage.setItem('line', 'false')
    }
}

function justifyChange(){
    if(justifyRadio[1].checked){
        body.style.textAlign = "left"
        storage.setItem('justify-suppressed', 'true')
    }else{
        body.style.textAlign = "justify"
        storage.setItem('justify-suppressed', 'false')
    }
}