using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class PersonelDataModel
    {
        public int Id { get; set; }

        public string? Ad { get; set; }

        public string? Soyad { get; set; }

        public string? Tcno { get; set; }

        public string? KullaniciAdi { get; set; }

        public string? Sifre { get; set; }

        public string? Yetki { get; set; }
    }
}
