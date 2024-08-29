import Country from './Country.js';
import City from './City.js'
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
                    [{
                        id:0,
                        zipcode:"",
                        name:"",
                        countryId:0
                    }]
                },
            cityList: [],
            cityInput: "",
            zipCode: ""
            }
        },
    async mounted() {
        let countriesFetched = await fetchData("Countries")
        this.countries = []
        countriesFetched.forEach(element => {
            element = new Country(element.id, element.countryName, element.countryCode, element.countryArea, element.continentId)
        this.countries.push(element)
        });
        this.countries.sort((a,b) => a.code.localeCompare(b.code))
        this.assignBaseCities()
    },
    methods: {
        async assignBaseCities(){
            let citiesFetched = await fetchData("Cities")
            citiesFetched.forEach(element =>{
                element = new City(element.id, element.cityZipCode, element.cityName, element.countryId)
                for(let elem of this.countries){
                    if(elem.id === element.countryId){
                        elem.cities.push(element)
                    }
                }
            })
        },
        formatFlagUrl(_countryCode, _size){
            return `https://flagsapi.com/${_countryCode}/flat/${_size}.png`
        },
        modalDialogue(country){
            this.activeCountry = country
            const dialog = document.getElementById("country-dialog");
            dialog.showModal();

        },
        closeDialog(){
            const dialog = document.getElementById("country-dialog");
            dialog.close()
        },
        getLength(_array){
            return _array.length
        },
        addCity(){
            if(this.zipCode != "" && this.cityInput != ""){
                fetch("https://localhost:7236/api/Cities",{
                    method: "POST",
                    body: JSON.stringify({
                        cityZipCode: this.zipCode,
                        cityName: this.cityInput,
                        countryId: this.activeCountry.id
                    }),
                    headers: {
                        "Content-type": "application/json; charset=UTF-8"
                    }
                })
                .then((response) => response.json())
                .then((data) => this.updateList(data))
            }else{
                console.warn('Au moins un des champs est vide !')
            }
        },
        updateList(data){
            let element = new City(data.id, data.cityZipCode, data.cityName, data.countryId)
            this.activeCountry.cities.push(element)
        }
    }
}

Vue.createApp(app).mount('#app');