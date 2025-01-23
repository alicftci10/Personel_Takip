using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.DBContext;
using DataAccess.DBModels;
using System.Security.Cryptography;

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

        public Kullanici GetKullaniciTCNO(string pTCNO)
        {
            using (PersonelContext db = new PersonelContext())
            {
                var kullanici = db.Kullanicis.FirstOrDefault(x => x.Tcno == pTCNO);

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
                try
                {
                    db.Add(GetDataModel(item));
                    db.SaveChanges();
                    MessageBox.Show("Kullanıcı başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu : " + ex.Message, "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void UpdateKullanici(PersonelDataModel item)
        {
            using (PersonelContext db = new PersonelContext())
            {
                try
                {
                    db.Update(GetDataModel(item));
                    db.SaveChanges();
                    MessageBox.Show("Kullanıcı başarıyla güncellendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu : " + ex.Message, "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void DeleteKullanici(int pId)
        {
            using (PersonelContext db = new PersonelContext())
            {
                try
                {
                    db.Remove(GetKullanici(pId));
                    db.SaveChanges();
                    MessageBox.Show("Kullanıcı başarıyla silindi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu : " + ex.Message, "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
