const datalist = document.querySelector('#searchBar');
const searchinput = document.querySelector('#input')
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
        if(!isNaN(searchinput.value) && searchinput.value.length >=2){
            for(let i = 0; i < values.length; i++){
                if(values[i].codePostal.includes(searchinput.value)){
                    searchinput.removeEventListener('input', createList)
                    datalist.appendChild(getCities(values, i))
                    btn.removeAttribute('disabled')
                }
            }
        }
    });
}

function getCities(_values, i){
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
    divInfo.textContent = ("Ville : " +datalist.options.namedItem(valueInput).getAttribute('id') + ", Code Postal : " + datalist.options.namedItem(valueInput).getAttribute('label'))
    mainContainer.appendChild(divInfo)
}