using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenProperti.Model.Entity
{
    public class RiwayatTransaksi
    {
        public int TransaksiID { get; set; }
        public string Username { get; set; }
        public int PropertiID { get; set; }
        public string Keterangan { get; set; }
    }
}
