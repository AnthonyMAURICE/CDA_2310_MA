const dialog = document.querySelector('dialog');
const dialogBtn = document.querySelector('.btn-access')
const closeBtn = document.querySelector('.close-dialog')

dialogBtn.addEventListener('click', () => {
    dialog.showModal();
})

closeBtn.addEventListener('click', () =>{
    dialog.close()
})