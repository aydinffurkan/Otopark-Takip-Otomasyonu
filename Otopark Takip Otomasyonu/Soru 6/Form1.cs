using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Soru_6
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AraçBilgileriForm f1 = new AraçBilgileriForm();//Formlar arası geçiş işe araçbilgileri fomuna geçişi yaptım
            f1.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AraçYerleri f2 = new AraçYerleri();//araç yerlerinin gösterildiği forma geçiş yaptırdım
            f2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //çıkış butonu
            this.Close();// formu sonlandırdım.
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Dosya kaydet butonu
            string dosya_yolu = @".\aracbilgileri.txt";// bilgilerin kaydedileceği dosyanın ismi ni tanımladım
            FileStream dosya = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter yaz = new StreamWriter(dosya);

            // bu for döngüsü sayesinde girilen bilgileri dosyaya yazdırdım.
            for(int i=0;i<20;i++)
            {
                if(AraçBilgileriForm.id[i]!=0)//id de bir değer varsa koşula soktum
                {
                    //dizi içindeki elamanları dosyaya yazdırdım
                    yaz.Write(AraçBilgileriForm.id[i] + "#");
                    yaz.Write(AraçBilgileriForm.tc[i] + "#");
                    yaz.Write(AraçBilgileriForm.ad[i] + "#");
                    yaz.Write(AraçBilgileriForm.soyad[i] + "#");
                    yaz.Write(AraçBilgileriForm.cep[i] + "#");
                    yaz.Write(AraçBilgileriForm.plaka[i] + "#");
                    yaz.Write(AraçBilgileriForm.marka[i] + "#");
                    yaz.Write(AraçBilgileriForm.model[i] + "#");
                    yaz.Write(AraçBilgileriForm.renk[i] + "#");
                    yaz.Write(AraçBilgileriForm.aracyerdegis[i] + "#" + "\n");
                }
                
            }
            //dosyayı kapatma metodları
            yaz.Flush();
            yaz.Close();
            dosya.Close();

        }
        // dosyadan okuduğum bilgileri yeni bir dizide tuttum her yerde kullanabilmem için public static kullandım.
        public static int[] yeniid = new int[21];
        public static string[] yenitc = new string[21];
        public static string[] yeniad = new string[21];
        public static string[] yenisoyad = new string[21];
        public static string[] yenicep = new string[21];
        public static string[] yenimarka = new string[21];
        public static string[] yenirenk = new string[21];
        public static string[] yenimodel = new string[21];
        public static string[] yeniaracyerdegis = new string[21];
        public static string[] yeniplaka = new string[21];
        public static int deger = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string[] veribolme = new string[21];
            string dosya_yolu = @".\aracbilgileri.txt";
            FileStream dosya = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read); 
             //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
             //2.parametre dosyanın açılacağını,
             //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.

            StreamReader yaz = new StreamReader(dosya); //Okuma işlemi için bir StreamReader nesnesi oluşturdum.

            string veri = yaz.ReadLine();

            while (veri != null)// veri bitene kadar
            {
                veribolme = veri.Split('#');// # la karşılaştığında parçalasın ve her iki # arasını ilgili diziye atılmasını sağladım
                yeniid[deger] = Convert.ToInt32(veribolme[0]);
                yenitc[deger] = veribolme[1];
                yeniad[deger] = veribolme[2];
                yenisoyad[deger]= veribolme[3]; 
                yenicep[deger]= veribolme[4];
                yeniplaka[deger]= veribolme[5];
                yenimarka[deger] = veribolme[6];
                yenimodel[deger]= veribolme[7];
                yenirenk[deger] = veribolme[8];
                yeniaracyerdegis[deger]= veribolme[9];
                veri = yaz.ReadLine();
                deger++;//değer sayacını 1 arttırım bu sayde dosyadaki elemanı bir sonraki dizi elamanına yazdırdım
            }
            AraçBilgileriForm.dizideger = deger;//formlar arası iletişim ile burdaki deger sayacımı dizideger sayacına eşitledim.
            


            dosya.Close();//dosyayı kapattım
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
