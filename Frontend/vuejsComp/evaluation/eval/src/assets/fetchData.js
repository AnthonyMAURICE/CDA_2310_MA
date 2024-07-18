async function getData(){
    const response = await fetch('../../src/assets/eval.json')
    const data = response.json()
    return data
}

const result = await getData()

export default result