using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YazOkuluDersler
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
            Txtıd.Text = x.ToString();
            Txtıd.Enabled = false;

            if(Page.IsPostBack == false) { 

            EntityOgrenci ent = new EntityOgrenci();
            List<EntityOgrenci> OgrList = BLLOgrenci.BllDetay(x);
            TxtAd.Text = OgrList[0].AD.ToString();
            TxtSoyad.Text = OgrList[0].SOYAD.ToString();
            TxtNumara.Text = OgrList[0].NUMARA.ToString();
            TxtFoto.Text = OgrList[0].FOTOGRAF.ToString();
            TxtSifre.Text = OgrList[0].SIFRE.ToString();

        }
}
        protected void TxtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.AD = TxtAd.Text;
            ent.SOYAD = TxtSoyad.Text;
            ent.SIFRE = TxtSifre.Text;
            ent.NUMARA = TxtNumara.Text;
            ent.FOTOGRAF = TxtFoto.Text;
            ent.ID = Txtıd.Text;
            BLLOgrenci.OgrenciGuncelleBLL(ent);
            Response.Redirect("OgrenciListesi.Aspx");
        }

        protected void Txtıd_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Txtıd_TextChanged1(object sender, EventArgs e)
        {

        }
    }
}