using System;
using System.Collections.Generic;

namespace DataAccess.DBModels;

public partial class Kullanici
{
    public int Id { get; set; }

    public string Ad { get; set; } = null!;

    public string Soyad { get; set; } = null!;

    public string Tcno { get; set; } = null!;

    public string KullaniciAdi { get; set; } = null!;

    public string Sifre { get; set; } = null!;

    public string Yetki { get; set; } = null!;
}
