function getPlantel() {
    var url = "/api/Equipas";
    //var url = "/api/Equipas";
    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter Logotipo"));
            }
        });
}


function getEquipa(id) {
    var url = "api/equipas/"+id;
    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter Equipa"));
            }
        });
}

function getEquipaHistoria(id) {
    var url = "api/equipas/" + id + "/historia";
    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter Historia"));
            }
        });
}




function getJogadores(id) {
    var url = "/api/Equipas/"+id+"/jogadores";

    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter Jogadores"));
            }
        });
}


function getDetalhesJogador(id) {
    var url = "/api/Jogadores/"+id;

    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter Detalhes do Jogador"));
            }
        });
}

function getMultimedia(id) {
    var url = "/api/Jogadores/" + id + "/multimedia";

    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter Multimedia do Jogador"));
            }
        });
}

function getLogotipo(id) {
    var url = "/api/Equipas/logotipo";

    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro ao obter Logotipo da Equipa"));
            }
        });
}