using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Proje_Odevi
{ 
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        IkılıAramaAgaci ii = new IkılıAramaAgaci();
        Ogrenci_Bilgi o;
        Ogrenci_Bilgi o1;
        Ogrenci_Bilgi o2 = new Ogrenci_Bilgi();
        Ogrenci_Bilgi o5 = new Ogrenci_Bilgi();
        HashMap hash = new HashMap();
        Heap yazılım = new Heap(15);
        Heap mekatronik = new Heap(15);

        private void Form1_Load(object sender, EventArgs e)
        {
            hash.AddOgrenci(0 * 1, yazılım);
            hash.AddOgrenci(1 * 1, mekatronik);
            o1 = new Ogrenci_Bilgi();
            o1.Adi = "Gülşan";
            o1.Ogrenci_No = 1123;
            o1.Adres = "Bolu";
            o1.Dogum_tarihi = "1997";
            o1.e_posta = "gclp@gmail.com";
            o1.Uyruk = "TC";
            o1.Telefon = 0545513;
            o1.Yabanci_dil = "Advanced";
            o1.staj.Sirket_Adi = "Linovi";
            o1.staj.Tarih = "2017";
            o1.staj.departman = "Yazılım";
            o1.mezun.Bolum_Adı = "Yazılım Mühendisliği";
            o1.mezun.Not_Ortalama = 95;
            o1.mezun.Tarih = "2014-2019";
            o1.mezun.Basari_Belgesi = true;
            o1.Ilgi_Alani = "Kitap okumak";
            o5 = new Ogrenci_Bilgi();
            o5.Adi = "Türkü";
            o5.Ogrenci_No = 1124;
            o5.Adres = "Doğan";
            o5.Dogum_tarihi = "1997";
            o5.e_posta = "turkudogan@hotmail.com";
            o5.Uyruk = "TC";
            o5.Telefon = 0554502;
            o5.Yabanci_dil = "Advanced";
            o5.staj.Sirket_Adi = "Alastyr";
            o5.staj.Tarih = "2017";
            o5.staj.departman = "Yazılım";
            o5.mezun.Bolum_Adı = "Yazılım Mühendisliği";
            o5.mezun.Not_Ortalama = 85;
            o5.mezun.Tarih = "2014-2019";
            o5.mezun.Basari_Belgesi = true;
            o5.Ilgi_Alani = "Müzik Dinlemek";

            hash.table[0].Deger.Insert(o1);
            hash.table[0].Deger.Insert(o5);

            ii.Ekle(o1);
            ii.Ekle(o5);



        }
        private void button1_Click(object sender, EventArgs e)
        {


            o = new Ogrenci_Bilgi();
            o.Adi = textBox1.Text;
            o.Telefon = Convert.ToUInt32(textBox9.Text);
            o.Adres = textBox10.Text;
            o.Dogum_tarihi = textBox4.Text;
            o.e_posta = textBox7.Text;
            o.Ilgi_Alani = textBox5.Text;
            o.Ogrenci_No = Convert.ToUInt32(textBox3.Text);
            o.Uyruk = textBox6.Text;
            o.Yabanci_dil = comboBox8.Text;
            o.staj.Sirket_Adi = textBox14.Text;
            o.staj.departman = textBox13.Text;
            o.staj.Tarih = textBox12.Text;
            o.mezun.Bolum_Adı = comboBox9.Text;
            o.mezun.Not_Ortalama = Convert.ToSingle(txtnot.Text);
            o.mezun.Tarih = txttarihh.Text;
            o.mezun.Basari_Belgesi = Convert.ToBoolean(chcbasari.Checked);
            if (comboBox9.Text == "Yazılım Mühendisliği")
            {
                hash.table[0].Deger.Insert(o);
            }
            else
            {
                hash.table[1].Deger.Insert(o);

            }


            ii.Ekle(o);


            MessageBox.Show("Kayıt yapıldı..");

            textBox1.Text = "ADI";
            textBox9.Text = "TELEFON";
            textBox10.Text = "ADRES";
            textBox7.Text = "E-POSTA";
            textBox4.Text = "DOĞUM TARİHİ";
            textBox3.Text = "ÖĞRENCİ NO";
            comboBox8.Text = "YABANCI DİL";
            textBox5.Text = "İLGİ ALANI";
            textBox6.Text = "UYRUK";
            textBox14.Text = "ŞİRKET";
            textBox13.Text = "DEPARTMAN";
            textBox12.Text = "TARİH";
            comboBox9.Text = "BÖLÜM ADI";
            txtnot.Text = "NOT ORTALAMASI";
            txttarihh.Text = "BAŞ-BİT TARİHİ";



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {



        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox11.Text);
            ii.Sil(sayi);
            MessageBox.Show("Öğrenci silindi");

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            Ogrenci_Bilgi o3 = new Ogrenci_Bilgi();
            o3.Ogrenci_No = Convert.ToUInt32(textBox21.Text);
            o3.Adi = txtad.Text;
            o3.Adres = txtadres.Text;
            o3.Yabanci_dil = txtdil.Text;
            o3.Ilgi_Alani = txtilgi.Text;
            o3.e_posta = txtposta.Text;
            o3.Dogum_tarihi = txttarih.Text;
            o3.Telefon = Convert.ToUInt32(txttel.Text);
            o3.Uyruk = txtuyruk.Text;
            o3.mezun.Bolum_Adı = comboBox9.Text;
            ii.Guncelle(o3);

            MessageBox.Show("Güncellendi");


        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            int sayi = Convert.ToInt32(textBox21.Text);
            o2 = ii.Ara(sayi).veri;

            txtad.Text = o2.Adi;
            txtadres.Text = o2.Adres;
            txtdil.Text = o2.Yabanci_dil;
            txtilgi.Text = o2.Ilgi_Alani;
            txtposta.Text = o2.e_posta;
            txttarih.Text = o2.Dogum_tarihi;
            txttel.Text = o2.Telefon.ToString();
            txtuyruk.Text = o2.Uyruk;
            txtbastarihi.Text = o2.mezun.Tarih;
            txtbolumadi.Text = o2.mezun.Bolum_Adı;
            txtortalama.Text = o2.mezun.Not_Ortalama.ToString();
            checkBox1.Checked = o2.mezun.Basari_Belgesi;
            txtsirket.Text = o2.staj.Sirket_Adi;
            txtdepartman.Text = o2.staj.departman;
            txtt.Text = o2.staj.Tarih;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            İkiliAramaAgacDugumu ogr = new İkiliAramaAgacDugumu();
            int sayi = Convert.ToInt32(textBox8.Text);

            ogr = ii.Ara(sayi);
            if (ogr != null)
            {
                txtara.Text = "ÖĞRENCİ NO:" + ogr.veri.Ogrenci_No + Environment.NewLine +
                 "ADI:" + ogr.veri.Adi + Environment.NewLine + "ADRES:" + ogr.veri.Adres + Environment.NewLine +
                 "DOĞUM TARİHİ:" + ogr.veri.Dogum_tarihi + Environment.NewLine + "E-POSTA:" + ogr.veri.e_posta +
                 Environment.NewLine + "İLGİ ALANI:" + ogr.veri.Ilgi_Alani + Environment.NewLine +
                 "TELEFON:" + ogr.veri.Telefon + Environment.NewLine + "UYRUK:" + ogr.veri.Uyruk + Environment.NewLine +
                 "YABANCI DİL:" + ogr.veri.Yabanci_dil + Environment.NewLine + "ŞİRKET:" + ogr.veri.staj.Sirket_Adi + Environment.NewLine +
                 "DEPARTMAN:" + ogr.veri.staj.departman + Environment.NewLine + "TARİH:" + ogr.veri.staj.Tarih + Environment.NewLine;

            }
            else
                MessageBox.Show("Kayıtlı öğrencimiz yoktur..");
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtsirala.Text = "";
            ii.PreOrder();
            txtsirala.Text = ii.temp.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            switch (cmdbox.SelectedIndex)
            {
                case 0:
                    ii.PreOrder();
                    break;
                case 1:
                    ii.InOrder();
                    break;
                case 2:
                    ii.PostOrder();
                    break;
                default:
                    break;
            }
            textBox15.Text = ii.DugumleriYazdir();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox16.Text = "";
            ii.PreOrder();
            textBox16.Text = ii.i.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "yazılım mühendisliği")
            {
                Heap temp = (Heap)hash.table[0].Deger;
                HeapDugumu[] t = temp.DisplayHeap();

                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] != null)
                    {

                        textBox19.Text += "ÖĞRENCİ NO:" + t[i].Deger.Ogrenci_No + Environment.NewLine +
                        "ADI:" + t[i].Deger.Adi + Environment.NewLine + "ADRES:" + t[i].Deger.Adres + Environment.NewLine +
                        "DOĞUM TARİHİ:" + t[i].Deger.Dogum_tarihi + Environment.NewLine + "E-POSTA:" + t[i].Deger.e_posta +
                        Environment.NewLine + "İLGİ ALANI:" + t[i].Deger.Ilgi_Alani + Environment.NewLine +
                        "TELEFON:" + t[i].Deger.Telefon + Environment.NewLine + "UYRUK:" + t[i].Deger.Uyruk + Environment.NewLine +
                        "YABANCI DİL:" + t[i].Deger.Yabanci_dil + Environment.NewLine + "ŞİRKET:" + t[i].Deger.staj.Sirket_Adi + Environment.NewLine +
                        "DEPARTMAN:" + t[i].Deger.staj.departman + Environment.NewLine + "TARİH:" + t[i].Deger.staj.Tarih + Environment.NewLine;

                    }

                }

            }
            else
            {
                Heap temp = (Heap)hash.table[1].Deger;
                HeapDugumu[] t = temp.DisplayHeap();
                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] != null)
                    {

                        textBox19.Text += "ÖĞRENCİ NO:" + t[i].Deger.Ogrenci_No + Environment.NewLine +
                        "ADI:" + t[i].Deger.Adi + Environment.NewLine + "ADRES:" + t[i].Deger.Adres + Environment.NewLine +
                        "DOĞUM TARİHİ:" + t[i].Deger.Dogum_tarihi + Environment.NewLine + "E-POSTA:" + t[i].Deger.e_posta +
                        Environment.NewLine + "İLGİ ALANI:" + t[i].Deger.Ilgi_Alani + Environment.NewLine +
                        "TELEFON:" + t[i].Deger.Telefon + Environment.NewLine + "UYRUK:" + t[i].Deger.Uyruk + Environment.NewLine +
                        "YABANCI DİL:" + t[i].Deger.Yabanci_dil + Environment.NewLine + "ŞİRKET:" + t[i].Deger.staj.Sirket_Adi + Environment.NewLine +
                        "DEPARTMAN:" + t[i].Deger.staj.departman + Environment.NewLine + "TARİH:" + t[i].Deger.staj.Tarih + Environment.NewLine;

                    }

                }



            }



        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "yazılım mühendisliği")
            {
                Heap temp = (Heap)hash.table[0].Deger;
                HeapDugumu[] t = temp.DisplayHeap();
                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] != null)
                    {

                        textBox20.Text += Environment.NewLine + "ÖĞRENCİ NO:" + t[i].Deger.Ogrenci_No + Environment.NewLine +
                        "ADI:" + t[i].Deger.Adi + Environment.NewLine + "Başarı Notu:" + t[i].Deger.mezun.Not_Ortalama;

                    }

                }

            }
            else
            {
                Heap temp = (Heap)hash.table[1].Deger;
                HeapDugumu[] t = temp.DisplayHeap();
                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] != null)
                    {

                        textBox20.Text += Environment.NewLine + "ÖĞRENCİ NO:" + t[i].Deger.Ogrenci_No + Environment.NewLine +
                        "ADI:" + t[i].Deger.Adi + Environment.NewLine + "Başarı Notu:" + t[i].Deger.mezun.Not_Ortalama;

                    }

                }


            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox17.Text = "";
            if (comboBox2.Text == "yazılım mühendisliği")
            {
                Heap temp = (Heap)hash.table[0].Deger;
                HeapDugumu[] t = temp.DisplayHeap();
                string dilSeviyesi = comboBox4.Text;
                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] != null)
                    {
                        if (t[i].Deger.Yabanci_dil == dilSeviyesi)
                        {
                            textBox17.Text += Environment.NewLine + "ÖĞRENCİ NO:" + t[i].Deger.Ogrenci_No + Environment.NewLine +
                          "ADI:" + t[i].Deger.Adi + Environment.NewLine + t[i].Deger.Yabanci_dil;
                        }

                    }

                }

            }
            else
            {
                Heap temp = (Heap)hash.table[1].Deger;
                HeapDugumu[] t = temp.DisplayHeap();
                string dilSeviyesi = comboBox4.Text;
                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] != null)
                    {
                        if (t[i].Deger.Yabanci_dil == dilSeviyesi)
                        {
                            textBox17.Text += Environment.NewLine + "ÖĞRENCİ NO:" + t[i].Deger.Ogrenci_No + Environment.NewLine +
                          "ADI:" + t[i].Deger.Adi + Environment.NewLine + t[i].Deger.Yabanci_dil;
                        }

                    }

                }


            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (comboBox5.Text == "Yazılım Mühendisliği")
            {
                Heap temp = (Heap)hash.table[0].Deger;
                HeapDugumu[] t = temp.DisplayHeap();
                string basari = comboBox5.Text;
                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] != null)
                    {
                        if (t[i].Deger.mezun.Bolum_Adı == basari)
                        {
                            string OgrenciNo = t[i].Deger.Ogrenci_No.ToString();
                            string Adi = t[i].Deger.Adi;
                            string Not = t[i].Deger.mezun.Not_Ortalama.ToString();

                            string[] bilgiler = { OgrenciNo, Adi, Not };

                            listView1.Items.Add(new ListViewItem(bilgiler));
                        }

                    }

                }

            }
            else
            {
                Heap temp = (Heap)hash.table[1].Deger;
                HeapDugumu[] t = temp.DisplayHeap();
                string basari = comboBox5.Text;
                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] != null)
                    {
                        if (t[i].Deger.mezun.Bolum_Adı == basari)
                        {
                            string OgrenciNo = t[i].Deger.Ogrenci_No.ToString();
                            string Adi = t[i].Deger.Adi;
                            string Not = t[i].Deger.mezun.Not_Ortalama.ToString();

                            string[] bilgiler = { OgrenciNo, Adi, Not };

                            listView1.Items.Add(new ListViewItem(bilgiler));
                        }

                    }

                }


            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int secimSayisi = listView1.SelectedItems.Count;

            foreach (ListViewItem bilgi in listView1.SelectedItems)
            {
                textBox22.Text = bilgi.SubItems[1].Text;
                MessageBox.Show("İşe alınacaktır..");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
            if (comboBox7.Text == "Yazılım Mühendisliği")
            {
                Heap temp = (Heap)hash.table[0].Deger;
                HeapDugumu[] t = temp.DisplayHeap();
                string dilSeviyesi = comboBox6.Text;
                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] != null)
                    {
                        if (t[i].Deger.Yabanci_dil == dilSeviyesi)
                        {
                            string OgrenciNo = t[i].Deger.Ogrenci_No.ToString();
                            string Adi = t[i].Deger.Adi;
                            string dil = t[i].Deger.Yabanci_dil.ToString();

                            string[] bilgiler = { OgrenciNo, Adi, dil };

                            listView2.Items.Add(new ListViewItem(bilgiler));
                        }

                    }

                }

            }
            else
            {
                Heap temp = (Heap)hash.table[1].Deger;
                HeapDugumu[] t = temp.DisplayHeap();
                string dilSeviyesi = comboBox6.Text;
                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] != null)
                    {
                        if (t[i].Deger.Yabanci_dil == dilSeviyesi)
                        {
                            textBox17.Text += Environment.NewLine + "ÖĞRENCİ NO:" + t[i].Deger.Ogrenci_No + Environment.NewLine +
                          "ADI:" + t[i].Deger.Adi + Environment.NewLine + t[i].Deger.Yabanci_dil;
                        }

                    }

                }


            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int secimSayisi = listView2.SelectedItems.Count;

            foreach (ListViewItem bilgi in listView2.SelectedItems)
            {
                textBox18.Text = bilgi.SubItems[1].Text;
                MessageBox.Show("İşe alınacaktır..");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {

           textBox23.Text= ii.DugumSayisi().ToString();
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtad_Click(object sender, EventArgs e)
        {
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_Click(object sender, EventArgs e)
        {
            textBox21.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
        }

        private void textBox14_Click(object sender, EventArgs e)
        {
            textBox14.Text = "";
        }

        private void textBox13_Click(object sender, EventArgs e)
        {
            textBox13.Text = "";
        }

        private void textBox12_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";
        }

        private void txttarihh_Click(object sender, EventArgs e)
        {
            txttarihh.Text = "";
        }

        private void txtnot_Click(object sender, EventArgs e)
        {
            txtnot.Text = "";
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
        }
    }
}

      
    
    


