const head = document.querySelector('#t-head')
const tBody = document.querySelector('#t-body')
const header = document.querySelectorAll('th')
const checkboxes = document.querySelectorAll('.checkbox-button')

async function getData(){
    const response = await fetch('https://arfp.github.io/tp/web/javascript2/10-cereals/cereals.json')
    const data = await response.json()
    return data
}

document.addEventListener('DOMContentLoaded', setData)
function setData(){
    getData().then(values =>{
        setRows(values.data)
    })
}

function setRows(_values){
    for(let value of _values){
        const row = document.createElement('tr')
        row.setAttribute('id', value.id)
        for(let elem in value){
            const element = document.createElement('td')
            element.textContent = value[elem]
            element.classList.add(elem)
            row.appendChild(element)
        }
        const ns = document.createElement('td')
        ns.textContent = calcNS(value, ns)
        ns.dataset.name = ns.textContent.toLowerCase()
        row.setAttribute('data-visible', "true")
        row.appendChild(ns)
        const del = document.createElement('td')
        del.setAttribute('class', 'delete')
        const buttonDel = document.createElement('button')
        Object.assign(buttonDel, {type: "button", className:"btn-del"})
        buttonDel.textContent = "X"
        del.appendChild(buttonDel)
        row.appendChild(del)
        tBody.appendChild(row)
        const delBtn = document.querySelectorAll('.btn-del')
        for(let i = 0; i < delBtn.length; i++){
            delBtn[i].addEventListener('click', function(){
            deletion(delBtn[i])})
        }
    }
}

function deletion(_btn){
    const lineToDelete = (_btn.parentNode).parentNode
    lineToDelete.style.display = "none"
}

function calcNS(_value, _ns){
    let letter =""
    let rating = Number(_value.rating)
    switch(true){
        case (rating < 35):
            letter = "E";
            _ns.setAttribute('class', 'e nutri-score red')
            _ns.setAttribute('name', letter)
            break;
        case (rating < 55):
            letter = "D";
            _ns.setAttribute('class', 'd nutri-score orange')
            _ns.setAttribute('name', letter)
            break;
        case (rating < 70):
            letter = "C";
            _ns.setAttribute('class', 'c nutri-score dark-yellow')
            _ns.setAttribute('name', letter)
            break;
        case (rating < 80):
            letter = "B";
            _ns.setAttribute('class', 'b nutri-score green')
            _ns.setAttribute('name', letter)
            break;
        case (rating >= 80):
            letter = "A";
            _ns.setAttribute('class', 'a nutri-score dark-green')
            _ns.setAttribute('name', letter)
            break;
        default:
            console.log("Something went wrong !")
            break;
    }
    return letter;
}

for(let i = 0; i < checkboxes.length; i++){
    checkboxes[i].addEventListener('click', function(){
        hideOrNot(checkboxes, i)
    })
}

function hideOrNot(_checkboxes, i){
    const lines = document.querySelectorAll('tr')
    const nutri = document.querySelectorAll('.nutri-score')
    for(let line of lines){
        for(let nscore of nutri){
            if(_checkboxes[i].id == nscore.dataset.name){
                line.dataset.visible = true
            }else{
                line.dataset.visible = false
            }
        }
        
        if(line.dataset.visible){
            line.classList.add('.hidden')
        }else{
            line.classList.add('.displayed')
        }
    }
}