<script>
    export default {
        emits: ["size-event"],
        props: ['size'],
        data(){
            return {
                fontSize: this.size
            }
        },
        computed: {
            actualizeFontSize(){
                return this.fontSize = this.size
            }
        },
        methods: { 
            increment(){
                this.fontSize++
            },
            decrement(){
                this.fontSize--
            },
            sendData(){
                this.$emit('size-event', this.fontSize)
            }
        }
    }
</script>

<template>
    <p>Taille actuelle : {{ actualizeFontSize }} px</p>
    <button @click="increment(); sendData()">Augmenter la taille du texte</button>
    <button @click="decrement(); sendData()">Diminuer la taille du texte</button>
</template>

<style>

</style>