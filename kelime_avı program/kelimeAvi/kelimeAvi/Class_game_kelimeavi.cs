using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace kelimeAvi
{
    class kelime
    {
        public string madde { get; set; }
    }

    internal class Class_game_kelimeavi
    {
        public int harf_sayisi;
        private string secilen_Kelime;
        public string cevap;
        static readonly HttpClient client = new HttpClient();

        public Class_game_kelimeavi()
        {
            random_kelime_sec();
        }

        private List<kelime> kelime_havuzu;
        private void random_kelime_sec()
        {
            kelimeleriYukle();
            Random r = new Random();
            int rastgele_sayi = r.Next(kelime_havuzu.Count);
            secilen_Kelime = kelime_havuzu[rastgele_sayi].madde;
            harf_sayisi = secilen_Kelime.Length;
            cevap = secilen_Kelime;
        }

        private void kelimeleriYukle()
        {
            string url = "https://sozluk.gov.tr/autocomplete.json";

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            string jsonverisi = "";
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                jsonverisi = reader.ReadToEnd();
                kelime_havuzu = JsonSerializer.Deserialize<List<kelime>>(jsonverisi);
            }
        }


        public List<int> harfKontrol(char harf)
        {
            int say = 0;
            List<int> bulunanKonumlar = new List<int>();
            foreach (char _harf in secilen_Kelime)
            {
                if (harf == _harf) { bulunanKonumlar.Add(say); }
                say++;
                
            }
            return bulunanKonumlar;
        }

        public bool tahminKontrol(string tahmin)
        {
            return tahmin == secilen_Kelime ? true : false;
        }
    }
}
