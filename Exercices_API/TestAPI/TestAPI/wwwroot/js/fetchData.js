export default async function fetchData(_data) {
    let response = await fetch(`https://localhost:7236/api/${_data}`)
    return response.json()
}
