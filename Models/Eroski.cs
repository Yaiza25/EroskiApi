using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EroskiApi.Models
{
    public class Eroski
    {
        [Key]
        public string Seccion { get; set; }
        public long Ticket { get; set; }
    }
}
