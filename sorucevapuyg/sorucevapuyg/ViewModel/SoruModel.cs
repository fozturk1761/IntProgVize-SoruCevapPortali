using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sorucevapuyg.ViewModel
{
    public class SoruModel
    {
        public int SoruId { get; set; }
        public string Baslik { get; set; }
        public string SoruIcerik { get; set; }
        public System.DateTime Tarih { get; set; }
        public int KullaniciId { get; set; }
    } 
}