const mainContainer = document.querySelector('main')
const searchBar = document.createElement('input')
searchBar.setAttribute("type", "search")
searchBar.setAttribute("list", "search")
const button = document.createElement('button')
const buttonText = document.createTextNode("Valider")
button.setAttribute("type", "button")
button.appendChild(buttonText)
mainContainer.appendChild(searchBar)
mainContainer.appendChild(button)

document.addEventListener('DOMContentLoaded', createList);

async function getJson(){
    const response = await fetch('https://arfp.github.io/tp/web/javascript/02-zipcodes/zipcodes.json')
    const data = await response.json()
    return data
}

function createList(){
    const datalist = document.createElement('datalist');
    datalist.setAttribute("id", "search")
    getJson().then(values => {
        for(let value of values){
            const option = document.createElement('option')
            const element = document.createTextNode(value.nomCommune)
            option.appendChild(element)
            datalist.appendChild(option);
        }
        searchBar.addEventListener("change", function(){
            getByZipcode(values);
        })
    })
    mainContainer.appendChild(datalist);
}

function getByZipcode(values){
    return values;
}