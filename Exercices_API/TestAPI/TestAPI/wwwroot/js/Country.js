export default class Country{
    constructor(_name, _code, _area, _continentId){
        this.name = _name
        this.code = _code
        this.area = _area
        this.continentId = _continentId
        this.cities = []
    }
}