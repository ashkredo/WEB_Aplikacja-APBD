using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace s15444.Models
{
    public class Type
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdType { get; set; }

        [Required]
        [MaxLength(4)]
        public String Rabat { get; set; }

        public Collection<Osoba> osoby { get; set; }
    }
}