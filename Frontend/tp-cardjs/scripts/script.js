const table = document.querySelector('.table')
const main = document.querySelector('main')
const tHead = table.createTHead()
tHead.setAttribute('class', 'table-head')
const tBody = table.createTBody()
tBody.setAttribute('class', 'tbody')
const head = document.querySelector('.table-head')
const tableBody = document.querySelector('.tbody')
document.addEventListener("DOMContentLoaded",readData)
const cards = document.querySelector('#cards')
let podium = 1

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
        displayCard(values, 'attack')
        displayCard(values, 'armor')
        displayCard(values, 'played')
        displayCard(values, 'victory')
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

function displayCard(_values, _parameter){
    let stat = ""
    const article = document.createElement('article')
    const titleDiv = document.createElement('div')
    titleDiv.setAttribute('class', 'name')
    const numTitle = document.createElement('h3')
    numTitle.textContent = podium
    const nameDiv = document.createElement('div')
    const name = document.createElement('p')
    name.setAttribute('class', 'chara-name')
    const palmares = document.createElement('p')
    name.textContent = sortingValues(_values, _parameter).name
    let span = document.createElement('span')
    span.innerHTML = "Played :";
    const palmValues = document.createTextNode = " " +sortingValues(_values, _parameter).played + " | " + " Victories : " + sortingValues(_values, _parameter).victory
    palmares.append(span, palmValues);
    const mainDiv = document.createElement('div')
    mainDiv.setAttribute('class', "main-div")
    const img = document.createElement('img')
    Object.assign(img, {src: "../assets/armure.png", className: `image-${podium}`, alt: "image chevalier"})
    const stats = document.createElement('div')
    stats.setAttribute('class', 'stats-div')
    for(let i = 0; i < 3; i++){
        if(i == 0){
            stat = "power"
        }else if(i == 1){
            stat = "attack"
        }else{
            stat = "armor"
        }
        const eachStat = document.createElement('p')
        eachStat.textContent = capitalizeFirstLetter(stat)
        const statValue = document.createElement('p')
        statValue.setAttribute('class', stat)
        statValue.textContent = sortingValues(_values, _parameter)[stat]
        stats.append(eachStat, statValue)
    }
    mainDiv.append(img, stats)
    nameDiv.append(name, palmares)
    titleDiv.append(numTitle, nameDiv)
    article.append(titleDiv, mainDiv)
    cards.appendChild(article)
    podium++
}

function cardDescTitle(_stat){
    const textTitle = document.createElement('p')
    textTitle.textContent = (_stat == "armor")? _stat = "Defense" : capitalizeFirstLetter(_stat);
    return textTitle
}

function cardDescValue(_values, _parameter, _stat){
    const paragraph = document.createElement('p')
    paragraph.textContent = sortingValues(_values, _parameter)[_stat]
    return paragraph
}

function sortingValues(_values, _param){
    _values.sort((a, b) => a[_param] < b[_param] ? 1 : -1)
    return _values[0]
}

function capitalizeFirstLetter(string) {
    return string.charAt(0).toUpperCase() + string.slice(1);
}