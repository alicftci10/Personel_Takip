using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.DBContext;
using DataAccess.DBModels;

namespace Form_App.EFOperations
{
    public class Methods
    {
        public List<PersonelDataModel> GetAllKullaniciList()
        {
            using (PersonelContext db = new PersonelContext())
            {
                var list = db.Kullanicis.Select(i => new PersonelDataModel
                {
                    Id = i.Id,
                    Ad = i.Ad,
                    Soyad = i.Soyad,
                    Tcno = i.Tcno,
                    KullaniciAdi = i.KullaniciAdi,
                    Sifre = i.Sifre,
                    Yetki = i.Yetki
                }).ToList();

                return list;
            }
        }

        private Kullanici GetDataModel(PersonelDataModel item)
        {
            Kullanici kullanici = new Kullanici();

            kullanici.Ad = item.Ad;
            kullanici.Soyad = item.Soyad;
            kullanici.Tcno = item.Tcno;
            kullanici.KullaniciAdi = item.KullaniciAdi;
            kullanici.Sifre = item.Sifre;
            kullanici.Yetki = item.Yetki;

            if (item.Id > 0)
            {
                kullanici.Id = item.Id;
            }

            return kullanici;
        }

        public Kullanici GetKullanici(int pId)
        {
            using (PersonelContext db = new PersonelContext())
            {
                var kullanici = db.Kullanicis.FirstOrDefault(x => x.Id == pId);

                if (kullanici == null)
                return new Kullanici();
                else
                return kullanici;
            }
        }

        public void AddKullanici(PersonelDataModel item)
        {
            using (PersonelContext db = new PersonelContext())
            {
                db.Add(GetDataModel(item));
                db.SaveChanges();
            }
        }

        public void UpdateKullanici(PersonelDataModel item)
        {
            using (PersonelContext db = new PersonelContext())
            {
                db.Update(GetDataModel(item));
                db.SaveChanges();
            }
        }

        public bool DeleteKullanici(int pId)
        {
            using (PersonelContext db = new PersonelContext())
            {
                if (pId == 0)
                {
                    return false;
                }
                else
                {
                    db.Remove(GetKullanici(pId));
                    db.SaveChanges();
                    return true;
                }
            }
        }
    }
}
