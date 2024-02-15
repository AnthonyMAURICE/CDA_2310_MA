const table = document.querySelector('.tbody')
const head = document.querySelector('.table-head')
const main = document.querySelector('main')
document.addEventListener("DOMContentLoaded",readData)

async function getData(){
    const response = await fetch('https://arfp.github.io/tp/web/javascript/03-cardgame/cardgame.json')
    const data = await response.json()
    return data
}

function readData(){
    getData().then(values =>{
        const firstRow = document.createElement('tr')
        for(let element in values[0]){
            firstRow.appendChild(setFirstLine(element))
        }
        head.appendChild(firstRow)
        for(let value of values){
            const row = document.createElement('tr')
            for(elem in value){
                if(elem == "level"){
                    row.appendChild(setColumn(value[elem]))
                    row.appendChild(setColumn((value["description"]) ? value["description"] + " ?": ""))
                }else if(elem != "description"){
                    row.appendChild(setColumn(value[elem]))
                }
            }
            table.appendChild(row)
        }
        styling()
        calculate(values)
    })
}

function setFirstLine(_value){
    const elem = document.createElement('th')
    if(_value == "description"){
        elem.textContent = "level"
    }else if(_value == "level"){
        elem.textContent = "description"
    }else{
        elem.textContent = _value
    }
    return elem;
}

function setColumn(_value){
    const elem = document.createElement('td')
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
    const paragraph = document.createElement('p')
    paragraph.textContent = mostPlayed(_values) + " / " + calculRatio(_values);
    div.appendChild(paragraph)
    main.appendChild(div)
}

function mostPlayed(_values){
    _values.sort((a, b) => a.played < b.played ? 1 : -1)
    return "Ayant le plus joué : " + _values[0].name + " avec " + _values[0].victory + " victoires."
}

function calculRatio(_values){
    _values.sort((a, b) => a.victory/a.defeat < b.victory/b.defeat ? 1 : -1)
    return "Le joueur avec le meilleur ratio victoire/défaite est : " + _values[0].name + " avec " + _values[0].victory + " victoires pour " + _values[0].played + " parties."
}