<script>
    import realfontSize from '../assets/sizeChecker.js';
    export default {
    
        emits: ["size-input"],
        props: ['size'],
        data(){
            return {
                fontSize: this.size,
                test: 0
            }
        },
        computed: {
            checkSize() {
                realfontSize(this.fontSize)
                this.sendData()
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
    <input type="number" id="sizeInput" @input="checkSize" v-model="fontSize">
</template>

<style>

</style>