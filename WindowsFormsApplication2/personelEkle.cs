using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
       public class personelEkle : IPerİletisim
    {
        public string PerSifre { get; set; }
        public string PerIsim { get; set; }
        public int PerSeviye { get; set; }
        public int Perrenk { get; set; }
        public string PerEposta { get; set; }
        public string PerTelf { get; set; }
        public string PerAdres { get; set; }

        public string gorevler { get; set; }
        
         public personelEkle()
        {

        }
        İŞ_PLALAMA işplanla;
        public personelEkle(İŞ_PLALAMA işplanlama)
        {
            
            this.işplanla = işplanlama;
            this.PerSeviye = 0;
            this.Perrenk = (işplanlama.renkkodu)%5;

        }



    }
}
