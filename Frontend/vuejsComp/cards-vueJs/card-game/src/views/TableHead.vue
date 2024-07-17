<script>
import result from '../assets/fetchData.js'

export default {
    data(){
        return{
            data: result
        }
    },
    methods:{
        getTableHeadElem(_item){
            if(_item == 'description'){
                return 'level'
            }else if(_item == 'level'){
                return 'description'
            }else{
                return _item
            }
        }
    }
}
</script>

<template>
    <thead v-if="data.length > 0">
        <th v-for="(items, index) in data[0]">{{ getTableHeadElem(index) }}</th>
    </thead>
</template>

<style scoped>
th{
    border: 1px solid var(--vt-c-white);
    background-color: var(--vt-c-divider-dark-1);
    padding: 10px 20px;
}
</style>