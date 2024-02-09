const mainContainer = document.querySelector('main')
const searchBar = document.createElement('input')
searchBar.setAttribute("type", "search")
const button = document.createElement('button')
const buttonText = document.createTextNode("Valider")
button.setAttribute("type", "button")
button.appendChild(buttonText)
mainContainer.appendChild(searchBar)
mainContainer.appendChild(button)

async function getJson(){
    const response = await fetch('https://arfp.github.io/tp/web/javascript/02-zipcodes/zipcodes.json')
    const data = await response.json()
    return data
}

getJson().then(value => {
    
})

