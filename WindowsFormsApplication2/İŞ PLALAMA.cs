using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class İŞ_PLALAMA
    {
        public string etkinkisi { get; set; }//giris yapan kişinin ismi buraya atılıyor foreach de isme göre arayıp bilgilerine erişebilirsin
        public bool yoneticimi { get; set; }
        public List<Gorev_ekle> GorevList;
        public List<personelEkle> perlist;
        public List<yonetciEkle> yoneticilist;
        
        public int renkkodu = 1;
        public int etkinrenk; 
        
        public İŞ_PLALAMA()
        {
            perlist = new List<personelEkle>();
            GorevList = new List<Gorev_ekle>();
            yoneticilist = new List<yonetciEkle>();
            

        }
            
    }
}
