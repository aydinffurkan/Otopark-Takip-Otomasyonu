using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_6
{
    public partial class AraçBilgileriForm : Form
    {
        AraçYerleri f2 = new AraçYerleri(); // AraçYerleri formunu AraçBilgileriForm unda kullanabilmek için bu metodu kullandım ve f2
                                            // adlı değişkende bu bilgileri tuttum.
       
        public void konumdegistirme()
        {
            #region kodun okunurluğunu arttırmak amacıyla AraçYerleri formundaki araçların lokasyonuna plaka ismini ve yeşil rengini kırmızı yapmak amacıyla kullandım 

            for (int i = 0; i < 21; i++)
            {
                if (f2.a1.Text == aracyerdegis[i])//f2 değişkenine atadığım AraçYerleri formunda a1 lokasyonuna  aracyerdegis[] dizindeki değerle eşit olup olmadığını kontrol ettim
                {
                    f2.a1.Text = plaka[i];// kontrol doğru olduysa bloğa girdi ve a1 butonunun textini plaka dizisinin i. indisindeki değeri atadı
                    f2.a1.BackColor = Color.Red;//Atama tamamlandığında a1 butonunun rengini kırmızı yaptırdım.
                }
                // Bundan sonraki tüm bloklarda aynı işlemi tekrarlattım a2 textiyle aracyerdegis dizisinin elamanı eşit olduğunda bloğa girdi ve gerekli atamaları yaptırdım.
                else if (f2.a2.Text == aracyerdegis[i])
                {
                    f2.a2.Text = plaka[i];
                    f2.a2.BackColor = Color.Red;

                }
                else if (f2.a3.Text == aracyerdegis[i])
                {
                    f2.a3.Text = plaka[i];
                    f2.a3.BackColor = Color.Red;

                }
                else if (f2.a4.Text == aracyerdegis[i])
                {
                    f2.a4.Text = plaka[i];
                    f2.a4.BackColor = Color.Red;

                }
                else if (f2.a5.Text == aracyerdegis[i])
                {
                    f2.a5.Text = plaka[i];
                    f2.a5.BackColor = Color.Red;

                }

                else if (f2.b1.Text == aracyerdegis[i])
                {
                    f2.b1.Text = plaka[i];
                    f2.b1.BackColor = Color.Red;

                }
                else if (f2.b2.Text == aracyerdegis[i])
                {
                    f2.b2.Text = plaka[i];
                    f2.b2.BackColor = Color.Red;

                }
                else if (f2.b3.Text == aracyerdegis[i])
                {
                    f2.b3.Text = plaka[i];
                    f2.b3.BackColor = Color.Red;

                }
                else if (f2.b4.Text == aracyerdegis[i])
                {
                    f2.b4.Text = plaka[i];
                    f2.b4.BackColor = Color.Red;

                }
                else if (f2.b5.Text == aracyerdegis[i])
                {
                    f2.b5.Text = plaka[i];
                    f2.b5.BackColor = Color.Red;

                }
                else if (f2.c1.Text == aracyerdegis[i])
                {
                    f2.c1.Text = plaka[i];
                    f2.c1.BackColor = Color.Red;

                }
                else if (f2.c2.Text == aracyerdegis[i])
                {
                    f2.c2.Text = plaka[i];
                    f2.c2.BackColor = Color.Red;

                }
                else if (f2.c3.Text == aracyerdegis[i])
                {
                    f2.c3.Text = plaka[i];
                    f2.c3.BackColor = Color.Red;

                }
                else if (f2.c4.Text == aracyerdegis[i])
                {
                    f2.c4.Text = plaka[i];
                    f2.c4.BackColor = Color.Red;

                }
                else if (f2.c5.Text == aracyerdegis[i])
                {
                    f2.c5.Text = plaka[i];
                    f2.c5.BackColor = Color.Red;

                }
                else if (f2.d1.Text == aracyerdegis[i])
                {
                    f2.d1.Text = plaka[i];
                    f2.d1.BackColor = Color.Red;

                }
                else if (f2.d2.Text == aracyerdegis[i])
                {
                    f2.d2.Text = plaka[i];
                    f2.d2.BackColor = Color.Red;

                }
                else if (f2.d3.Text == aracyerdegis[i])
                {
                    f2.d3.Text = plaka[i];
                    f2.d3.BackColor = Color.Red;

                }
                else if (f2.d4.Text == aracyerdegis[i])
                {
                    f2.d4.Text = plaka[i];
                    f2.d4.BackColor = Color.Red;

                }
                else if (f2.d5.Text == aracyerdegis[i])
                {
                    f2.d5.Text = plaka[i];
                    f2.d5.BackColor = Color.Red;

                }
            }
            #endregion Kodun okunurluğunu arttırmak amacıyla 
        }

        public AraçBilgileriForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            f2.ShowDialog();// AraçYerleri formuna geçiş yapılabilmesi için kullandım. Global olarak atadığım f2 değişkeni sayesinde.
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f3 = new Form1(); // Formlar arası geçiş için bu metodu kullandım. Button9 a bastığı takdirde tekrardan form1 e yani ana menüye geçişi sağladım.
            f3.ShowDialog();
        }

        private void AraçBilgileriForm_Load(object sender, EventArgs e)
        {
            //dosyadan okuduğum yeni bilgileri önceki diziye atma işlemi gerçekleştirdim
            id = Form1.yeniid;
            tc = Form1.yenitc;
            ad = Form1.yeniad;
            soyad = Form1.yenisoyad;
            cep = Form1.yenicep;
            plaka = Form1.yeniplaka;
            marka = Form1.yenimarka;
            model = Form1.yenimodel;
            renk = Form1.yenirenk;
            aracyerdegis = Form1.yeniaracyerdegis;


        }
        // kullanıcı bilgilerini tutabilmek için gerekli dizileri tanımladım. Ve tüm formlarda kullanabilmek için public static metodunu kullandım
        public static string[] dizi1 = new string[21];
        public static string [] plaka = new string[21];
        public static string[] aracyerdegis = new string[21];
        public static  int dizideger=Form1.deger;
        public static string[] tc = new string[21];
        public static string[] ad = new string[21];
        public static string[] soyad = new string[21];
        public static string[] cep = new string[21];
        public static string[] marka = new string[21];
        public static string[] model = new string[21];
        public static string[] renk = new string[21];
        public static int[] id = new int[21];

        private void button6_Click(object sender, EventArgs e)
        {
            // bu buton araç girişi butonudur
            if (dizideger < 20)//20 tane eleman olacağıdan dizi değerinin 20 den küçük olduğunda koşula girmesini sağladım
            {
                //Textboxa kullanıcı tarafından girilen bilgileri ilgili diziye atadım. 
                id[dizideger] = dizideger + 1;
                tc[dizideger] = textBox1.Text;
                ad[dizideger] = textBox2.Text;
                soyad[dizideger] = textBox4.Text;
                cep[dizideger] = textBox3.Text;
                marka[dizideger] = textBox7.Text;
                model[dizideger] = textBox5.Text;
                renk[dizideger] = textBox6.Text;
                plaka[dizideger] = textBox8.Text;
                aracyerdegis[dizideger] = comboBox1.Text;

                konumdegistirme();// konum değiştirme butonunu çağırdım ve bu sayede araçyerleri formundaki ilgili lokasyona ilgili bilgileri atadım ve rengini kırmızı yaptım

                
                dizideger++;// dizi değerini bir sonra ki indise farklı bilgileri atamak için her seferinde bir kez arttırdım
            }
            else
            {
                MessageBox.Show("Özür Dileriz.Parkımızda yer yok. İlginiz için teşekkür ederiz.");// 20 den fazla araç girişi olduğunda kullanıcıya uyarı mesajı yansıttım
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // bu butonda tahsil et butonudur. Gerekli zaman dilimlerindeki bloğa girerek gerekli matematiksel işlemleri yaptırdım.
            int tahsilet = 0;//değişkenlerin çalışabilmesi için ilk değerlerini 0 atadım.
            int ictemizlik = 0;
            int distemizlik = 0;
            int sonuc = 0;// hesaplanan miktarı sonuc değişkeninde tuttum.

            // Combobox taki girilen bilgiye göre ilgili bloğa girilmesini sağladım.
            if (comboBox2.Text == "10 dk")
            {
                tahsilet = 0;
            }
            else if (comboBox2.Text == "30 dk")
            {
                tahsilet = 2;
            }
            else if (comboBox2.Text == "1 saat")
            {
                tahsilet = 3;
            }
            else if (comboBox2.Text == "3 saat")
            {
                tahsilet = 5;
            }
            else if (comboBox2.Text == "5 saat")
            {
                tahsilet = 10;
            }
            else if (comboBox2.Text == "10 saat")
            {
                tahsilet = 15;
            }
            else if (comboBox2.Text == "1 gün")
            {
                tahsilet = 25;
            }
            // ListBoxta ki tercihlerde iç temizlik veya dış temizlik ten birisi seçildiğinde değişkenlere seçilen temizlik türüne göre hizmetin ücretini atadım.
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked) 
            {
                ictemizlik = 10;
            }
            else
            {
                ictemizlik = 0;
            }

            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                distemizlik = 10;
            }
            else
            {
                distemizlik = 0;
            }
            sonuc = tahsilet + ictemizlik + distemizlik;//Listboxtaki tercih ve süreyi göz önüne alarak hepsini topladımve hizmetin ücretini sonuc değişkeninde tuttum.
            MessageBox.Show(textBox8.Text + " " + sonuc + " " + "TL Ödemeniz için teşekkür ederiz tekrar bekleriz.");// Ekrana uyarı mesajı verdim. Ödemesi gereken ve hesaplanan ücreti kullanıcıya sundum.

        }
        
        int sayac = 0;
        int olduğusayfa = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            for (int k = 0; id[k] != 0; k++)
            {
                sayac = 0;// her seferinde sayacı sıfırladım.
                sayac = id[k];// sayaca toplam kaç sayfa varsa onun değerini atadım

            }
            if (olduğusayfa > 1)// geri tuşunun negatife düşmemesi için koşulla 1 den büyük olmasını kontrol ettirdim.
            {
                olduğusayfa--;// araçbilgileriformundaki saydayı geri tuşuna basıldığında önceki bilgileri getirmesi için bir kez azalttım
                textBox9.Text = Convert.ToString(olduğusayfa) + "/" + sayac;// textboxa ilk olduğusayfayı daha sonra sayacı yani toplam kaç tane sayfa olduğunu belirten
                // değeri yazdırdım aralarına / işaretini koydum.

            }
            // elamanları sayfa da ileri geri tuşlarına bastığında tekrar textboxlara getirmek için kullandım.
            for(int ö=0;ö<21;ö++)
            {
                if(id[ö]==olduğusayfa)//o anki id dizisi olduğu sayfaya eşitse yani aynı sayfalardaysa o sayfaya ait bilgileri getirebilmesi için koşula soktum
                {
                    //textboxlara elemanları tekrardan olduğusayfadaki indis numarasına göre getirttim
                    textBox1.Text= tc[ö]  ;
                    textBox2.Text= ad[ö]  ;
                    textBox4.Text= soyad[ö] ;
                    textBox3.Text=cep[ö]  ;
                    textBox7.Text= marka[ö]  ;
                    textBox5.Text=model[ö] ;
                    textBox6.Text=renk[ö] ;

                    textBox8.Text= plaka[ö]  ;
                    comboBox1.Text= aracyerdegis[ö]  ;

                }
            }
        }
        //bu buton ileri tuşudur
        private void button4_Click(object sender, EventArgs e)
        {

            for (int k = 0; id[k] != 0; k++)
            {
                sayac = 0;
                sayac = id[k];

            }
            if (olduğusayfa < sayac)
            {
                olduğusayfa++;//olduğusayfa sayacı ileri tuşu olduğu için her seferinde 1 kez arttırdım
                textBox9.Text = Convert.ToString(olduğusayfa) + "/" + sayac;// textboxa ilk olduğusayfayı daha sonra sayacı yani toplam kaç tane sayfa olduğunu belirten
                // değeri yazdırdım aralarına / işaretini koydum.


            }
            // elamanları sayfa da ileri geri tuşlarına bastığında tekrar textboxlara getirmek için kullandım.

            for (int ö = 0; ö < 21; ö++)
            {
                if (id[ö] == olduğusayfa)//o anki id dizisi olduğu sayfaya eşitse yani aynı sayfalardaysa o sayfaya ait bilgileri getirebilmesi için koşula soktum
                {
                    //textboxlara elemanları tekrardan olduğusayfadaki indis numarasına göre getirttim

                    textBox1.Text = tc[ö];
                    textBox2.Text = ad[ö];
                    textBox4.Text = soyad[ö];
                    textBox3.Text = cep[ö];
                    textBox7.Text = marka[ö];
                    textBox5.Text = model[ö];
                    textBox6.Text = renk[ö];

                    textBox8.Text = plaka[ö];
                    comboBox1.Text = aracyerdegis[ö];

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //en baştaki elamanları getirmek için kullandığım buton
            // 0. inisteki bilgiler ilk kayıtta tutulduğu için bu butona basılfığında bu bilgileri gerekli textboxlara tekrardan yazdırdım
            textBox9.Text = "1" + "/" + sayac;//sayac toplam kayıtlı sayfayı tutuyor.
            textBox1.Text = tc[0];
            textBox2.Text = ad[0];
            textBox4.Text = soyad[0];
            textBox3.Text = cep[0];
            textBox7.Text = marka[0];
            textBox5.Text = model[0];
            textBox6.Text = renk[0];

            textBox8.Text = plaka[0];
            comboBox1.Text = aracyerdegis[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int k = 0; id[k] != 0; k++)//SAYFA BİTENE KADAR DÖNGÜYÜ DEVAM ETTİRDİM.
            {
                sayac = 0;
                sayac = id[k];
            }
            textBox9.Text = Convert.ToString(sayac) + "/" + sayac;
            if(sayac!=0)// koşula sokabilmem için sayacın 0 dan farklı olduğu durumlarda koşula girmesini sağladım
            {
                // en son kayıt edilen bilgileri ekrana yazdırdım.
                textBox1.Text = tc[sayac - 1];
                textBox2.Text = ad[sayac - 1];
                textBox4.Text = soyad[sayac - 1];
                textBox3.Text = cep[sayac - 1];
                textBox7.Text = marka[sayac - 1];
                textBox5.Text = model[sayac - 1];
                textBox6.Text = renk[sayac - 1];

                textBox8.Text = plaka[sayac - 1];
                comboBox1.Text = aracyerdegis[sayac - 1];
            }
           

        }
        private void button7_Click(object sender, EventArgs e)
        {


            

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            // kullanıcının hangi sayfa da olduğunu belirttiğim textbox
        }
    }
}