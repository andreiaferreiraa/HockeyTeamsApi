document.addEventListener('DOMContentLoaded', function main() {
    ecraPlantel();
    //ecraJogadores();
    //ecraDetalhesJogadores();
});

//********************************************** ECRÃ INICIAL *******************************************************
function ecraPlantel() {
    return getPlantel()
        .then(function (arrayPlantel) {
            var divPlantel = document.querySelector('#plantel');
            for (i = 0; i < arrayPlantel.length; i++) {
                divPlantel.appendChild(mostraPlantel(arrayPlantel[i]));
            }
        })
        .catch(function (erro) {
            console.error(erro);
        });
}

function mostraPlantel(plantel) {
    var divImagemPlantel = document.createElement('div');
    
    var imagemPlantel = document.createElement('img');
    imagemPlantel.setAttribute('class', 'imagemPlantel');
    imagemPlantel.src = "plantel/" + plantel.Plantel;
    imagemPlantel.addEventListener('click', function () {
        mudar1aPagina(plantel.ID);
    });
    divImagemPlantel.appendChild(imagemPlantel);
    return divImagemPlantel;
}

function cria(pos) {

    return imagemPlantel;
}

function mudar1aPagina(id) {
    var divInicial = document.querySelector('#plantel');
    var divPagJogadores = document.querySelector('#jogadores');
    ecraJogadores(id);
    divInicial.style.display = 'none';
    divPagJogadores.style.display = 'block';
}

//********************************************** JOGADORES **********************************************************

function ecraJogadores(id) {
    return getJogadores(id)
        .then(function (arrayJogadores) {
            var divJogadores = document.querySelector('#jogadores');
            for (var i = 0; i < arrayJogadores.length; i++) {
                divJogadores.appendChild(mostraJogadores(arrayJogadores[i]));
            }
        })
        .catch(function (erro) {
            console.error(erro);
        });
}

function mostraJogadores(jogadores) {
    //console.log(jogadores);
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
    fotoJogador.addEventListener('click', function () {
        mostraEcra2(jogadores.ID);
    });

    //insersao dos elementos Html  dentro dos respetivos Div's
    divJogador.appendChild(nomeJogador);
    divJogador.appendChild(numJogador);
    divJogador.appendChild(posicaoJogador);
    divJogador.appendChild(fotoJogador);
    return divJogador;
}



function mostraEcra2(id) {
    var divJogadores = document.querySelector('#jogadores');
    var divjogadorDetalhes = document.querySelector('#detalhes');
    ecraDetalhesJogadores(id);
    divJogadores.style.display = 'none';
    divjogadorDetalhes.style.display = 'block';
}


//*************************************************** DETALHES DOS JOGADORES *********************************************
function mostraDetalhesJogador(detalhes) {
    var divDetalhesJogadores = document.querySelector('#detalhes');
    //criacao dos elementos HTML
    var divDetalhes = document.createElement('div');
    //divDetalhes.setAttribute('class', 'detalhesJogador');
    var nomeJogador = document.createElement('h5');
    var fotoJogador = document.createElement('img');
    fotoJogador.setAttribute('class', 'imagemJogador');
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
    getMultimedia(detalhes.ID).then(function (multimedia) {
        var divInic = document.createElement('div');
        for (var i = 0; i < multimedia.length; i++) {
            var fotosJogador = document.createElement('img');
            fotosJogador.src = "Multimédia/" + multimedia[i].NomeFotografia;
            divInic.appendChild(fotosJogador);
        }
        divDetalhesJogadores.appendChild(divInic);
    });
}


function ecraDetalhesJogadores(id) {
    return getDetalhesJogador(id)
        .then(function (detalhes) {
            mostraDetalhesJogador(detalhes);
        })
        .catch(function (erro) {
            console.error(erro);
        });
}

