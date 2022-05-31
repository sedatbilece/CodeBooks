using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBooks.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string userName { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string password { get; set; }
        public int yetkiLvl { get; set; }

    }
}
