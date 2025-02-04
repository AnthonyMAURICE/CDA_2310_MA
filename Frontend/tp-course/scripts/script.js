const body = document.querySelector('body')
document.addEventListener('DOMContentLoaded', setData)

async function fetchData(){
    const response = await fetch('./data/resultat10000metres.json')
    const data = await response.json()
    return data
}

function setData(){
    fetchData().then(values =>{
        valuesArray = Array.from(values)
        createInputs(valuesArray)
        createTable(valuesArray, getBaseTime(valuesArray))
        updateInputs(valuesArray)
    })
}

function createInputs(_values){
    const titleH2 = document.createElement('h2')
    titleH2.textContent = 'Filtrer'
    for(let i = 0; i < 3; i++){
        const input = document.createElement('input')
        input.setAttribute('type', 'text')
        input.setAttribute('class', 'first-inputs')
        input.setAttribute('readonly', 'true')
        body.appendChild(input)
    }    
    const filterWrapper = document.createElement('div')
    filterWrapper.setAttribute('id', 'filter-wrap')
    for(let i = 0; i < _values.length; i++){
        const filters = document.createElement('div')
        filters.setAttribute('class', 'filters')
        filters.appendChild(createFilters(_values, sortByCountries(_values), i))
        filters.appendChild(createLabels(sortByCountries(_values), i))
        filterWrapper.appendChild(filters)
    }
    body.append(titleH2, filterWrapper)
}

function createTable(_values, _basetime){
    const table = document.createElement('table')
    table.appendChild(createTableHead())
    const tbody = document.createElement('tbody')
    sortTemps(_values)
    for(let i = 0; i < _values.length; i++){
        const row = document.createElement('tr')
        row.setAttribute('class', 'rows')
        row.append(getPays(_values[i]), getName(_values[i]), getFirstName(_values[i]), getTime(_values[i]), createLastCell(_values[i], _basetime))
        tbody.appendChild(row)
    }
    table.appendChild(tbody)
    body.appendChild(table)
    
}

function createTableHead(){
    const tableHead = document.createElement('thead')
    for(let i = 0; i < 5; i++){
        const thCells = document.createElement('th')
        switch(i){
            case 0:
                thCells.textContent = "Pays"
                break
            case 1:
                thCells.textContent = "Nom"
                break
            case 2:
                thCells.textContent = "Prénom"
                break
            case 3:
                thCells.textContent = "Temps Final"
                break
            case 4:
                thCells.textContent = "Écart gagnant"
                break
            default:
                "something went wrong"
        }
        tableHead.appendChild(thCells)
    }
    return tableHead
}

function createFilters(_values, _country, i){
    const check = document.createElement('input')
    check.setAttribute('type', 'checkbox')
    check.setAttribute('id', _country[i].toLowerCase())
    check.setAttribute('name', _country[i].toLowerCase())
    check.setAttribute('class', 'country-check')
    check.addEventListener('change', function(){
        isVisible(_values, _values)
    })
    return check
}

function createLabels(_country, i){
    const label = document.createElement('label')
    label.setAttribute('name', _country[i].toLowerCase())
    label.textContent = _country[i]
    return label
}

function getPays(_value){
    const cell = document.createElement('td')
    cell.textContent = _value.pays
    return cell
}

function getName(_value){
    const cell = document.createElement('td')
    cell.textContent = _value.nom.split(" ")[0]
    return cell
}

function getFirstName(_value){
    const cell = document.createElement('td')
    cell.textContent = _value.nom.split(" ")[1]
    return cell
}

function getTime(_value){
    const cell = document.createElement('td')
    cell.textContent = timeToString(_value.temps)
    return cell
}

function timeToString(t) {
    let date = new Date(t * 1000);
    let minutes =  date.getUTCMinutes();
    let seconds =  date.getSeconds();
    return `${minutes}min${seconds}s`
}

function getBaseTime(_values){
    sortTemps(_values)
    return _values[0].temps
}

function createLastCell(_value, _basetime){
    const cell = document.createElement('td')
    cell.textContent = "+" + (_value.temps - _basetime) + "s"
    return cell
}

function sortTemps(_values){
    _values.sort((a,b) => a.temps - b.temps);
}

function sortByCountries(_values){
    const countries = _values.map((x) => x.pays)
    countries.sort()
    return countries
}

function updateInputs(_values){
    const inputs = document.querySelectorAll('.first-inputs')
    for(let i = 0; i < inputs.length; i++){
        switch(i){
            case 0:
                inputs[i].value = `${_values.length} participants`
                break
            case 1:
                inputs[i].value = `Gagnant : ${_values[0].nom}`
                break
            case 2:
                inputs[i].value = 'Temps moyen = ' + getAverage(_values)
                break
            default:
                console.log('something went wrong')
        }
    }
}

function getAverage(_values){
    const average = arr => arr.reduce( ( a, b) => a + b, 0 ) / arr.length;
    const sum = _values.map((x) => Number(x.temps))
    return timeToString(average(sum))
}

function isVisible(_values){
    let visible = []
    let checkedBox = document.querySelectorAll('.country-check');
    const mainNode = document.querySelector("table");
    mainNode.remove()
    for(let i = 0; i < checkedBox.length; i++){
        for (let j = _values.length - 1; j >= 0; --j) {
            if(checkedBox[i].checked){
                if (_values[j].pays.toLowerCase() == checkedBox[i].id) {
                    visible.push(_values[j])
                }
            }
        }
        if(!checkedBox[i].checked){
            for(let k = 0; k < visible.length; k++){
                if (visible[k].pays.toLowerCase() == checkedBox[i].id) {
                    visible.splice(k,1);
                }
            }
            
        }
    }
    if(visible.length != 0){
        createTable(visible, getBaseTime(_values))
    }else{
        createTable(_values, getBaseTime(_values))
    }
    
}