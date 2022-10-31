using HAO_IKI_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using veritabani;

namespace HAO_IKI_WebApp.Controllers
{
    public class GirisController : Controller
    {
        public IActionResult GirisIndex()
        {
        //    Kullanicilar k = new Kullanicilar();
        //    k.Email = "a@gmail.com";
        //    k.Sifre = "123";
        //    return View("View",k);
                 return View();
        }

        [HttpPost]
        public ActionResult GirisIndex(Kullanicilar kullanici)
        {
            VeriTabani vt = new VeriTabani();
            
            vt.openDatabase();

            if (vt.isOpen())
            {
                vt.closeDatabase();

                string sqlstr;
                sqlstr = "SELECT * FROM kullanicilar WHERE mail= '" + kullanici.Email + "'";
                sqlstr += "AND sifre='" + kullanici.Sifre + "'";
                DataRow user = vt.Read(sqlstr);

                if (user == null)
                    throw new Exception(sqlstr);


                else if (user != null)
                {
                    Kullanicilar acc = new Kullanicilar();
                    acc.KullaniciId = (int)user["kullanici_id"];
                    HttpContext.Session.SetString("currentUserId", acc.KullaniciId.ToString());

                    if ((int)user["kullanici_tipi"] == 1)
                        return RedirectToAction("DoktorAnasayfaIndex", "Doktor");

                }

            }
            vt.closeDatabase();
            return View();

        }

        public ActionResult Menu()
        {
            return PartialView("menu");
        }

    }
}
