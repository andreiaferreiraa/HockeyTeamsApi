﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HockeyTeamAPI.Models
{
    public class Equipas
    {
        public Equipas()
        {
            ListaDeJogadores = new HashSet<Jogadores>();
        }

        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public string NomeTodo { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DataFundacao { get; set; }

        public string Pais { get; set; }

        public string Cidade { get; set; }

        public string Presidente { get; set; }

        public string EpocaCampeonatoPortugues { get; set; }

        public string EpocaCampeonatoMetropolitano { get; set; }

        public string EpocaTacaPortugal { get; set; }

        public string EpocaSupertacaAntonioLivramento { get; set; }

        public string NumTitulosCampNac { get; set; }

        public string NumTitulosCampMetro {get; set;}

        public string NumTitulosTacaPortugal { get; set; }

        public string NumSupertacaAntLivr { get; set; }

        public string Historia { get; set; }

        public string Logotipo { get; set; }

        public string Plantel { get; set; }

        public virtual ICollection<Jogadores> ListaDeJogadores { get; set; }

    }
}