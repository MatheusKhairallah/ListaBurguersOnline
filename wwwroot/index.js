const iniciar=async () =>{
    const hamburguer = document.getElementById('hamburguer');

    const response = await fetch('/Burguers');
    const result= await response.json();
    result.forEach(burguer => hamburguer.insertAdjacentHTML('beforeend', `<li>Nome: ${burguer.nome}. Preço: ${burguer.preco}</li>`));
};

document.addEventListener('DOMContentLoaded', iniciar);