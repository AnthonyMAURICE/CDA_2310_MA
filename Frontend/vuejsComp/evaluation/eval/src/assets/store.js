import { reactive } from 'vue'
import Evaluation from '../assets/Evaluation.js';


export const eva = reactive({
    setEval(_threshold, _grades){
        return new Evaluation(_threshold, _grades)
    }
})


export const storedEval = reactive({
    value: null
})