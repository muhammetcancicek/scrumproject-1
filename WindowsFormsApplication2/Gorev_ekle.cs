using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Gorev_ekle
    {
        public string GorevStory { get; set; }
        public string GorevIcerigi { get; set; }
        public DateTime GorevBaslangiçTarihi { get; set; }
        public DateTime GorevBitisTarihi { get; set; }
        public int GorevPuani { get; set;}//her görev bitirdiğinde puan kazanırsın kuanlara göre sıralama yapıp kimim ne kadar çalıştığını bulabilirsin
        public string GorevDurumu { get; set; }//aldığın görevin ne kadarını yaptığını gösteriyor ama mod 100 e göre yapılmalı henüz bişey yapmadım bu konuda
        public string GorevAlanPers { get; set; }//görevi alan personelin adı buraya atanır

        public Gorev_ekle()
        {
            this.GorevPuani = 1;
            this.GorevDurumu = "bosta...";
            this.GorevAlanPers = "alinmadi...";
        }

    }
}
