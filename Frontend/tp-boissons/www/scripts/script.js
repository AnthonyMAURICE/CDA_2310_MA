const section = document.querySelector('section')
const aside = document.querySelector('aside')

class Article{
    constructor(name, price, stock, tagName){
        this.article = document.createElement(tagName)
        this.name = name
        this.price = price
        this.stock = stock
    }

    get tag(){
        return this.article
    }

    static createArticle(value){
        const article = new Article(value.name, value.price, value.stock, 'article')
        return article
    }

    appendElement(_section){
        _section.appendChild(this.article)
    }
}

async function fetchData(){
    const response = await fetch("../scripts/data.json")
    let data = await response.json()
    console.log(data)
    return data
}

function getData(){
    fetchData().then(values => {
        displayArticles(values.drinks)
    })
}

document.addEventListener('DOMContentLoaded', getData)

function displayArticles(_values){
    for(let value of _values){
        const article = Article.createArticle(value)
        article.appendElement(section)
        const title = document.createElement('h3')
        title.textContent = article.name
        const price = document.createElement('p')
        price.textContent = "Tarif :" + article.price
        const stock = document.createElement('p')
        stock.textContent = "Stock : " + article.stock
        article.tag.append(title, price, stock)
        const selectBtn = document.createElement('button')
        selectBtn.textContent = (value.stock > 0) ? "Sélectionner" : "Rupture de stock"
        article.tag.appendChild(selectBtn)
        section.appendChild(article.tag)
    }
}