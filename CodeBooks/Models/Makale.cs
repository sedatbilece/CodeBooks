using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBooks.Models
{
    public class Makale
    {
        public int MakaleID { get; set; }
        public int Baslik { get; set; }
        public int Text { get; set; }
        public int Tarih { get; set; }
        public int yazar { get; set; }

        public int KategoriID { get; set; }
        public Kategori kategori { get; set; }
    }
}
