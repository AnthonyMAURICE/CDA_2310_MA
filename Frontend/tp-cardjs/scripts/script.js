const table = document.querySelector('.tbody')
const main = document.querySelector('main')

async function getData(){
    const response = await fetch('https://arfp.github.io/tp/web/javascript/03-cardgame/cardgame.json')
    const data = await response.json()
    return data
}

function readData(){
    getData().then(values =>{
        for(let value of values){
            const row = document.createElement('tr')
            row.appendChild(setColumn(value.id))
            row.appendChild(setColumn(value.name))
            row.appendChild(setColumn(value.level))
            row.appendChild(setColumn(""))
            row.appendChild(setColumn(value.power))
            row.appendChild(setColumn(value.attack))
            row.appendChild(setColumn(value.armor))
            row.appendChild(setColumn(value.damage))
            row.appendChild(setColumn(value.mitigation))
            row.appendChild(setColumn(value.played))
            row.appendChild(setColumn(value.victory))
            row.appendChild(setColumn(value.defeat))
            row.appendChild(setColumn(value.draw))
            table.appendChild(row)
            
        }
        styling()
        const div = document.createElement('div')
        const paragraphFirst = document.createElement('p')
        const playedMost = document.createTextNode(mostPlayed(values))
        paragraphFirst.appendChild(playedMost)
        main.appendChild(div)
        const paragraph2 = document.createElement('p')
        const mostVictorious = document.createTextNode(calculRatio(values))
        paragraph2.appendChild(mostVictorious)
        div.appendChild(paragraphFirst)
        div.appendChild(paragraph2)
        main.appendChild(div)
    })
}

readData()

function setColumn(_value){
    const elem = document.createElement('td')
    const elemText = document.createTextNode(_value)
    elem.appendChild(elemText)
    return elem;
}

function styling(){
    const pairImpair = document.querySelectorAll('tr')
    console.log(pairImpair)
    for(let i = 0; i < pairImpair.length; i++){
        if(i == 0 || i %2 == 0){
            pairImpair[i].classList.add('greyBack')
        }
    }
}

function mostPlayed(_values){
    _values.sort(compare)
    console.log(_values)
    return "Ayant le plus joué : " + _values[0].name + " avec " + _values[0].victory + " victoires."
}

function compare( a, b ) {
    if ( a.played < b.played ){
    return 1;
    }
    if ( a.played > b.played ){
    return -1;
    }
    return 0;
}

function compareVictoryDefeat( a, b ) {
    if ( (a.victory/a.defeat) < (b.victory/b.defeat) ){
    return 1;
    }
    if ( (a.victory/a.defeat) > (b.victory/b.defeat) ){
    return -1;
    }
    return 0;
}

function calculRatio(_values){
    _values.sort(compareVictoryDefeat)
    console.log(_values)
    return "Le joueur avec le meilleur ratio victoire/défaite est : " + _values[0].name + " avec " + _values[0].victory + " victoires pour " + _values[0].played + " parties."
}