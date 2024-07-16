<script>
    const DEFAULT_SIZE = 16
    const MIN_SIZE = 8
    const MAX_SIZE = 48
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
            realfontSize() {
                if(this.fontSize < MIN_SIZE || this.fontSize > MAX_SIZE) {
                    this.fontSize = DEFAULT_SIZE;
                }
                this.sendData()
            },
            
        },
        methods:{
            sendData(){
                this.$emit('size-input', this.fontSize)
            }
        }
    }
</script>

<template>
    <label for="sizeInput">Saisie manuelle</label>
    <input type="number" id="sizeInput" @change="realfontSize" v-model="fontSize">
</template>

<style>

</style>