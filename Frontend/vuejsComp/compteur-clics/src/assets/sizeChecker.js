const size = {
    default: 16,
    min: 8,
    max: 48
}

function realfontSize(fontSize) {
    if(fontSize < size.min || fontSize > size.max) {
        fontSize = size.default;
    }
    return fontSize;
}

export default { size, realfontSize}
