using HAO_IKI_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using veritabani;

namespace HAO_IKI_WebApp.Controllers
{
    public class DoktorController : Controller
    {

        public ActionResult Hastalarim()
        {
            VeriTabani vt = new VeriTabani();
            vt.openDatabase();

            DataTable datatable = new DataTable();
            vt.fillDataTable(datatable, "Select * From hastalar_v");

            ViewBag.datatable = datatable;
            vt.closeDatabase();
            TempData.Keep();
            return View();
        }
        public IActionResult DoktorAnasayfaIndex()
        {
            TempData.Keep();
            return View();
        }

        [HttpGet]
        public ActionResult HastaKaydi()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HastaKaydi(Hasta hasta)
        {
            string x;
            if (hasta.AdSoyad != null) { x = "'" + hasta.AdSoyad + "',"; } else { x = "null,"; }
            
            string y;
            if (hasta.YasadigiSehir != null) { y = "" + hasta.YasadigiSehir + ","; } else { y = "null,"; }
            
            string a;
            if (hasta.DogumTarihi != null) { a = "'" + hasta.DogumTarihi + "',"; } else { a = "null,"; }
            
            string o;
            if (hasta.Kilo != null) { o = "'" + hasta.Kilo + "',"; } else { o = "null,"; }
            
            string b;
            if (hasta.AnneBabaAkrabalik != null) { b = "" + hasta.AnneBabaAkrabalik + ","; } else { b = "null,"; }
            
            string c;
            if (hasta.AnneBabaAkrabalikDerece != null) { c = "'" + hasta.AnneBabaAkrabalikDerece + "',"; } else { c = "null,"; }
            
            string d;
            if (hasta.AnneanneDedeAkrabalik != null) { d = "" + hasta.AnneanneDedeAkrabalik + ","; } else { d = "null,"; }
           
            string e;
            if (hasta.AileOykusu != null) { e = "" + hasta.AileOykusu + ","; } else { e = "null,"; }
           
            string f;
            if (hasta.HastaSonDurumOlumTarihi != null) { f = "'" + hasta.HastaSonDurumOlumTarihi + "',"; } else { f = "null,"; }
           
            string g;
            if (hasta.TanininKoyulduguYil != null) { g = "" + hasta.TanininKoyulduguYil + ","; } else { g = "null,"; }
           
            string h;
            if (hasta.SemptomBaslamaYili != null) { h = "" + hasta.SemptomBaslamaYili + ","; } else { h = "null,"; }
           
            string i;
            if (hasta.DogumYeri != null) { i = "" + hasta.DogumYeri + ","; } else { i = "null,"; }
            
            string j;
            if (hasta.AiledeLarengealAtagaBagliOlum != null) { j = "" + hasta.AiledeLarengealAtagaBagliOlum + ","; } else { j = "null,"; }
            
            string k;
            if (hasta.HastaSonDurum != null) { k = "'" + hasta.HastaSonDurum + "',"; } else { k = "null,"; }

            string l;
            if (hasta.CalismaDurumu != null) { l = "'" + hasta.CalismaDurumu + "',"; } else { l = "null,"; }
            
            string m;
            if (hasta.Cinsiyet != null) { m = "'" + hasta.Cinsiyet + "',"; } else { m = "null,"; }
            
            string n;
            if (hasta.AnjiyoodemTipi != null) { n = "'" + hasta.AnjiyoodemTipi + "',"; } else { n = "null,"; }

            string z;
            if (hasta.Boy != null) { z = "" + hasta.Boy; } else { z = "null"; }


            TempData.Keep();
            VeriTabani veriTabani = new VeriTabani();
            veriTabani.openDatabase();
            
            string sqlstr = "";
            sqlstr += "INSERT INTO public.hasta(hasta_id, doktor, aile_id, ad_soyad, yasadigi_sehir," +
                " dogum_tarihi, kilo, annebaba_akrabalik, annebaba_akrabalik_derece, anneannedede_akrabalik, aile_oykusu, hasta_son_durum_olum_tarihi," +
                " taninin_koyuldugu_yil, semptom_baslama_yili, dogum_yeri, ailede_larengeal_ataga_bagli_olum, hasta_son_durum, calisma_durumu, cinsiyet, anjiyoodem_tipi, boy)" +
                "VALUES(";
            sqlstr += 12 + ",";
            sqlstr += 1 + ",";
            sqlstr += 1 + ",";
            sqlstr += x;
            sqlstr += y;
            sqlstr += a;
            sqlstr += o;
            sqlstr += b;
            sqlstr += c;
            sqlstr += d;
            sqlstr += e;
            sqlstr += f;
            sqlstr += g;
            sqlstr += h;
            sqlstr += i;
            sqlstr += j;
            sqlstr += k;
            sqlstr += l;
            sqlstr += m;
            sqlstr += n;
            sqlstr += z + ")";


            veriTabani.Execute(sqlstr);

            try
            {

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }

            return View();
        }

        public ActionResult HastaKaydiDemografikVerilerIki()
        {
            return View();
        }
        [HttpGet]
        public ActionResult HastaKaydiKomorbidite()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HastaKaydiKomorbidite(Hasta hasta)
        {

            string x;
            if (hasta.EslikEdenHastalik != null) { x = "" + hasta.EslikEdenHastalik + ""; } else { x = "null"; }

            string sqlstr = "";
            sqlstr += "Update public.hasta set eslik_eden_hastalik = " + x + " where hasta_id=12, doktor=1, aile_id=1, ad_soyad='aysee', yasadigi_sehir=null, dogum_tarihi=null, annebaba_akrabalik=null, annebaba_akrabalik_derece=null, anneannedede_akrabalik=null, aile_oykusu=null, hasta_son_durum_olum_tarihi=null, taninin_koyuldugu_yil=null, semptom_baslama_yili=null, dogum_yeri=null, ailede_larengeal_ataga_bagli_olum=null, hasta_son_durum=null, calisma_durumu=null, cinsiyet=null, anjiyoodem_tipi=null, boy=null, kilo=null, tarih=null, hastalik_diger=null, egzersiz_diger=null, meslek_diger=null, ozel_sektor_aciklama=null, eslik_eden_hastalik=null";



            TempData.Keep();
            VeriTabani veriTabani = new VeriTabani();
            veriTabani.openDatabase();

            


            veriTabani.Execute(sqlstr);

            try
            {

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }

            return View();
        }
        [HttpGet]
        public ActionResult HastaKaydiKompleman()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HastaKaydiKompleman(Kompleman kompleman)
        {
            string x;
            if (kompleman.C1InhibitorDuzey != null) { x = "" + kompleman.C1InhibitorDuzey + ","; } else { x = "null,"; }

            string y;
            if (kompleman.C1InhibitorFonksiyonuDuzey != null) { y = "" + kompleman.C1InhibitorFonksiyonuDuzey + ","; } else { y = "null,"; }

            string a;
            if (kompleman.C4Duzey != null) { a = "" + kompleman.C4Duzey + ","; } else { a = "null,"; }

            string o;
            if (kompleman.C3Duzey != null) { o = "" + kompleman.C3Duzey + ","; } else { o = "null,"; }

            string b;
            if (kompleman.C1qDuzey != null) { b = "" + kompleman.C1qDuzey + ","; } else { b = "null,"; }

            string c;
            if (kompleman.Antic1InhibitorOtoantikoru != null) { c = "" + kompleman.Antic1InhibitorOtoantikoru + ","; } else { c = "null,"; }

            string d;
            if (kompleman.Tarih != null) { d = "'" + kompleman.Tarih + "',"; } else { d = "null,"; }

            string e;
            if (kompleman.C1InhibitorBirim != null) { e = "" + kompleman.C1InhibitorBirim + ","; } else { e = "null,"; }

            string f;
            if (kompleman.C1InhibitorFonksiyonuBirim != null) { f = "" + kompleman.C1InhibitorFonksiyonuBirim + ","; } else { f = "null,"; }

            string g;
            if (kompleman.C4Birim != null) { g = "'" + kompleman.C4Birim + "',"; } else { g = "null,"; }

            string h;
            if (kompleman.C3Birim != null) { h = "" + kompleman.C3Birim + ","; } else { h = "null,"; }

            string z;
            if (kompleman.C1qBirim != null) { z = "" + kompleman.C1qBirim; } else { z = "null"; }


            TempData.Keep();
            VeriTabani veriTabani = new VeriTabani();
            veriTabani.openDatabase();

            string sqlstr = "";
            sqlstr += "INSERT INTO public.kompleman(hasta_id, c1_inhibitor_duzey, c1_inhibitor_fonksiyonu_duzey, c4_duzey, c3_duzey, c1q_duzey, antic1_inhibitor_otoantikoru, tarih," +
                " c1_inhibitor_birim, c1_inhibitor_fonksiyonu_birim, c4_birim, c3_birim, c1q_birim)" +
                "VALUES(";
            sqlstr += 1 + ",";
            sqlstr += x;
            sqlstr += y;
            sqlstr += a;
            sqlstr += o;
            sqlstr += b;
            sqlstr += c;
            sqlstr += d;
            sqlstr += e;
            sqlstr += f;
            sqlstr += g;
            sqlstr += h;
            sqlstr += z + ")";


            veriTabani.Execute(sqlstr);

            try
            {

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }

            return View();
        }

        [HttpGet]
        public ActionResult HastaKaydiTiroidFonksiyonTestleri()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HastaKaydiTiroidFonksiyonTestleri(TiroidFonksiyonlari tiroidFonksiyonlari)
        {
            string x;
            if (tiroidFonksiyonlari.TSHDuzey != null) { x = "" + tiroidFonksiyonlari.TSHDuzey + ","; } else { x = "null,"; }

            string y;
            if (tiroidFonksiyonlari.FT4Duzey != null) { y = "" + tiroidFonksiyonlari.FT4Duzey + ","; } else { y = "null,"; }

            string a;
            if (tiroidFonksiyonlari.ANA != null) { a = "" + tiroidFonksiyonlari.ANA + ","; } else { a = "null,"; }

            string o;
            if (tiroidFonksiyonlari.LKM != null) { o = "" + tiroidFonksiyonlari.LKM + ","; } else { o = "null,"; }

            string b;
            if (tiroidFonksiyonlari.AntiTPO != null) { b = "" + tiroidFonksiyonlari.AntiTPO + ","; } else { b = "null,"; }

            string c;
            if (tiroidFonksiyonlari.AntiTiroglobulin != null) { c = "" + tiroidFonksiyonlari.AntiTiroglobulin + ","; } else { c = "null,"; }

            string d;
            if (tiroidFonksiyonlari.AntiTransglutaminaz != null) { d = "" + tiroidFonksiyonlari.AntiTransglutaminaz + ","; } else { d = "null,"; }

            string e;
            if (tiroidFonksiyonlari.AntiGliadin != null) { e = "" + tiroidFonksiyonlari.AntiGliadin + ","; } else { e = "null,"; }

            string f;
            if (tiroidFonksiyonlari.AntiEndomisyum != null) { f = "" + tiroidFonksiyonlari.AntiEndomisyum + ","; } else { f = "null,"; }

            string g;
            if (tiroidFonksiyonlari.Tarih != null) { g = "'" + tiroidFonksiyonlari.Tarih + "',"; } else { g = "null,"; }

            string h;
            if (tiroidFonksiyonlari.TSHBirim != null) { h = "" + tiroidFonksiyonlari.TSHBirim + ","; } else { h = "null,"; }

            string i;
            if (tiroidFonksiyonlari.FT4Birim != null) { i = "" + tiroidFonksiyonlari.FT4Birim + ","; } else { i = "null,"; }

            string j;
            if (tiroidFonksiyonlari.TSHReferansBaslangic != null) { j = "" + tiroidFonksiyonlari.TSHReferansBaslangic + ","; } else { j = "null,"; }

            string k;
            if (tiroidFonksiyonlari.TSHReferansBitis != null) { k = "" + tiroidFonksiyonlari.TSHReferansBitis + ","; } else { k = "null,"; }

            string l;
            if (tiroidFonksiyonlari.FT4ReferansBaslangic != null) { l = "" + tiroidFonksiyonlari.FT4ReferansBaslangic + ","; } else { l = "null,"; }

            string z;
            if (tiroidFonksiyonlari.FT4ReferansBitis != null) { z = "" + tiroidFonksiyonlari.FT4ReferansBitis; } else { z = "null"; }


            TempData.Keep();
            VeriTabani veriTabani = new VeriTabani();
            veriTabani.openDatabase();

            string sqlstr = "";
            sqlstr += "INSERT INTO public.tiroid_fonksiyon_otoantikor(hasta_id, tsh_duzey, ft4_duzey, ana, lkm, anti_tpo, antitiroglobulin, anti_transglutaminaz, anti_gliadin," +
                " anti_endomisyum, tarih, tsh_birim, ft4_birim, tsh_referans_baslangic, tsh_referans_bitis, ft4_referans_baslangic, ft4_referans_bitis)" +
                "VALUES(";
            sqlstr += 1 + ",";
            sqlstr += x;
            sqlstr += y;
            sqlstr += a;
            sqlstr += o;
            sqlstr += b;
            sqlstr += c;
            sqlstr += d;
            sqlstr += e;
            sqlstr += f;
            sqlstr += g;
            sqlstr += h;
            sqlstr += i;
            sqlstr += j;
            sqlstr += k;
            sqlstr += l;
            sqlstr += z + ")";


            veriTabani.Execute(sqlstr);

            try
            {

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }

            return View();
        }

        [HttpGet]
        public ActionResult HastaKaydiGenetik()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HastaKaydiGenetik(Genetik genetik)
        {
            string x;
            if (genetik.Serping1 != null) { x = "" + genetik.Serping1 + ","; } else { x = "null,"; }

            string y;
            if (genetik.Serping1Tip != null) { y = "" + genetik.Serping1Tip + ","; } else { y = "null,"; }

            string a;
            if (genetik.Plasminojen != null) { a = "" + genetik.Plasminojen + ","; } else { a = "null,"; }

            string o;
            if (genetik.PlasminojenTip != null) { o = "" + genetik.PlasminojenTip + ","; } else { o = "null,"; }

            string b;
            if (genetik.F12 != null) { b = "" + genetik.F12 + ","; } else { b = "null,"; }

            string c;
            if (genetik.F12Tip != null) { c = "" + genetik.F12Tip + ","; } else { c = "null,"; }

            string d;
            if (genetik.Angiopoitein != null) { d = "" + genetik.Angiopoitein + ","; } else { d = "null,"; }

            string g;
            if (genetik.AngiopoiteinTip != null) { g = "" + genetik.AngiopoiteinTip + ","; } else { g = "null,"; }

            string e;
            if (genetik.YeniMutasyon != null) { e = "" + genetik.YeniMutasyon + ","; } else { e = "null,"; }

            string f;
            if (genetik.YeniMutasyonTip != null) { f = "" + genetik.YeniMutasyonTip + ""; } else { f = "null"; }

            TempData.Keep();
            VeriTabani veriTabani = new VeriTabani();
            veriTabani.openDatabase();
            string sqlstr = "";
            sqlstr += "INSERT INTO public.genetik(hasta_id, serping1, serping1_tip, plasminojen, plasminojen_tip, f12, f12_tip, angiopoitein, angiopoitein_tip, yeni_mutasyon, yeni_mutasyon_tip)" +
                "VALUES(";

            sqlstr += 1 + ",";
            sqlstr += x;
            sqlstr += y;
            sqlstr += a;
            sqlstr += o;
            sqlstr += b;
            sqlstr += c;
            sqlstr += d;
            sqlstr += g;
            sqlstr += e;
            sqlstr += f + ")";

            veriTabani.Execute(sqlstr);

            try
            {

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }

            return View();
        }

        [HttpGet]
        public ActionResult HastaKaydiHepatitSerolojisi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HastaKaydiHepatitSerolojisi(HepatitSerolojisi hepatitSerolojisi)
        {

            string x;
            if (hepatitSerolojisi.AntiHav != null) { x = "" + hepatitSerolojisi.AntiHav + ","; } else { x = "null,"; }

            string y;
            if (hepatitSerolojisi.HbsAg != null) { y = "" + hepatitSerolojisi.HbsAg + ","; } else { y = "null,"; }

            string a;
            if (hepatitSerolojisi.HbcAgIgg != null) { a = "" + hepatitSerolojisi.HbcAgIgg + ","; } else { a = "null,"; }

            string o;
            if (hepatitSerolojisi.HbeAgIgg != null) { o = "" + hepatitSerolojisi.HbeAgIgg + ","; } else { o = "null,"; }

            string b;
            if (hepatitSerolojisi.AntiHcv != null) { b = "" + hepatitSerolojisi.AntiHcv + ","; } else { b = "null,"; }

            string c;
            if (hepatitSerolojisi.AntiHivIgg != null) { c = "" + hepatitSerolojisi.AntiHivIgg + ","; } else { c = "null,"; }

            string d;
            if (hepatitSerolojisi.AntiHbs != null) { d = "" + hepatitSerolojisi.AntiHbs + ""; } else { d = "null"; }

            TempData.Keep();
            VeriTabani veriTabani = new VeriTabani();
            veriTabani.openDatabase();
            string sqlstr = "";
            sqlstr += "INSERT INTO public.hepatit_serolojisi(hasta_id, anti_hav, hbs_ag, hbc_ag_igg, hbe_ag_igg, anti_hcv, anti_hiv_igg, anti_hbs)" +
                "VALUES(";

            sqlstr += 1 + ",";
            sqlstr += x;
            sqlstr += y;
            sqlstr += a;
            sqlstr += o;
            sqlstr += b;
            sqlstr += c;
            sqlstr += d + ")";

            veriTabani.Execute(sqlstr);

            try
            {

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }

            return View();
        }

        [HttpGet]
        public ActionResult HastaKaydiYanlisTani()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HastaKaydiYanlisTani(YanlisTani yanlisTani)
        {
            TempData.Keep();
            VeriTabani veriTabani = new VeriTabani();
            veriTabani.openDatabase();
            string sqlstr = "";
            sqlstr += "INSERT INTO public.yanlis_tani(hasta_id, ailesel_akdeniz_atesi, operasyon, venoz_obstruksiyon, renal_hastalik, alerjik_anjiyoodem, ace_inhibitor_iliskili_anjiyoodem, diger)" +
                "VALUES(";

            sqlstr += 1 + ",";
            sqlstr += yanlisTani.AileselAkdenizAtesi + ",";
            sqlstr += yanlisTani.Operasyon + ",";
            sqlstr += yanlisTani.VenozObstruksiyon + ",";
            sqlstr += yanlisTani.RenalHastalik + ",";
            sqlstr += yanlisTani.AlerjikAnjiyoodem + ",";
            sqlstr += yanlisTani.AceInhibitorIliskiliAnjiyoodem + ",";
            sqlstr += "'" + yanlisTani.Diger + "')";
            veriTabani.Execute(sqlstr);

            try
            {

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }

            return View();
        }

        [HttpGet]
        public ActionResult HastaKaydiYasamBoyuAtakOzellikleri()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HastaKaydiYasamBoyuAtakOzellikleri(YasamBoyuAtak yasamBoyuAtak)
        {
            string x;
            if (yasamBoyuAtak.FasiyalAtak != null) { x = "" + yasamBoyuAtak.FasiyalAtak + ","; } else { x = "null,"; }

            string y;
            if (yasamBoyuAtak.FasiyalAtakSikligi != null) { y = "" + yasamBoyuAtak.FasiyalAtakSikligi + ","; } else { y = "null,"; }

            string a;
            if (yasamBoyuAtak.IzoleDudakAtak != null) { a = "" + yasamBoyuAtak.IzoleDudakAtak + ","; } else { a = "null,"; }

            string o;
            if (yasamBoyuAtak.IzoleDudakAtakSikiligi != null) { o = "" + yasamBoyuAtak.IzoleDudakAtakSikiligi + ","; } else { o = "null,"; }

            string b;
            if (yasamBoyuAtak.DilAtak != null) { b = "" + yasamBoyuAtak.DilAtak + ","; } else { b = "null,"; }

            string c;
            if (yasamBoyuAtak.DilAtakSikligi != null) { c = "" + yasamBoyuAtak.DilAtakSikligi + ","; } else { c = "null,"; }

            string d;
            if (yasamBoyuAtak.UvulaAtak != null) { d = "" + yasamBoyuAtak.UvulaAtak + ","; } else { d = "null,"; }

            string e;
            if (yasamBoyuAtak.UvulaAtakSikligi != null) { e = "" + yasamBoyuAtak.UvulaAtakSikligi + ","; } else { e = "null,"; }

            string f;
            if (yasamBoyuAtak.LarenksAtak != null) { f = "" + yasamBoyuAtak.LarenksAtak + ","; } else { f = "null,"; }

            string g;
            if (yasamBoyuAtak.LarenksAtakSikligi != null) { g = "" + yasamBoyuAtak.LarenksAtakSikligi + ","; } else { g = "null,"; }

            string h;
            if (yasamBoyuAtak.BoyunAtak != null) { h = "" + yasamBoyuAtak.BoyunAtak + ","; } else { h = "null,"; }

            string i;
            if (yasamBoyuAtak.BoyunAtakSikligi != null) { i = "" + yasamBoyuAtak.BoyunAtakSikligi + ","; } else { i = "null,"; }

            string j;
            if (yasamBoyuAtak.OzafagusAtak != null) { j = "" + yasamBoyuAtak.OzafagusAtak + ","; } else { j = "null,"; }

            string k;
            if (yasamBoyuAtak.OzafagusAtakSikligi != null) { k = "" + yasamBoyuAtak.OzafagusAtakSikligi + ","; } else { k = "null,"; }

            string l;
            if (yasamBoyuAtak.EkstremiteAtak != null) { l = "" + yasamBoyuAtak.EkstremiteAtak + ","; } else { l = "null,"; }

            string m;
            if (yasamBoyuAtak.EkstremiteAtakSikligi != null) { m = "" + yasamBoyuAtak.EkstremiteAtakSikligi + ","; } else { m = "null,"; }

            string n;
            if (yasamBoyuAtak.GogusAtak != null) { n = "" + yasamBoyuAtak.GogusAtak + ","; } else { n = "null,"; }

            string p;
            if (yasamBoyuAtak.GogusAtakSikligi != null) { p = "" + yasamBoyuAtak.GogusAtakSikligi + ","; } else { p = "null,"; }

            string r;
            if (yasamBoyuAtak.RenalAtak != null) { r = "" + yasamBoyuAtak.RenalAtak + ","; } else { r = "null,"; }

            string s;
            if (yasamBoyuAtak.RenalAtakSikligi != null) { s = "" + yasamBoyuAtak.RenalAtakSikligi + ","; } else { s = "null,"; }

            string t;
            if (yasamBoyuAtak.MesaneAtak != null) { t = "" + yasamBoyuAtak.MesaneAtak + ","; } else { t = "null,"; }

            string u;
            if (yasamBoyuAtak.MesaneAtakSikligi != null) { u = "" + yasamBoyuAtak.MesaneAtakSikligi + ","; } else { u = "null,"; }

            string v;
            if (yasamBoyuAtak.KasAtak != null) { v = "" + yasamBoyuAtak.KasAtak + ","; } else { v = "null,"; }

            string w;
            if (yasamBoyuAtak.KasAtakSikligi != null) { w = "" + yasamBoyuAtak.KasAtakSikligi + ","; } else { w = "null,"; }

            string hh;
            if (yasamBoyuAtak.EklemAtak != null) { hh = "" + yasamBoyuAtak.EklemAtak + ","; } else { hh = "null,"; }

            string z;
            if (yasamBoyuAtak.EklemAtakSikligi != null) { z = "" + yasamBoyuAtak.EklemAtakSikligi + ","; } else { z = "null,"; }

            string aa;
            if (yasamBoyuAtak.GastrointestinalAtak != null) { aa = "" + yasamBoyuAtak.GastrointestinalAtak + ","; } else { aa = "null,"; }

            string bb;
            if (yasamBoyuAtak.GastrointestinalAtakSikligi != null) { bb = "" + yasamBoyuAtak.GastrointestinalAtakSikligi + ","; } else { bb = "null,"; }

            string cc;
            if (yasamBoyuAtak.AnalAtak != null) { cc = "" + yasamBoyuAtak.AnalAtak + ","; } else { cc = "null,"; }

            string dd;
            if (yasamBoyuAtak.AnalAtakSikligi != null) { dd = "" + yasamBoyuAtak.AnalAtakSikligi + ","; } else { dd = "null,"; }

            string ee;
            if (yasamBoyuAtak.GenitalAtak != null) { ee = "" + yasamBoyuAtak.GenitalAtak + ","; } else { ee = "null,"; }

            string ff;
            if (yasamBoyuAtak.GenitalAtakSikligi != null) { ff = "" + yasamBoyuAtak.GenitalAtakSikligi + ""; } else { ff = "null"; }


            TempData.Keep();
            VeriTabani veriTabani = new VeriTabani();
            veriTabani.openDatabase();
            string sqlstr = "";
            sqlstr += "INSERT INTO public.yasam_boyu_atak_ozellikleri(hasta_id, fasiyal_atak, fasiyal_atak_siklik, izole_dudak_atak, izole_dudak_atak_siklik, dil_atak, dil_atak_siklik, uvula_atak, uvula_atak_siklik, larenks_atak, larenks_atak_siklik, boyun_atak, boyun_atak_siklik, ozefagus_atak, ozefagus_atak_siklik, ekstremite_atak, ekstremite_atak_siklik, gogus_atak, gogus_atak_siklik, renal_atak, renal_atak_siklik, mesane_atak, mesane_atak_siklik, kas_atak, kas_atak_siklik, eklem_atak, eklem_atak_siklik, gastrointestinal_atak, gastrointestinal_atak_siklik, anal_atak, anal_atak_siklik, genital_atak, genital_atak_siklik)" +
                "VALUES(";

            sqlstr += 1 + ",";
            sqlstr += x;
            sqlstr += y;
            sqlstr += a;
            sqlstr += o;
            sqlstr += b;
            sqlstr += c;
            sqlstr += d;
            sqlstr += e;
            sqlstr += f;
            sqlstr += g;
            sqlstr += h;
            sqlstr += i;
            sqlstr += j;
            sqlstr += k;
            sqlstr += l;
            sqlstr += m; 
            sqlstr += n;
            sqlstr += p;
            sqlstr += r;
            sqlstr += s;
            sqlstr += t;
            sqlstr += u;
            sqlstr += v;
            sqlstr += w;
            sqlstr += hh;
            sqlstr += z;
            sqlstr += aa;
            sqlstr += bb;
            sqlstr += cc;
            sqlstr += dd;
            sqlstr += ee;
            sqlstr += ff + ")";
            veriTabani.Execute(sqlstr);

            try
            {

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }

            return View();
        }

        public IActionResult Profilim()
        {
            return View();
        }
    }
}
