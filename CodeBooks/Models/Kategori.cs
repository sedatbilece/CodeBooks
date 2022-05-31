using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBooks.Models
{
    public class Kategori
    {

        public int KategoriID { get; set; }
        public string KategoriAd { get; set; }
        public int Aktiflik { get; set; }
        public IList<Makale> makales { get; set; }
    }
}
