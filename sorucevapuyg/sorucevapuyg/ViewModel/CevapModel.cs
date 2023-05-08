using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace sorucevapuyg.ViewModel
{
    public class Cevap
    {
        public int CevapId { get; set; }
        public string CevapIcerik { get; set; }
        public System.DateTime Tarih { get; set; }
        public int KullaniciId { get; set; }
        public int SoruId { get; set; }


    }



}