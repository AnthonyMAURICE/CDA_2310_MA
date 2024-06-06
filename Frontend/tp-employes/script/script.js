const table = document.querySelector('#emp-table')


async function fetchData(){
    const response = await fetch('https://arfp.github.io/tp/web/javascript2/03-employees/employees.json')
    const data = await response.json()
    return data
}

document.addEventListener('DOMContentLoaded', setData)

function setData(){
    fetchData().then(values =>{
        createInitialTable(values.data)
    })
}

function createInitialTable(values){
    for(let i = 0; i < values.length; i++){
        const row = document.createElement('tr')
        row.appendChild(identifier(values[i]))
        row.appendChild(getName(values[i]))
        row.appendChild(calcEmail(values[i]))
        row.appendChild(getSalary(values[i]))
        table.appendChild(row)
    }
}

function identifier(value){
    const id = document.createElement('td')
    id.textContent = value.id
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