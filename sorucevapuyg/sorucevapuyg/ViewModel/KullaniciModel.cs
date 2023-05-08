using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sorucevapuyg.Models;


namespace sorucevapuyg.ViewModel
{
    public class KullaniciModel
    {
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
    }
}