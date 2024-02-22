let save = localStorage
const head = document.querySelector('#t-head')
const tBody = document.querySelector('#t-body')
const header = document.querySelectorAll('th')
const checkboxes = document.querySelectorAll('.checkbox-button')
const searchInput = document.querySelector('.search-input')
const select = document.querySelector('#cat-select')

class Cereals{
    constructor(name, sugar, salt, vits, fiber, tagName){
        this.name = name
        this.sugar = sugar
        this.salt = salt
        this.vits = vits
        this.fiber = fiber
        this.tagName = document.createElement(tagName)
        this.nScore
        this.visible = true;
    }

    get visibility(){
        return this.visible
    }

    get rowLine(){
        return this.tagName
    }

    get nScore(){
        return this._nScore
    }

    set nScore(value){
        this._nScore = value
    }

    static createdRow(value){
        const cereal = new Cereals(value.name, value.sugars, value.sodium, value.vitamins, value.fiber, "tr")
        return cereal
    }

    set visibility(_value){
        this.visible = _value
    }

    setVisibility(){
        this.visible = false
        let checkedBox = document.querySelectorAll('input:checked');
        if(checkedBox.length === 0){
            this.visible = true
        }else{
            for(let i = 0; i < checkedBox.length; i++){
                if(this.visible || this.nScore.toLowerCase() === checkedBox[i].id){
                    this.visible = true
                }else{
                    this.visible = false
                }
            }
        }
        return this.visible
    }

    visibilityByName(){
        this.visible = false
        if((this.name.toLowerCase().includes(searchInput.value.toLowerCase()))|| searchInput.value == ""){
            this.visible = true
        }
        return this.visible
    }

    isVisible(){
        this.visible ? this.tagName.style.display = "table-row": this.tagName.style.display = "none"
    }

    appendElement(_tBody){
        _tBody.appendChild(this.tagName)
    }

    thirdFilter(){
        switch(select.value){
            case "no-sugar":
                this.sugar < 1? this.visible = true: this.visible = false
                break
            case "salt-poor":
                this.salt < 50? this.visible = true: this.visible = false
                break
            case "boost":
                (this.vits >= 25 && this.fiber >= 10)? this.visible = true: this.visible = false
                break
            case "all":
                this.visible = true
                break
            default:
                this.visible = false
                break
        }
        return this.visible
    }

    searchBar(){
        this.visibilityByName()
    }

    displayResults(){
        if(this.visibilityByName() && this.thirdFilter() && this.setVisibility()){
            this.visible = true
        }else{
            this.visible = false
        }
        this.isVisible()
    }
}

async function getData(){
    const response = await fetch('https://arfp.github.io/tp/web/javascript2/10-cereals/cereals.json')
    const data = await response.json()
    return data
}

document.addEventListener('DOMContentLoaded', setData)
function setData(){
    getData().then(values =>{
        if(localStorage.getItem("file") === null){
            setCereals(values.data)
        }else{
            let file = JSON.parse(save.getItem("file"))
            setCereals(file)
        }
    })
}

function setCereals(_values){
    for(let value of _values){
        const rowElem = Cereals.createdRow(value)
        rowElem.appendElement(tBody)
        for(let elem in value){
            const element = document.createElement('td')
            Object.assign(element, {textContent: value[elem], className: elem})
            rowElem.tagName.appendChild(element)
        }
        const ns = document.createElement('td')
        rowElem.nScore = calcNS(value, ns)
        ns.textContent = rowElem.nScore
        rowElem.tagName.appendChild(ns)
        const del = document.createElement('td')
        del.setAttribute('class', 'delete')
        const buttonDel = document.createElement('button')
        Object.assign(buttonDel, {type: "button", className:"btn-del", textContent: "X"})
        del.appendChild(buttonDel)
        rowElem.tagName.appendChild(del)
        const delBtn = document.querySelectorAll('.btn-del')
        for(let i = 0; i < delBtn.length; i++){
            delBtn[i].addEventListener('click', function(){
            deletion(delBtn[i])})
        }
        processing(rowElem)
    }
}

function processing(_rowElem){
    for(let j = 0; j < checkboxes.length; j++){
        checkboxes[j].addEventListener('click', function(){
            _rowElem.displayResults()
        })
    }
    
    searchInput.addEventListener('input', function(){
        _rowElem.displayResults()
    })
    
    select.addEventListener('change', function(){
        _rowElem.displayResults()
    })
}

function deletion(_btn){
    const lineToDelete = _btn.closest("tr")
    lineToDelete.style.display = "none"
}

function calcNS(_value, _ns){
    let letter =""
    let rating = Number(_value.rating)
    switch(true){
        case (rating < 35):
            letter = "E";
            _ns.setAttribute('class', 'e nutri-score red')
            break;
        case (rating < 55):
            letter = "D";
            _ns.setAttribute('class', 'd nutri-score orange')
            break;
        case (rating < 70):
            letter = "C";
            _ns.setAttribute('class', 'c nutri-score dark-yellow')
            break;
        case (rating < 80):
            letter = "B";
            _ns.setAttribute('class', 'b nutri-score green')
            break;
        case (rating >= 80):
            letter = "A";
            _ns.setAttribute('class', 'a nutri-score dark-green')
            break;
        default:
            console.log("Something went wrong !")
            break;
    }
    return letter;
}

function buildTableData() {
    const elements = [...document.querySelectorAll('tbody tr')];
    let results = []
        for(let i = 0; i < elements.length; i++){
            let obj = {}
            let keyValues = elements[i].querySelectorAll('td')
            for(let j = 0; j < keyValues.length -2; j++){
                let keys = keyValues[j].className
                let value = keyValues[j].textContent
                obj[keys] = value
            }
            results[i] = obj
        }
    return results;
}

results = document.querySelector('.btn-save').addEventListener('click', function(){
    results = buildTableData()
    let jsonFile = JSON.stringify(results)
    save.setItem("file", jsonFile)
} )

document.querySelectorAll('th').forEach(th_elem => {
    let asc=true
    let index = Array.from(th_elem.parentNode.children).indexOf(th_elem)
    th_elem.addEventListener('click', () => {              
        const arr = [... th_elem.closest("table").querySelectorAll('tbody tr')]
        arr.sort( (a, b) => {
            let a_value = a.children[index].innerText
            let b_value = b.children[index].innerText
            if(index === 0 || (index > 1 && index < 10)){
                return (asc) ? b_value - a_value : a_value - b_value
            }else{
                return (asc) ? b_value.localeCompare(a_value) : a_value.localeCompare(b_value)
            }
        })
        arr.forEach(elem => {                   
            th_elem.closest("table").querySelector("tbody").appendChild(elem)
        })
        asc = !asc
    })
})

document.querySelector('.btn-purge').addEventListener('click', function(){
    save.clear()
    location.reload()
})