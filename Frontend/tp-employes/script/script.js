const table = document.querySelector('#emp-table')
document.addEventListener('DOMContentLoaded', setData)
let asc = true
const salaryCol = document.querySelector('#salary').addEventListener('click', sorting)
let tableLength = 1

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

function createTable(values){
    for(let i = 0; i< values.length; i++){
        const row = document.createElement('tr')
        row.setAttribute('id', values[i].id)
        row.setAttribute('class', 'rows')
        row.appendChild(identifier(values[i].id))
        row.appendChild(getName(values[i]))
        row.appendChild(calcEmail(values[i]))
        row.appendChild(getSalary(values[i]))
        row.appendChild(getYearofBirth(values[i]))
        row.appendChild(calcBtn())
        table.appendChild(row)
        tableLength++
    }
}

function identifier(value){
    const id = document.createElement('td')
    id.setAttribute('class', value)
    id.textContent = value
    return id
}

function getName(value){
    const name = document.createElement('td')
    name.textContent = value.employee_name
    return name
}

function calcEmail(value){
    const mail = document.createElement('td')
    let email = value.employee_name.toLowerCase()[0] + "." + value.employee_name.toLowerCase().split(" ")[1] + "@email.com"
    mail.textContent = email
    return mail
}

function getSalary(value){
    const salary = document.createElement('td')
    salary.textContent = Math.round((value.employee_salary/12)*100)/100 + " €"
    return salary
}

function getYearofBirth(value){
    const year = document.createElement('td')
    let date = new Date()
    year.textContent = date.getFullYear() - value.employee_age
    return year
}

function calcBtn(){
    const buttons = document.createElement('td')
    for(let i = 0; i < 2; i++){
        buttons.appendChild(createBtn(i))
    }
    return buttons
}

function createBtn(i){
    const btn = document.createElement('button')
    btn.textContent = i==0? "Duplicate" : "Delete"
    btn.setAttribute("class", btn.textContent.toLowerCase())
    if(i==0){
        btn.addEventListener('click', function(){
            duplicateRow(btn)})
    }else{
        btn.addEventListener('click', function(){
            delRow(btn)})
    }
    return btn
}

function delRow(_btn){
    const lineToDelete = _btn.closest("tr")
    lineToDelete.remove()
    const numberOfRows = document.querySelectorAll('tr')
    if(numberOfRows.length == 1){
        noEmp()
    }
}

function duplicateRow(_btn){
    const lineToDuplicate = _btn.closest('tr')
    const clone = lineToDuplicate.cloneNode(true)
    clone.removeAttribute('id')
    clone.setAttribute('id', tableLength)
    clone.children[0].textContent = tableLength
    tableLength++
    const button = clone.children[5].querySelectorAll('button')
    button[0].addEventListener('click', function(){
        duplicateRow(button[0])})
    button[1].addEventListener('click', function(){
        delRow(button[1])})
    table.appendChild(clone)
}

function sorting(){
    const array = document.querySelectorAll('.rows')
    const arr = Array.from(array)
    arr.sort((a, b) => {
        let a_value = a.children[3].innerText.split(" ")[0]
        let b_value = b.children[3].innerText.split(" ")[0]
        console.log(a_value)
        return (asc) ? b_value - a_value : a_value - b_value
    })
    arr.forEach(elem => {                   
        table.appendChild(elem)
    })
    asc = !asc
}

function noEmp(){
    document.querySelector('#paragraph').textContent = 'This is the current list of NO EMPLOYEES'
}