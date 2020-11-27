const iniciar=async () =>{
    const hamburguer = document.getElementById('hamburguer');

    const response = await fetch('/Burguers');
    const result= await response.json();
    hamburguer.innerHTML= `${result.Nome} ${result.Preco}`;
};

document.addEventListener('DOMContentLoaded', iniciar);