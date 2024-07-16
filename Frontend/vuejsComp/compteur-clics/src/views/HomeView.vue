<script>
    const DEFAULT_SIZE = 16
    const MIN_SIZE = 8
    const MAX_SIZE = 48
    import SizeButtons from '../components/SizeButton.vue'
    import SizeInput from '../components/SizeInput.vue'

    export default {
        data(){
            return {
                fontSize: DEFAULT_SIZE
            }
        },
        computed: {
            realfontSize() {
                if(this.fontSize < MIN_SIZE || this.fontSize > MAX_SIZE) {
                    this.fontSize = DEFAULT_SIZE;
                }
                return this.fontSize;
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
            <SizeInput @size-input="eventHandler" :size="realfontSize" />
        </div>
        
        <p :style="{ 'font-size': `${realfontSize}px` }">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Hic id esse ad eius perspiciatis reiciendis. Illum omnis aperiam natus alias possimus consectetur maiores vitae id mollitia ex voluptates, dignissimos architecto!</p>
    </div>
</template>

<style>

</style>