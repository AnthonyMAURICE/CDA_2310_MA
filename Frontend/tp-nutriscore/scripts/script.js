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
            console.log(this.setVisibility())
            console.log(this.thirdFilter())
            console.log(this.visibilityByName())
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
        setCereals(values.data)
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
        ns.textContent = calcNS(value, ns)
        rowElem.nScore = calcNS(value, ns)
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
        
        for(let j = 0; j < checkboxes.length; j++){
            checkboxes[j].addEventListener('click', function(){
                rowElem.displayResults()
            })
        }
        
        searchInput.addEventListener('input', function(){
            rowElem.displayResults()
        })
        
        select.addEventListener('change', function(){
            rowElem.displayResults()
        })
    }
}

function deletion(_btn){
    const lineToDelete = (_btn.parentNode).parentNode
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

const headRow = document.querySelectorAll('th')

for(let i = 0; i < headRow.length; i++){
    
}

function sortingValues(_values, _key){
    _values.sort((a, b) => a[_key] < b[_key] ? 1 : -1)
    return _values[0]
}
