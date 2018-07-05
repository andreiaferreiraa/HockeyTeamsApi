using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HockeyTeamAPI.Models
{
    public class Multimedia
    {
        [Key]
        public int ID { get; set; }

        public string NomeFotografia { get; set; }

        [ForeignKey("Jogador")]
        public int JogadorPK { get; set; }
        public virtual Jogadores Jogador { get; set; }
    }
}