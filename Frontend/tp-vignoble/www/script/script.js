const dropCss = document.querySelector('.css');
const menuCss = document.querySelector('.second');

dropCss.addEventListener("click", dropdown);

function dropdown(){
    if(menuCss.classList.contains('shown')){
        menuCss.classList.remove('shown');
    }else{
        menuCss.classList.add('shown');
    }
}