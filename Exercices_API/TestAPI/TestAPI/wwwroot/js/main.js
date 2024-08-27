import fetchData from './fetchData.js'


const app = {
    data() {
        return {
            countries:[]
        }
    },
    async mounted() {
        let countriesFetched = await fetchData("Countries")
        if(this.countries.length == 0){
            countriesFetched.forEach(element => {
            this.countries.push(element)
            });
        }
        
    },
    methods: {
        formatFlagUrl(_countryCode, _size){
            return `https://flagsapi.com/${_countryCode}/flat/${_size}.png`
        },
        modalDialogue(){
            const dialog = document.getElementById("country-dialog");
            dialog.showModal();
        },
        closeDialog(){
            const dialog = document.getElementById("country-dialog");
            dialog.close()
        }
    }
}

Vue.createApp(app).mount('#app');