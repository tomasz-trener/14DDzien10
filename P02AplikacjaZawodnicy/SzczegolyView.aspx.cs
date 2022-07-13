using P04AplikacjaZawodnicy.Core.Repositories;
using P04AplikacjaZawodnicy.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class SzczegolyView : System.Web.UI.Page
    {
        public ZawodnikVM ZawodnikVM;
        protected void Page_Load(object sender, EventArgs e)
        {
            string ids = Request["id"];
            // string imies = Request["txtImie"];


            //if (string.IsNullOrEmpty(ids))
            //    Response.Redirect("Default.aspx");

            if (!Page.IsPostBack && !string.IsNullOrEmpty(ids))
            {
                int id = Convert.ToInt32(ids);
                ZawodnicyRepository zr = new ZawodnicyRepository();
                Zawodnik z = zr.PodajZawodnika(id);
                ZawodnikVM = new ZawodnikVM(z);

                txtImie.Text = ZawodnikVM.Imie;
                txtNazwisko.Text = ZawodnikVM.Nazwisko;
                txtKraj.Text = ZawodnikVM.Kraj;
                txtDataUr.Text = ZawodnikVM.DataUrFormat;
                txtWzrost.Text = ZawodnikVM.Wzrost?.ToString();
                txtWaga.Text = (ZawodnikVM.Waga ?? 0).ToString();

               // if (Roles.IsUserInRole("Administrator"))
                    btnUsun.Visible = true;



                //lblTytul.Text = "Edycja";
            }


            //if (ZawodnikVM.Waga == null)
            //    txtWaga.Text = "0";
            //else 
            //    txtWaga.Text = ZawodnikVM.Waga.ToString();




        }

        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();

            Zawodnik z = new Zawodnik();
            string ids = Request["id"];


            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;
            z.Kraj = txtKraj.Text;

            if (string.IsNullOrEmpty(txtDataUr.Text))
                z.Data_ur = null;
            else
                z.Data_ur = Convert.ToDateTime(txtDataUr.Text);

            if (string.IsNullOrEmpty(txtWaga.Text))
                z.Waga = null;
            else
                z.Waga = Convert.ToInt32(txtWaga.Text);

            if (string.IsNullOrEmpty(txtWzrost.Text))
                z.Wzrost = null;
            else
                z.Wzrost = Convert.ToInt32(txtWzrost.Text);

            if (!string.IsNullOrEmpty(ids))
            {
                z.Id_zawodnika = Convert.ToInt32(Request["id"]);
                zr.Edytuj(z);
            }
            else
                zr.Dodaj(z);

            Response.Redirect("Default.aspx");
        }

        protected void btnUsun_Click(object sender, EventArgs e)
        {
            if (Roles.IsUserInRole("Administrator"))
            {
                ZawodnicyRepository zr = new ZawodnicyRepository();

                Zawodnik z = new Zawodnik();
                z.Id_zawodnika = Convert.ToInt32(Request["id"]);

                zr.Usun(z);
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Write("Nie mozesz usunac");
            }

           
        }
    }
}