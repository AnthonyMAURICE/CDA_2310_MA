const mainContainer = document.querySelector('main')
const searchBar = document.createElement('input')
searchBar.setAttribute("type", "search")
searchBar.setAttribute("list", "searchBar")
searchBar.setAttribute("autocomplete", "true")
const button = document.createElement('button')
const buttonText = document.createTextNode("Valider")
button.setAttribute("type", "button")
button.appendChild(buttonText)
mainContainer.appendChild(searchBar)
mainContainer.appendChild(button)
const datalist = document.createElement('datalist');
datalist.setAttribute("id", "searchBar")
datalist.setAttribute("name", "search")

searchBar.addEventListener('change', createList)


async function getJson(){
    const response = await fetch('https://arfp.github.io/tp/web/javascript/02-zipcodes/zipcodes.json')
    const data = await response.json()
    return data
}

function createList(){
    getJson().then(values => {   
        datalist.replaceChildren()
        if(searchBar.value != ""){
            for( let i = 0; i < values.length; i++){
                if(values[i].codePostal.includes(searchBar.value)){
                    datalist.appendChild(getCities(values, i))
                }
            }
        }
        searchBar.setAttribute('placeholder', searchBar.value)
        searchBar.value = "";
        mainContainer.appendChild(datalist);
    });
}

function getCities(_values, i){
    console.log("test")
    const option = document.createElement('option');
    option.value = _values[i].nomCommune;
    option.label = _values[i].nomCommune;
    return option
}
