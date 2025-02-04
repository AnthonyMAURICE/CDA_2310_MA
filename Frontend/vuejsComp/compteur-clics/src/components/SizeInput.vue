<script>
    import realfontSize from '../assets/sizeChecker.js';
    export default {
        emits: ["size-input"],
        props: ['size'],
        data(){
            return {
                fontSize: this.size,
            }
        },
        computed: {
            checkSize() {
                realfontSize.realfontSize(this.fontSize)
            }
        },
        methods:{
            sendData(){
                this.$emit('size-input', this.fontSize)
            }
        },
        watch: {
            size(){
                this.fontSize = this.$props.size
            }
        }
    }
</script>

<template>
    <label for="sizeInput">Saisie manuelle</label>
    <input type="number" id="sizeInput" @input="checkSize; sendData()" v-model="fontSize">
</template>

<style>

</style>