async function getData(){
    const response = await fetch('https://arfp.github.io/tp/web/javascript/03-cardgame/cardgame.json')
    const data = response.json()
    return data
}


const result = await getData()
export default result