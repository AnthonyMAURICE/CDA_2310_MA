<script>
import deck from '../assets/deck.js'
export default {
    data(){
        return{
            cardDeck: deck,
        }
    },
    computed: {
        getMostVictorious(){
            let tempCard = []
            this.cardDeck.forEach(elem => tempCard.push(elem))
            tempCard.sort((a, b) => b.victory - a.victory)
            return tempCard[0]
        },
        getBestRatio(){
            let tempCard = []
            this.cardDeck.forEach(elem => tempCard.push(elem))
            tempCard.sort((a, b) => (b.victory/b.defeat) - (a.victory/a.defeat))
            return tempCard[0]
        }
    }
}
</script>

<template>
    <div>
        <p>Most victorious : {{ getMostVictorious.name }} with {{ getMostVictorious.victory }} winning turns</p>
        <p>Best ratio victories/defeats : {{ getBestRatio.name }} with {{ getBestRatio.played }} turns played and {{ getBestRatio.victory }} victories</p>
    </div>
</template>

<style scoped>

</style>