const DEFAULT_SIZE = 16
const MIN_SIZE = 8
const MAX_SIZE = 48

function realfontSize(fontSize) {
    if(fontSize < MIN_SIZE || fontSize > MAX_SIZE) {
        fontSize = DEFAULT_SIZE;
    }
    return fontSize;
}

export default realfontSize