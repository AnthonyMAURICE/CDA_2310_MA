const body = document.querySelector('body')
document.addEventListener('DOMContentLoaded', setData)

async function fetchData(){
    const response = await fetch('../data/resultat10000metres.json')
    const data = await response.json()
    return data
}

function setData(){
    fetchData().then(values =>{
        valuesArray = Array.from(values)
        createInputs(valuesArray)
        createTable(valuesArray)
    })
}

function createInputs(_values){
    for(let i = 0; i < 2; i++){
        const input = document.createElement('input')
        input.setAttribute('type', 'text')
        input.setAttribute('class', 'first-inputs')
        body.appendChild(input)
    }
}

function createTable(_values){
    const table = document.createElement('table')
    table.appendChild(createTableHead())
    const filters = document.createElement('div')
    const tbody = document.createElement('tbody')
    sortTemps(_values)
    for(let i = 0; i < _values.length; i++){
        const row = document.createElement('tr')
        row.setAttribute('class', 'rows')
        row.append(getPays(_values[i]), getName(_values[i]), getFirstName(_values[i]), getTime(_values[i]))
        filters.appendChild(createFilters(_values, sortByCountries(_values), i))
        filters.appendChild(createLabels(sortByCountries(_values), i))
        tbody.appendChild(row)
    }
    body.appendChild(filters)
    table.appendChild(tbody)
    body.appendChild(table)
    updateInputs(_values)
}

function createTableHead(){
    const tableHead = document.createElement('thead')
    for(let i = 0; i < 4; i++){
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
    label.setAttribute('class', `country-check`)
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
        inputs[i].value = i == 0 ? `${_values.length} participants` : `Gagnant : ${_values[0].nom}`
    }
}

function isVisible(_valuesOrigin, _values){
    let checkedBox = document.querySelectorAll('input:checked');
    console.log(_values)
}