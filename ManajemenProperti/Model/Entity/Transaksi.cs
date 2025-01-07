using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenProperti.Model.Entity
{
    public class Transaksi
    {
        public int TransaksiID { get; set; }
        public int Username { get; set; }
        public int PropertiID { get; set; }
        public DateTime Tgl_Sewa { get; set; }
        public int Lama_Sewa { get; set; }
        public string Keterangan { get; set; }
    }
}
