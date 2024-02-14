const datalist = document.querySelector('#searchBar');
const searchinput = document.querySelector('#input')
let searchtimer;
searchinput.addEventListener('input', createList)

const mainContainer = document.querySelector('main')
const btn = document.querySelector('button')

btn.addEventListener("click", displayInfo)

async function getJson(){
    const response = await fetch('https://arfp.github.io/tp/web/javascript/02-zipcodes/zipcodes.json')
    const data = await response.json()
    return data
}

function createList(){
    getJson().then(values => {   
        datalist.replaceChildren()
        if(!isNaN(searchinput.value) && searchinput.value != "" && searchinput.value.length >=2 && searchinput.value.length <=5){
            console.log("test 2");
            for( let i = 0; i < values.length; i++){
                if(values[i].codePostal.includes(searchinput.value)){
                    searchinput.removeEventListener('input', createList)
                    datalist.appendChild(getCities(values, i))
                }
            }
        }
    });
}

function getCities(_values, i){
    console.log("test")
    const option = document.createElement('option');
    option.setAttribute('id', _values[i].nomCommune)
    option.value = _values[i].nomCommune;
    searchinput.setAttribute('value', option.value)
    option.label = _values[i].codePostal;
    return option
}

function displayInfo(){
    const divInfo = document.createElement('div')
    const valueInput = searchinput.value;
    console.log(valueInput)
    console.log(datalist.options.namedItem(valueInput))
    const cityInfo = document.createTextNode(datalist.options.namedItem(valueInput).getAttribute('id') + " : " + datalist.options.namedItem(valueInput).getAttribute('label'))
    divInfo.appendChild(cityInfo)
    mainContainer.appendChild(divInfo)
}
