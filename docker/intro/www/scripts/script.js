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
    display(shuffledArray)
}

function display(shuffledArray){
    for (elem of shuffledArray){
        sectionWrapper.innerHTML += `<div class ="candidat">
                                        <p>${elem.name}</p>
                                    </div>`
    }
}
