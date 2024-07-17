<script>
import TableHead from './TableHead.vue'
import CardComponent from '../components/CardComponent.vue'
export default {
    data(){
        return{
            
        }
    },
    components: {
        TableHead,
        CardComponent
    }
}
</script>

<template>
    <table>
        <TableHead />
        <CardComponent />
    </table>
    
</template>

<style scoped>
table{
    border-spacing: 0;
    border: 1px solid var(--vt-c-white);
}
</style>