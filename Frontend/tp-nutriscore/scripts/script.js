const head = document.querySelector('#t-head')
const tBody = document.querySelector('#t-body')
const header = document.querySelectorAll('th')

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
        row.appendChild(ns)
        const del = document.createElement('td')
        del.classList.add('delete')
        const buttonDel = document.createElement('button')
        buttonDel.textContent = "X"
        del.appendChild(buttonDel)
        row.appendChild(del)
        tBody.appendChild(row)
    }
}

function calcNS(value, ns){
    let letter =""
    let rating = Number(value.rating)
    switch(true){
        case (rating < 35):
            letter = "E";
            ns.setAttribute('class', 'nutri-score red')
            break;
        case (rating < 55):
            letter = "D";
            ns.setAttribute('class', 'nutri-score orange')
            break;
        case (rating < 70):
            letter = "C";
            ns.setAttribute('class', 'nutri-score dark-yellow')
            break;
        case (rating < 80):
            letter = "B";
            ns.setAttribute('class', 'nutri-score green')
            break;
        case (rating >= 80):
            letter = "A";
            ns.setAttribute('class', 'nutri-score dark-green')
            break;
        default:
            console.log("Something went wrong !")
            break;
    }
    return letter;
}