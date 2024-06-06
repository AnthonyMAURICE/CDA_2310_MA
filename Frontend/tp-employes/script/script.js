const table = document.querySelector('#emp-table')
document.addEventListener('DOMContentLoaded', setData)
let asc = true
const salaryCol = document.querySelector('#salary').addEventListener('click', sorting)


async function fetchData(){
    const response = await fetch('https://arfp.github.io/tp/web/javascript2/03-employees/employees.json')
    const data = await response.json()
    return data
}

function setData(){
    fetchData().then(values =>{
        for(let i = 0; i < values.data.length; i++){
            createInitialTable(values.data[i])
        }
        btnEnablers()
    })
}

function createInitialTable(values){
    console.log(values)
    const row = document.createElement('tr')
    row.setAttribute('id', values.id)
    row.setAttribute('class', 'rows')
    row.appendChild(identifier(values.id))
    row.appendChild(getName(values))
    row.appendChild(calcEmail(values))
    row.appendChild(getSalary(values))
    row.appendChild(getYearofBirth(values))
    row.appendChild(calcBtn())
    table.appendChild(row)
    //const deleteBtn = document.querySelectorAll('.delete')
    
}


// for(let i = 0; i< deleteBtn.length; i++){
//     deleteBtn[i].addEventListener('click', function(){
//         delRow(deleteBtn[i])
//     })
// }

function btnEnablers(){
    const duplicateBtn = document.querySelectorAll('.duplicate')
    for(let i = 0; i< duplicateBtn.length; i++){
        duplicateBtn[i].addEventListener('click', function(){
        duplicateRow(duplicateBtn[i])
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
    btn.setAttribute("class", btn.textContent.toLowerCase())
    return btn
}

function delRow(_btn){
    const lineToDelete = _btn.closest("tr")
    lineToDelete.style.display = "none"
}

function duplicateRow(_btn){
    const numberOfRows = document.querySelectorAll('tr')
    const lineToDuplicate = _btn.closest("tr")
    console.log(lineToDuplicate)
//     const clone = lineToDuplicate.cloneNode(true)
//     const eid = clone.children[0]
//     eid.setAttribute('class', numberOfRows.length++)
//     eid.textContent = numberOfRows.length++
//     table.appendChild(clone)
//     btnEnablers()
}

function sorting(){
    const array = document.querySelectorAll('.rows')
    const arr = Array.from(array)
    if(!asc){
        arr.sort((a, b) => a.id - b.id)
    }else{
        arr.sort((a, b) => b.id - a.id)
    }
    arr.forEach(elem => {                   
        table.appendChild(elem)
    })
    asc = !asc
}