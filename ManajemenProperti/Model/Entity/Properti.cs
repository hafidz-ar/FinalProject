using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenProperti.Model.Entity
{
    public class Properti
    {
        public string Nama { get; set; }
        public Decimal Harga_Sewa { get; set; }
        public int Stok { get; set; }
        public int PropertiID { get; set; }
    }
}
