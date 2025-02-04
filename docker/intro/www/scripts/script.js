let sectionWrapper = document.querySelector('section');

async function getJson(){
    const response = await fetch('../scripts/data.json');
    const datas = await response.json();
    return datas;
}

let candidates = []

getJson().then(x => { 
    candidates = x.candidats
    randomize(candidates)
});

function randomize(candidates){
    const shuffledArray = candidates.sort((a, b) => 0.5 - Math.random())
    displayCandidats(shuffledArray)
}

function displayCandidats(shuffledArray){
    for (elem of shuffledArray){
        const candidateWrapper = document.createElement('div');
        sectionWrapper.appendChild(candidateWrapper);
        candidateWrapper.classList.add("candidat");
        const paragraph = document.createElement('p');
        candidateWrapper.appendChild(paragraph);
        const datas = document.createTextNode(elem.name);
        paragraph.appendChild(datas);
    }
}
