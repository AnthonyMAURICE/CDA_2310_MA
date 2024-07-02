import { reactive } from 'vue'

async function fetchData(){
    const response = await fetch('https://arfp.github.io/tp/web/javascript2/11-grocery/legumos.json')
    const data = await response.json()
    return data
};

async function fetchSalesData(){
    const response = await fetch('https://arfp.github.io/tp/web/javascript2/11-grocery/legumos-sales.json')
    const data = await response.json()
    return data
}

export const store = reactive({
    vegetables: await fetchData()
}) 

export const storedSale = reactive({
    sales: await fetchSalesData()
})