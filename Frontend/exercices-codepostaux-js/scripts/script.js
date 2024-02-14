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
        if(searchinput.value != "" && searchinput.value.length >=2){
            console.log("test 2");
            for( let i = 0; i < values.length; i++){
                if(values[i].codePostal.includes(searchinput.value)){
                    datalist.appendChild(getCities(values, i))
                }
            }
            clearTimeout(searchtimer)
            searchtimer = setTimeout(function(){
                searchData()
            },1500)
        }
    });
}

function searchData(){
    if(!isNaN(searchinput.value)){
        searchinput.setAttribute('placeholder', searchinput.value)
        searchinput.setAttribute('zipCode', searchinput.value)
        searchinput.value = ""
    }
}

function getCities(_values, i){
    console.log("test")
    const option = document.createElement('option');
    option.value = _values[i].nomCommune;
    return option
}

function displayInfo(){
    const divInfo = document.createElement('div')
    const cityInfo = document.createTextNode(searchinput.value + " : " + searchinput.getAttribute('zipCode'))
    divInfo.appendChild(cityInfo)
    mainContainer.appendChild(divInfo)
}
