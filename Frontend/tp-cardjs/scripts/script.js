const table = document.querySelector('.table')
const main = document.querySelector('main')
const tHead = table.createTHead()
tHead.setAttribute('class', 'table-head')
const tBody = table.createTBody()
tBody.setAttribute('class', 'tbody')
const head = document.querySelector('.table-head')
const tableBody = document.querySelector('.tbody')
document.addEventListener("DOMContentLoaded",readData)

async function getData(){
    const response = await fetch('https://arfp.github.io/tp/web/javascript/03-cardgame/cardgame.json')
    const data = await response.json()
    return data
}

function readData(){
    getData().then(values =>{
        const firstRow = head.insertRow()
        for(let element in values[0]){
            setFirstLine(element, firstRow)
        }
        for(let object of values){
            const rows = tableBody.insertRow()
            for(elem in object){
                if(elem == "level"){
                    setColumn(object[elem], rows)
                    setColumn(object["description"], rows) ? object["description"]: ""
                }
                if(elem != "description" && elem!="level"){
                    setColumn(object[elem], rows)
                }
            }
        }
        styling()
        calculate(values)
    })
}

function setFirstLine(_value, _firstRow){
    const elem = _firstRow.insertCell()
    if(_value == "description"){
        elem.textContent = "level"
    }else if(_value == "level"){
        elem.textContent = "description"
    }else{
        elem.textContent = _value
    }
    return elem;
}

function setColumn(_value, _row){
    const elem = _row.insertCell()
    elem.textContent = _value
    return elem;
}

function styling(){
    const pairImpair = document.querySelectorAll('tr')
    for(let i = 0; i < pairImpair.length; i++){
        if(i == 0 || i %2 == 0){
            pairImpair[i].classList.add('grey-back')
        }
    }
}

function calculate(_values){
    const div = document.createElement('div')
    const title = document.createElement('h2')
    title.textContent = sortingValues(_values, 'played').name
    const paragraph = document.createElement('p')
    paragraph.textContent = sortingValues(_values, 'armor').name
    const img = document.createElement('img')
    img.setAttribute('src', '../assets/armure.png')
    img.setAttribute('alt', 'Image d\'armure, illustration de carte')
    div.appendChild(title)
    div.appendChild(img)
    div.appendChild(paragraph)
    main.appendChild(div)
}

function sortingValues(_values, param){
    _values.sort((a, b) => a[param] < b[param] ? 1 : -1)
    return _values[0]
}
