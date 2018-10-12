using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstEF.Models
{
    public class Kontakt
    {
        public int KontaktID { get; set; }
        [Required(ErrorMessage = "Wymagane podanie Imienia")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Wymagane podanie Nazwiska")]
        public string Nazwisko { get; set; }
        public string Email { get; set; }
    }
}