using System;
using System.Text.RegularExpressions;
namespace kelimeAvi
{
    public partial class Form1 : Form
    {
        Class_game_kelimeavi game = new Class_game_kelimeavi();
        private string denen_harf;
        private int denemeSayisi = 0;

        public Form1()
        {
            InitializeComponent();
        }
        void oyun_baslangic_ayarlari()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Enabled = true;
            groupBox_Tahmin.Enabled = true;
            groupBox_Skor.Enabled = true;
            button_basla.Enabled = false;
            label_Skor.Text = "0";
            label_deneme.Text = game.harf_sayisi.ToString();
            kelimeyi_olustur();

        }
        void oyun_bitis_ayarlari()
        {
            flowLayoutPanel1.Enabled = false;
            groupBox_Tahmin.Enabled = false;
            groupBox_Skor.Enabled = false;
            button_basla.Enabled = true;
            textBox_tahmin.Clear();
        }
        public void kelimeyi_olustur()
        {
            for (int i = 0; i < game.harf_sayisi; i++)
            {
                Button btn_yeni = new Button();
                btn_yeni.Margin = new Padding(0);
                btn_yeni.Size = new Size(35, 35);
                btn_yeni.BackColor = Form1.DefaultBackColor;
                btn_yeni.Enabled = false;
                btn_yeni.Tag = i;
                btn_yeni.Click += new EventHandler(btn_yeni_Click);
                flowLayoutPanel1.Controls.Add(btn_yeni);
            }
            //game.kelime_havuzu.ToString();
        }
        private void btn_yeni_Click(object sender, EventArgs e)
        {
            Button basilan_button = (Button)sender;
            basilan_button.Text = denen_harf;
            basilan_button.Enabled = false;
        }
        private void dogrutahminiGoster(int konum)
        {
            foreach (Button _btn in flowLayoutPanel1.Controls)
            {
                if ((int)_btn.Tag == konum)
                {
                    _btn.Enabled = true;
                    _btn.BackColor = Color.GreenYellow;
                }
            }
        }
        private void button_basla_Click(object sender, EventArgs e)
        {
            oyun_baslangic_ayarlari();
        }

        private void button_Dene_Click(object sender, EventArgs e)
        {
            string kural = "^[a-zA-Z]*$";//sadece harf giriþi için
            Regex kontrol = new Regex(kural);
            if (!kontrol.Match(textBox_tahmin.Text).Success)
            {
                MessageBox.Show("Sadece Harf/Harflerden olumuþ bir deneme yapabilirsiniz");
                textBox_tahmin.Clear();
            }
            else
            {
                if (textBox_tahmin.Text.Length < 2)
                {
                    List<int> bulunanKonumlar = game.harfKontrol(textBox_tahmin.Text[0]);
                    foreach (int konum in bulunanKonumlar)
                    {
                        dogrutahminiGoster(konum);
                        denen_harf = textBox_tahmin.Text.ToUpper();
                    }
                    Skorhesapla(bulunanKonumlar.Count);
                    deneme_sayisi_goster();
                }
                else
                {
                    if (game.tahminKontrol(textBox_tahmin.Text))
                    {
                        Skorhesapla(100);
                        oyun_bitis_ayarlari();
                    }
                    else { deneme_sayisi_goster(); }
                }
            }

        }

        private void Skorhesapla(int count)
        {
            int oncekiSkor = Convert.ToInt32(label_Skor.Text);
            int denemesayisi = Convert.ToInt32(label_deneme.Text);
            int yeniSkor = count * denemesayisi + oncekiSkor;
            label_Skor.Text = yeniSkor.ToString();
        }

        private void deneme_sayisi_goster()
        {
            int oncekiDenemeSayisi = Convert.ToInt32(label_deneme.Text);
            if (oncekiDenemeSayisi > 1)
            {
                label_deneme.Text = (oncekiDenemeSayisi - 1).ToString();
                
            }
            else
            {
                label_Skor.Text = "XXX";
                oyun_bitis_ayarlari();
                oyun_kaybetme();
            }
        }

        private void oyun_kaybetme()
        {
            foreach (Button _btn in flowLayoutPanel1.Controls)
            {
                _btn.BackColor = Color.MediumVioletRed;
                _btn.Enabled = true;                
            }
            textBox_tahmin.Text = game.cevap;
        }
    }
}