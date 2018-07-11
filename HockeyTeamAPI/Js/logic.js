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
    var divNomeEquipa = document.createElement('div');
   
    imagemPlantel.src = "plantel/" + plantel.Plantel;
    imagemPlantel.addEventListener('click', function () {
        mudar1aPagina(plantel.ID);
    });
    var nomeEquipa = document.createElement('p');
    nomeEquipa.setAttribute('class', 'nomeEquipa');
    nomeEquipa.textContent = plantel.Nome;
    divNomeEquipa.appendChild(nomeEquipa);
    divImagemPlantel.appendChild(divNomeEquipa);
    divImagemPlantel.appendChild(imagemPlantel);
    return divImagemPlantel;
}

function cria(pos) {

    return imagemPlantel;
}

//função que permite mudar do div inicial para o div dos jogadores
function mudar1aPagina(id) {
    var divInicial = document.querySelector('#plantel');
    var divPagJogadores = document.querySelector('#jogadores');
    var icon = document.querySelector('#homeIcon');
    var iconBack = document.querySelector('#iconBack');
    divPagJogadores.innerHTML = "";
    ecraJogadores(id);
    icon.style.display = 'block';
    iconBack.style.display = 'none';
    divInicial.style.display = 'none';
    divPagJogadores.style.display = 'block';
}

//função reference ao icon Home
function funcaoHomeIncon() {
    var divJogadores = document.querySelector('#jogadores');
    var divDetalhes = document.querySelector('#detalhes');
    var divPrincipal = document.querySelector('#plantel');
    var iconHome = document.querySelector('#homeIcon');
    var backIcon = document.querySelector('#iconBack');
    divPrincipal.innerHTML = "";
    ecraPlantel();
    divPrincipal.style.display = 'block';
    divJogadores.style.display = 'none';
    divDetalhes.style.display = 'none';
    iconHome.style.display = 'none';
    backIcon.style.display = 'none';
}


//********************************************** JOGADORES **********************************************************

function ecraJogadores(id) {
    var divJogadores = document.querySelector('#jogadores');
    //mostra o logotipo e nome da Equipa
    getEquipa(id)
        .then(function (equipas) {
            divJogadores.appendChild(mostraEquipas(equipas));
        })
        .catch(function (erro) {
            console.error(erro);
        });
    //mostra os jogadores dessa equipa
    return getJogadores(id)
        .then(function (arrayJogadores) {

            for (var i = 0; i < arrayJogadores.length; i++) {
                divJogadores.appendChild(mostraJogadores(arrayJogadores[i]));
            }
        })
        .catch(function (erro) {
            console.error(erro);
        });
}


//funcao que vai buscar o logotipo e o nome da equipa
function mostraEquipas(equipas) {
   //criação de elementos e atribuição de classes
    var divLogNome = document.createElement('div');
    var imgLogotipo = document.createElement('img');
    imgLogotipo.setAttribute('class', 'logotipo');
    var divNomeEquipa = document.createElement('h1');
    divNomeEquipa.setAttribute('class', 'nomeEquipa');
    var barra1 = document.createElement('hr');
    barra1.setAttribute('class', 'barra1');
    //preenchimento dos elementos HTML
    imgLogotipo.src = "EquipasFotos/" + equipas[0].Logotipo;
    divNomeEquipa.textContent = equipas[0].Nome;
    divLogNome.appendChild(imgLogotipo);
    divLogNome.appendChild(divNomeEquipa);
    divLogNome.appendChild(barra1);
    return divLogNome;
}


function mostraJogadores(jogadores) {
    //criação de elementos HTML
    var divJogador = document.createElement('div');
    divJogador.setAttribute('class', 'divJogadores');
    var nomeJogador = document.createElement('p');
    nomeJogador.setAttribute('class', 'NomeJogador');
    var numJogador = document.createElement('p');
    var posicaoJogador = document.createElement('p');
    var fotoJogador = document.createElement('img');
    fotoJogador.setAttribute('class', 'fotoJogador1');
    //preencher o conteudo desses elementos
    //numJogador.textContent = jogadores.Numero;
    nomeJogador.textContent = jogadores.Nome;
    posicaoJogador.textContent = jogadores.Posicao;
    fotoJogador.src = "JogadoresFotosApi/" + jogadores.Fotografia;
    fotoJogador.addEventListener('click', function () {
        mostraEcra2(jogadores.ID);
    });
    //insersao dos elementos Html  dentro dos respetivos Div's
    divJogador.appendChild(fotoJogador);
    //divJogador.appendChild(nomeJogador);
    return divJogador;
}


function mostraEcra2(id) {
    var divJogadores = document.querySelector('#jogadores');
    var divjogadorDetalhes = document.querySelector('#detalhes');
    var divDet = document.querySelector('#det');
    var divCarrossel = document.querySelector('.carousel-inner');
    var divBarra = document.querySelector('.carousel-indicators');
    var iconBack = document.querySelector('#iconBack');
    var primeiraImagem = document.createElement('li');
    primeiraImagem.setAttribute('data-target', '#carouselExampleIndicators');
    primeiraImagem.setAttribute('data-slide-to', 0);
    primeiraImagem.setAttribute('class', 'active');
    divDet.innerHTML = "";
    divCarrossel.innerHTML = "";
    divBarra.innerHTML = "";
    divBarra.appendChild(primeiraImagem);
    ecraDetalhesJogadores(id);
    iconBack.style.display = 'block';
    divJogadores.style.display = 'none';
    divjogadorDetalhes.style.display = 'block';
}


//*************************************************** DETALHES DOS JOGADORES *********************************************
function mostraDetalhesJogador(detalhes) {
    var divDetalhesJogadores = document.querySelector('#det');
    //criacao dos elementos HTML
    var divDetalhes = document.createElement('div');
    var divCadaDetalhe = document.createElement('div');
    var paragrafoNome = document.createElement('h4');
    var nomeJogador = document.createElement('h1');
    nomeJogador.setAttribute('class', 'nomeJogador');
    var barra = document.createElement('hr');
    barra.setAttribute('class', 'barra');
    //foto do jogador
    var fotoJogador = document.createElement('img');
    fotoJogador.setAttribute('class', 'fotoJogador2');
    //nome completo do jogador
    var paragrafoNome = document.createElement('h4');
    var nomeCompJogador = document.createElement('p');
    //numero do jogador
    var paragrafoNumero = document.createElement('h4');
    var numJogador = document.createElement('p');
    //posicao
    var paragrafoPosicao = document.createElement('h4');
    var posicao = document.createElement('p');
    //data de nascimento
    var paragrafoDataNasc = document.createElement('h4');
    var dataNasc = document.createElement('p');
    //nacionalidade
    var paragrafoNacionalidade = document.createElement('h4');
    var nacionalidade = document.createElement('p');
    //altura
    var paragrafoAltura = document.createElement('h4');
    var altura = document.createElement('p');
    //peso
    var paragrafoPeso = document.createElement('h4');
    var peso = document.createElement('p');
    //*************************************************************//
    //preencher o conteudo desses elementos
    nomeJogador.textContent = detalhes.Nome;
    fotoJogador.src = "JogadoresFotosApi/" + detalhes.Fotografia;
    //Nome Completo do Jogador
    paragrafoNome.textContent = "NOME COMPLETO: ";
    paragrafoNome.setAttribute('class', 'paragrafoNome');
    nomeCompJogador.textContent = detalhes.NomeCompleto;
    nomeCompJogador.setAttribute('class', 'classNomeComp');
    //numero do jogador
    paragrafoNumero.textContent = "NÚMERO: ";
    paragrafoNumero.setAttribute('class', 'paragrafoNumero');
    numJogador.textContent = detalhes.Número;
    numJogador.setAttribute('class', 'numeroJogador');
    //posicao
    paragrafoPosicao.textContent = "POSIÇÃO: ";
    paragrafoPosicao.setAttribute('class', 'paragrafoPosicao');
    posicao.textContent = detalhes.Posicao;
    posicao.setAttribute('class', 'posicao');
    //data de nascimento
    paragrafoDataNasc.textContent = "DATA DE NASCIMENTO: ";
    paragrafoDataNasc.setAttribute('class', 'paragrafoDataNasc');
    dataNasc.textContent = detalhes.dataNasc;
    dataNasc.setAttribute('class', 'dataNascimento');
    //nacionalidade
    paragrafoNacionalidade.textContent = "NACIONALIDADE: ";
    paragrafoNacionalidade.setAttribute('class', 'paragrafoNacionalidade');
    nacionalidade.textContent = detalhes.Nacionalidade;
    nacionalidade.setAttribute('class', 'nacionalidade');
    //altura
    paragrafoAltura.textContent = "ALTURA";
    paragrafoAltura.setAttribute('class', 'paragrafoAltura');
    altura.textContent = detalhes.Altura;
    altura.setAttribute('class', 'altura');
    //peso
    paragrafoPeso.textContent = "PESO: ";
    paragrafoPeso.setAttribute('class', 'paragrafoPeso');
    peso.textContent = detalhes.Peso;
    peso.setAttribute('class', 'peso');
    //***********************************************************/
    //insersao dos elementos Html  dentro dos respetivos Div's
    divDetalhes.appendChild(nomeJogador);
    divDetalhes.appendChild(barra);
    divDetalhes.appendChild(fotoJogador);
    divCadaDetalhe.appendChild(paragrafoNome);
    divCadaDetalhe.appendChild(nomeCompJogador);
    divCadaDetalhe.appendChild(paragrafoNumero);
    divCadaDetalhe.appendChild(numJogador);
    divCadaDetalhe.appendChild(paragrafoPosicao);
    divCadaDetalhe.appendChild(posicao);
    divCadaDetalhe.appendChild(paragrafoDataNasc);
    divCadaDetalhe.appendChild(dataNasc);
    divCadaDetalhe.appendChild(paragrafoNacionalidade);
    divCadaDetalhe.appendChild(nacionalidade);
    divCadaDetalhe.appendChild(paragrafoAltura);
    divCadaDetalhe.appendChild(altura);
    divCadaDetalhe.appendChild(paragrafoPeso);
    divCadaDetalhe.appendChild(peso);
    divDetalhes.appendChild(divCadaDetalhe);

    divDetalhesJogadores.appendChild(divDetalhes);
    getMultimedia(detalhes.ID).then(function (multimedia) {
        //var divInic = document.createElement('div');
        //div que é preciso para mostrar cada imagem
        var divImagem = document.createElement('div');
        divImagem.setAttribute('class', 'carousel-item active');
        divImagem.setAttribute('id', 'divImagem');
        //elemento que vai buscar cada imagem do jogador
        var cadaImagem = document.createElement('img');
        cadaImagem.setAttribute('class', 'd-block w-100');
        cadaImagem.setAttribute('id', 'imagemJogador');
        cadaImagem.setAttribute('src', "Multimédia/" + multimedia[0].NomeFotografia);
        divImagem.appendChild(cadaImagem);
        let im = document.querySelector('.carousel-inner');
        im.appendChild(divImagem);
        for (var i = 1; i <= multimedia.length - 1; i++) {
            //criação da lista de imagens para o "carrosel"
            var listaImagens = document.createElement('li');
            listaImagens.setAttribute('data-target', '#carouselExampleIndicators');
            listaImagens.setAttribute('data-slide-to', i);
            //atribuição ao carrossel a lista de imagens
            var carousel = document.querySelector('.carousel-indicators');
            carousel.appendChild(listaImagens);

            //div que é preciso para mostrar cada imagem
            var divImagem = document.createElement('div');
            divImagem.setAttribute('class', 'carousel-item');
            //elemento que vai buscar cada imagem do jogador
            var cadaImagem = document.createElement('img');
            cadaImagem.setAttribute('class', 'd-block w-100');
            cadaImagem.setAttribute('id', 'imagemJogador');
            cadaImagem.setAttribute('src', "Multimédia/" + multimedia[i].NomeFotografia);
            divImagem.appendChild(cadaImagem);
            let im = document.querySelector('.carousel-inner');
            im.appendChild(divImagem);
        }
    });
}


//funcao referente ao Icon Back
function funcaoBackIncon() {
    var divDetalhes = document.querySelector('#detalhes');
    var divJogadores = document.querySelector('#jogadores');
    var icon = document.querySelector('#iconBack');
    ecraJogadores();
    icon.style.display = 'none';
    divDetalhes.style.display = 'none';
    divJogadores.style.display = 'block';

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

