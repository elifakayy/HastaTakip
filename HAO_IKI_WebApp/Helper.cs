using System.Data;
using HAO_IKI_WebApp.Models;
using veritabani;

namespace HAO_IKI_WebApp
{
    public static class Helper
    {
        public static List<Moduller> GetMenu(ISession session)
        {
            
            List<Moduller> m = new List<Moduller>();
            VeriTabani vt = new VeriTabani();
            vt.openDatabase();
            if (vt.isOpen())
            {
                string sqlstr;
                DataTable dt = new DataTable();

                sqlstr = "SELECT md.id, md.adi, md.ust_modul, md.acilabilir_menu, md.icon, md.adres, md.parametre" +
                         " FROM public.sorumluluk_modulleri as sm, public.moduller as md, public.kullanici_sorumluluk as ks" +
                         " Where sm.modul = md.id And sm.sorumluluk = ks.kullanici_tipi" +
                         " And ks.kullanici = " + session.GetString("currentUserId") +
                         " Order By md.\"sıra\"";

                vt.fillDataTable(dt, sqlstr, false);
                foreach (DataRow dr in dt.Rows)
                {
                    Moduller mn = new Moduller();

                    mn.AcilabilirMenu = (bool)dr["acilabilir_menu"];
                    mn.Adi = dr["adi"].ToString();
                    mn.Icon = dr["icon"].ToString();
                    mn.Id = (long)dr["id"];
                    mn.Parametre = dr["parametre"].ToString();
                    if (mn.Parametre == "")
                        mn.Adres = dr["adres"].ToString();
                    else
                        mn.Adres = dr["adres"].ToString() + "?" + mn.Parametre;
                    //mn.Sira = (int)dr["Sıra"];
                    if (dr["ust_modul"] != DBNull.Value)
                        mn.UstModul = (long)dr["ust_modul"];

                    m.Add(mn);
                }
            }
            vt.closeDatabase();
            return m;
        }
    }
}
