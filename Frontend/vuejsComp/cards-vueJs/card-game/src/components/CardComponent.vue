<script>
import deck from '../assets/deck.js'

export default {
    data(){
        return{
            cardDeck: deck
        }
    },
    mounted(){
        const rows = document.querySelectorAll('tbody, tr')
        for(let i = 0; i < rows.length; i++){
            if(i == 0 || i %2 == 0){
                rows[i].classList.add('dark')
            }else{
                rows[i].classList.add('darker')
            }
        }
    }
}
</script>

<template>
    <tbody>
        <tr v-for="items in cardDeck">
            <td  v-for="elem in items">{{ elem }}</td>
        </tr>
    </tbody>
</template>

<style scoped>
td{
    padding: 10px;
}
</style>