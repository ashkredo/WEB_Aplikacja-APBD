using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace s15444.Models
{
    public class Osoba
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOsoba { get; set; }

        [Required]
        [MaxLength(30)]
        public String FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public String LastName { get; set; }

        [ForeignKey("Type")]
        [DisplayName("Type")]
        public int IdType { get; set; }

        public Type Type { get; set; }
    }
}