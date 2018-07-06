document.addEventListener('DOMContentLoaded', function main() {
    //ecraPlantel();
    //ecraJogadores();
    ecraDetalhesJogadores();
});

function mostraPlantel(arrayPlantel) {
    var divPlantel = document.querySelector('#plantel');
    for (var i = 0; i < arrayPlantel.length; i++) {
        var divImagemPlantel = document.createElement('div');
        var imagemPlantel = document.createElement('img');
        imagemPlantel.src = "plantel/" + arrayPlantel[i];
        divImagemPlantel.appendChild(imagemPlantel);
        divPlantel.appendChild(divImagemPlantel);
        
    }
}

function ecraPlantel() {
    return getPlantel()
        .then(function (arrayPlantel) {
           
            mostraPlantel(arrayPlantel);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}

function mostraJogadores(arrayJogadores) {
    //console.log(arrayJogadores);
    var divJogadores = document.querySelector('#jogadores');
    for (var i = 0; i < arrayJogadores.length; i++){
        var jogadores = arrayJogadores[i];
        //criação de elementos HTML
        var divJogador = document.createElement('div');
        var nomeJogador = document.createElement('p');
        var numJogador = document.createElement('p');
        var posicaoJogador = document.createElement('p');
        var fotoJogador = document.createElement('img');
        //preencher o conteudo desses elementos
        nomeJogador.textContent = jogadores.Nome;
        numJogador.textContent = jogadores.Numero;
        posicaoJogador.textContent = jogadores.Posicao;
        fotoJogador.src = "JogadoresFotosApi/" + jogadores.Fotografia;
        //insersao dos elementos Html  dentro dos respetivos Div's
        divJogador.appendChild(nomeJogador);
        divJogador.appendChild(numJogador);
        divJogador.appendChild(posicaoJogador);
        divJogador.appendChild(fotoJogador);
        divJogadores.appendChild(divJogador);
    }
}


function ecraJogadores() {
    return getJogadores(5)
        .then(function (arrayJogadores) {

            mostraJogadores(arrayJogadores);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}

function mostraDetalhesJogador(detalhes) {
    var divDetalhesJogadores = document.querySelector('#detalhes');
    //criacao dos elementos HTML
    var divDetalhes = document.createElement('div');
    var nomeJogador = document.createElement('h5');
    var fotoJogador = document.createElement('img');
    var nomeCompJogador = document.createElement('p');
    var numJogador = document.createElement('p');
    var posicao = document.createElement('p');
    var dataNasc = document.createElement('p');
    var nacionalidade = document.createElement('p');
    var altura = document.createElement('p');
    var peso = document.createElement('p');
    //preencher o conteudo desses elementos
    nomeJogador.textContent = "Nome: " + detalhes.Nome;
    fotoJogador.src = "JogadoresFotosApi/" + detalhes.Fotografia;
    nomeCompJogador.textContent = "Nome Completo do Jogador: " + detalhes.NomeCompleto;
    numJogador.textContent = "Número do Jogador: " + detalhes.Número;
    posicao.textContent = "Posição: " + detalhes.Posicao;
    dataNasc.textContent = "Data de Nascimento: " + detalhes.dataNasc;
    nacionalidade.textContent = "Nacionalidade: " + detalhes.Nacionalidade;
    altura.textContent = "Peso: " + detalhes.Altura;
    peso.textContent = "Altura: " + detalhes.Peso;
    //insersao dos elementos Html  dentro dos respetivos Div's
    divDetalhes.appendChild(nomeJogador);
    divDetalhes.appendChild(fotoJogador);
    divDetalhes.appendChild(nomeCompJogador);
    divDetalhes.appendChild(numJogador);
    divDetalhes.appendChild(posicao);
    divDetalhes.appendChild(dataNasc);
    divDetalhes.appendChild(nacionalidade);
    divDetalhes.appendChild(altura);
    divDetalhes.appendChild(peso);
    divDetalhesJogadores.appendChild(divDetalhes);
}


function ecraDetalhesJogadores() {
    return getDetalhesJogador(6)
        .then(function (detalhes) {
            mostraDetalhesJogador(detalhes);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}




