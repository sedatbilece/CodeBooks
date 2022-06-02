using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBooks.Models
{
    public class Makale
    {
        [Key]
        public int MakaleID { get; set; }
        public string Baslik { get; set; }
        public string Text { get; set; }
        public string Tarih { get; set; }
        public string yazar { get; set; }

        public int KategoriID { get; set; }
        public Kategori kategori { get; set; }
    }
}
