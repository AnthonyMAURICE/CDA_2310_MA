<script>
import TableHead from './TableHead.vue'
import CardComponent from '../components/CardComponent.vue'
import InfoComponent from '../components/InfoComponent.vue'
export default {
    data(){
        return{
            
        }
    },
    components: {
        TableHead,
        CardComponent,
        InfoComponent
    }
}
</script>

<template>
    <table>
        <TableHead />
        <CardComponent />
        
    </table>
    <InfoComponent />
</template>

<style scoped>
table{
    border-spacing: 0;
    border: 1px solid var(--vt-c-white);
}
</style>