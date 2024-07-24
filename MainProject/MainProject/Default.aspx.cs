using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        EntityStudent ent = new EntityStudent();
        ent.Ad = "Derya";
        ent.Soyad = "Yildiz";
        ent.Numara = "1453";
        ent.Sifre = "112233";
        BLLogrenci.OgrenciEkleBLL(ent);
    }
}