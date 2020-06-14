using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebassemblyBlazor.Client.Code
{
    public class Person
    {
        [Required][Display(Name = "Bitte den Vornamen")]
        public string Vorname { get; set; }

        [Required]
        public string Nachname { get; set; }
        public Gender Geschlecht { get; set; }

        [Required][Range(1,100)]
        public int Alter { get; set; }

        public bool IstVerheiratet { get; set; }

        public DateTime Heiratsdatum { get; set; }
    }
}
