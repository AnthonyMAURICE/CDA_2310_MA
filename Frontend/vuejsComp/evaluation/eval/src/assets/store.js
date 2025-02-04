import { reactive } from 'vue'
import result from '../assets/fetchData.js'
import Evaluation from './Evaluation.js'

export const eva = reactive({
    value: null
})

export const resultArray = reactive({
    value: result
})

export const data = reactive({
    value: []
})
