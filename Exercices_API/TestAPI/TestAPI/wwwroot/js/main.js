import Country from './Country.js';
import fetchData from './fetchData.js'


const app = {
    data() {
        return {
            countries:[],
            activeCountry: {
                id:0,
                countryName:"",
                countryArea:0,
                countryCode:"",
                continentId:0,
                cities:
                    [{id:0,
                        cityZipCode:"",
                        cityName:"",
                        countryId:0
                    }]
                }
            }
        },
    async mounted() {
        let countriesFetched = await fetchData("Countries")
        if(this.countries.length == 0){
            countriesFetched.forEach(element => {
                element = new Country(element.id, element.countryName, element.countryCode, element.countryArea, element.continentId)
            this.countries.push(element)
            });
        }
        let citiesFetched = await fetchData('Cities')
        
    },
    methods: {
        formatFlagUrl(_countryCode, _size){
            return `https://flagsapi.com/${_countryCode}/flat/${_size}.png`
        },
        modalDialogue(country){
            this.activeCountry = country
            console.log(this.activeCountry)
            const dialog = document.getElementById("country-dialog");
            dialog.showModal();

        },
        closeDialog(){
            const dialog = document.getElementById("country-dialog");
            dialog.close()
        },
        getLength(_array){
            return _array.length
        }
    }
}

Vue.createApp(app).mount('#app');