﻿using P04AplikacjaZawodnicy.Core.Repositories;
using P04AplikacjaZawodnicy.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P02AplikacjaZawodnicy
{
    public partial class ZawodnicyServer : System.Web.UI.Page
    {
        public ZawodnikVM[] Zawodnicy;
        public int LiczbaStron;
        public int AktualnaStrona;
        protected void Page_Load(object sender, EventArgs e)
        {
            //  Thread.Sleep(4000);
            AktualnaStrona = Convert.ToInt32(Request["nrStrony"]);

            ZawodnicyRepository zr = new ZawodnicyRepository();
            var wynik= zr.PobierzZawodnikow(AktualnaStrona);
            Zawodnicy = wynik.Zawodnicy.Select(x=>new ZawodnikVM(x)).ToArray();
            LiczbaStron = wynik.LiczbaStron;
            
        }


    }
}