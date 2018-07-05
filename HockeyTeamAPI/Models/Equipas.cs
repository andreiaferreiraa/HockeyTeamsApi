using System;
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

        public string Logotipo { get; set; }

        public string Plantel { get; set; }

        public virtual ICollection<Jogadores> ListaDeJogadores { get; set; }

    }
}