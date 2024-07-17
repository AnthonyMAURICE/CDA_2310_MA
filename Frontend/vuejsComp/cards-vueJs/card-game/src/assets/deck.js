import Card from '../assets/Card.js'
import result from '../assets/fetchData.js'
let deck = []

for(let elem of result){
    let card = new Card()
    for(let items in elem){
        items != undefined ? card[items] = elem[items] : card[items] = ""
    }
    
    deck.push(card)
}

export default deck