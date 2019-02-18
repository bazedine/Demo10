using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace Demo10.Models
{
    [Table("Restos")]
    public class Resto
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Telephone { get; set; }
    }
}