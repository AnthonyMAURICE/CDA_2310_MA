<script>
    const DEFAULT_SIZE = 16
    import SizeButtons from '../components/SizeButton.vue'
    import SizeInput from '../components/SizeInput.vue'
    import realfontSize from '../assets/sizeChecker.js';


    export default {
        data(){
            return {
                fontSize: DEFAULT_SIZE
            }
        },
        computed: {
            checkSize() {
                this.fontSize = realfontSize(this.fontSize)
                return this.fontSize
            }
        },
        components: {
            SizeButtons,
            SizeInput
        },
        methods:{
            eventHandler(data){
                this.fontSize = data
            }
        }
    }
</script>

<template>
    <h1>Changer la taille du texte</h1>
    <div>
        <div>
            <SizeButtons @size-event="eventHandler" :size="fontSize"/>
            <SizeInput @size-input="eventHandler" :size="checkSize" />
        </div>
        
        <p :style="{ 'font-size': `${checkSize}px` }">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Hic id esse ad eius perspiciatis reiciendis. Illum omnis aperiam natus alias possimus consectetur maiores vitae id mollitia ex voluptates, dignissimos architecto!</p>
    </div>
</template>

<style>

</style>