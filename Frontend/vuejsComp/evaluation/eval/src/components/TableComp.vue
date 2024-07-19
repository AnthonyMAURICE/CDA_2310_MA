<script>
    import Thead from './TheadComp.vue'
    import List from './TbodyComp.vue'
    import Stat from './StatComp.vue'
    import Form from './FormComp.vue'

    export default {
        data(){
            return{

            }
        },
        components:{
            Thead,
            List,
            Stat,
            Form
        },
        methods: {

        }
    }
</script>

<template>
    <Form />
    <table>
        <Thead />
        <List />
    </table>
    <Stat />
</template>

<style>
table{
    border: 1px solid var(--color2);
    background-color: var(--color4);
    border-spacing: 0;
}
</style>