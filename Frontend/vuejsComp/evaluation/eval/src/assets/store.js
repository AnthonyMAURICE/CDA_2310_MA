import { reactive } from 'vue'
import result from '../assets/fetchData.js'

export const eva = reactive({
    value: {
        threshold: null,
        grades: null,
        gradesLength: null,
        average: null
    }
})

export const resultArray = reactive({
    value: result
})

export const data = reactive({
    value: []
})