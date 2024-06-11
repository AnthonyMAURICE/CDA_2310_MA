const table = document.querySelector('#emp-table')
document.addEventListener('DOMContentLoaded', setData)
let asc = true

async function fetchData(){
    const response = await fetch('https://arfp.github.io/tp/web/javascript2/03-employees/employees.json')
    const data = await response.json()
    return data
}

function setData(){
    fetchData().then(values =>{
        createTable(values.data)
    })
}

function createTable(_values){
    createFirstRow()
    const body = document.createElement('tbody')
    for(let i = 0; i< _values.length; i++){
        const row = document.createElement('tr')
        row.setAttribute('id', _values[i].id)
        row.setAttribute('class', 'rows')
        row.append(identifier(_values[i].id), getName(_values[i]), calcEmail(_values[i]), getSalary(_values[i]), getYearofBirth(_values[i]), calcBtn())
        body.appendChild(row)
    }
    table.appendChild(body)
    table.appendChild(createLastRow())
}

function createFirstRow(){
    const tableHead = document.createElement('thead')
    for(let i = 0; i < 6; i++){
        const headCell = document.createElement('th')
        switch(i){
            case 0:
                headCell.textContent = 'EID'
                break
            case 1:
                headCell.textContent = 'Full Name'
                break
            case 2:
                headCell.textContent = 'Email'
                break
            case 3:
                headCell.textContent = 'Monthly salary'
                const sortButton = document.createElement('button')
                sortButton.setAttribute('id', 'salary')
                sortButton.addEventListener('click', sorting)
                sortButton.textContent = 'Sort'
                headCell.appendChild(sortButton)
                break
            case 4:
                headCell.textContent = 'Year of birth'
                break
            case 5:
                headCell.textContent = 'Actions'
                break
            default:
                headCell.textContent = 'Something went wrong'
        }
        tableHead.appendChild(headCell)
    }
    table.appendChild(tableHead)
}

function createLastRow(){
    const tableFooter = document.createElement('tfoot')
    for(let i = 0; i < 6; i++){
        const footerCell = document.createElement('td')
        if(i == 0){
            footerCell.textContent = calcTableLength()
        }else if (i == 3){
            
            footerCell.textContent = calcSum()
        }else{
            footerCell.setAttribute('class', 'last-row-cell')
        }
        tableFooter.appendChild(footerCell)
    }
    return tableFooter
}

function calcSum(){
    let sum = 0
    const rows = document.querySelectorAll('tr')
    for(let i = 0; i < rows.length; i++){
        sum += Number(rows[i].children[3].innerText.split(" ")[0])
    }
    sum = Math.round((sum)*100)/100 + "€"
    return sum
}

function calcTableLength(){
    const rows = document.querySelectorAll('tr')
    return rows.length
}

function identifier(_value){
    const id = document.createElement('td')
    id.textContent = _value
    return id
}

function getName(_value){
    const name = document.createElement('td')
    name.textContent = _value.employee_name
    return name
}

function calcEmail(_value){
    const mail = document.createElement('td')
    mail.textContent = _value.employee_name.toLowerCase()[0] + "." + _value.employee_name.toLowerCase().split(" ")[1] + "@email.com"
    return mail
}

function getSalary(_value){
    const salary = document.createElement('td')
    salary.textContent = Math.round((_value.employee_salary/12)*100)/100 + " €"
    return salary
}

function getYearofBirth(_value){
    const year = document.createElement('td')
    let date = new Date()
    year.textContent = date.getFullYear() - _value.employee_age
    return year
}

function calcBtn(){
    const buttons = document.createElement('td')
    for(let i = 0; i < 2; i++){
        buttons.appendChild(createBtn(i))
    }
    return buttons
}

function createBtn(_i){
    const btn = document.createElement('button')
    btn.textContent = _i==0? "Duplicate" : "Delete"
    btn.setAttribute("class", btn.textContent.toLowerCase())
    if(_i==0){
        eventListenerDuplicate(btn)
    }else{
        eventListenerDelete(btn)
    }
    return btn
}

function sorting(){
    const arr = Array.from(document.querySelectorAll('tr'))
    arr.sort((a, b) => {
        let a_value = a.children[3].innerText.split(" ")[0]
        let b_value = b.children[3].innerText.split(" ")[0]
        return (asc) ? b_value - a_value : a_value - b_value
    })
    arr.forEach(elem => {                   
        table.appendChild(elem)
    })
    asc = !asc
}

function delRow(_btn){
    _btn.closest("tr").remove()
    if(calcTableLength() == 0){
        noEmp()
    }
    editFooter()
}

function duplicateRow(_btn){
    const clone = _btn.closest('tr').cloneNode(true)
    clone.id = getAvaiableId()
    clone.children[0].textContent = clone.id
    const button = clone.children[5].querySelectorAll('button')
    eventListenerDuplicate(button[0])
    eventListenerDelete(button[1])
    document.querySelector('tbody').appendChild(clone)
    sortingAfterDuplicate()
    editFooter()
}

function sortingAfterDuplicate(){
    const arr = Array.from(document.querySelectorAll('tr'))
    arr.sort((a, b) => {
        return a.id - b.id
    })
    arr.forEach(elem => {                   
        document.querySelector('tbody').appendChild(elem)
    })
}

function eventListenerDuplicate(_btn){
    _btn.addEventListener('click', function(){
        duplicateRow(_btn)})
}

function eventListenerDelete(_btn){
    _btn.addEventListener('click', function(){
        delRow(_btn)})
}

function editFooter(){
    const footer = document.querySelector('tfoot')
    footer.children[0].textContent = calcTableLength()
    footer.children[3].textContent = calcSum()
}

function noEmp(){
    document.querySelector('#paragraph').textContent = 'This is the current list of NO EMPLOYEES'
}

function getAvaiableId(){
    const rows = Array.from(document.querySelectorAll('tr'))
    const ids = rows.map((x) => Number(x.id))
    let availableId = []
    for(let i = 1; i < rows.length; i++){
        if(!ids.includes(i)){
            availableId.push(i)
        }
    }
    return availableId.length == 0 ? rows.length + 1 : availableId[0]
}