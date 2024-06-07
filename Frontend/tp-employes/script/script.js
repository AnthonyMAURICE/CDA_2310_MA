const table = document.querySelector('#emp-table')
document.addEventListener('DOMContentLoaded', setData)
let asc = true
let firstGeneration = true
const salaryCol = document.querySelector('#salary').addEventListener('click', sorting)


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
    }
    btn()
}

function btn(){
    const duplicateBtn = document.querySelectorAll('.duplicate')
    for(let i = 0; i < duplicateBtn.length; i++){
        duplicateBtn[i].addEventListener('click', function(){
        duplicateRow(duplicateBtn[i])
        })
    }
    const deleteBtn = document.querySelectorAll('.delete')
    for(let i = 0; i< deleteBtn.length; i++){
        deleteBtn[i].addEventListener('click', function(){
        delRow(deleteBtn[i])
        })
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
    btn.setAttribute('id', `btn${i}`)
    btn.setAttribute("class", btn.textContent.toLowerCase())
    return btn
}

function delRow(_btn){
    const lineToDelete = _btn.closest("tr")
    lineToDelete.style.display = "none"
}

function duplicateRow(_btn){
    const numberOfRows = document.querySelectorAll('tr')
    const lineToDuplicate = Number(_btn.closest("tr").id)
    const clone = numberOfRows[lineToDuplicate]
    clone.firstElementChild.setAttribute('id', numberOfRows.length)
    const newRow = table.insertRow()
    for(let i = 0; i < clone.childNodes.length; i++){
        newRow.appendChild(clone.childNodes[i])
    }
    
    console.log(newRow)
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