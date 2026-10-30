using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CegesAutoNyilvatartas.Models
{
    public class Auto
    {
        public int Id { get; set; }
        public string Marka { get; set; } = string.Empty;
        public string Modell { get; set; } = string.Empty;

        public string Rendszám { get; set; } = string.Empty;
        [Range(1950, 2026)]
        public int Evjarat { get; set; }

        public int? PeopleId { get; set; }

        public People? People { get; set; }

        public override string? ToString()
        {
            return $"{Marka} - {Modell} - {Rendszám} - {Evjarat}";
        }
    }


}
