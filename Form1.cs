namespace HasanProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yemekListesi;
            StreamReader yemekOku = new StreamReader(@"C:\Users\Hasan Yýldýz\Desktop\Yemek Proje\YemekListesi.txt.txt");
            yemekListesi = yemekOku.ReadToEnd();
            yemekOku.Close();

            textBox1.Text = yemekListesi;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string musteriListesi;
            StreamReader musteriOku = new StreamReader(@"C:\Users\Hasan Yýldýz\Desktop\Yemek Proje\MusteriListesi.txt.txt");
            musteriListesi = musteriOku.ReadToEnd();
            musteriOku.Close();

            textBox1.Text = musteriListesi;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string asciListesi;
            StreamReader asciOku = new StreamReader(@"C:\Users\Hasan Yýldýz\Desktop\Yemek Proje\AsciListesi.txt.txt");
            asciListesi = asciOku.ReadToEnd();
            asciOku.Close();

            textBox1.Text = asciListesi;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numara;
            string[] yemekler;
            string[] yemekBilgisi;
            Random sayi = new Random();
            numara=sayi.Next(1, 11);

            StreamReader gununYemegi = new StreamReader(@"C:\Users\Hasan Yýldýz\Desktop\Yemek Proje\GununYemegi.txt.txt");
            yemekler = gununYemegi.ReadToEnd().Split("\n");
            gununYemegi.Close();

            foreach (var yemek in yemekler)
            {
                if (yemek=="")
                {
                    break;
                }
                yemekBilgisi=yemek.Split("#");
                if (numara.ToString()==yemekBilgisi[0])
                {
                    textBox1.Text = yemekBilgisi[1];
                }
            }

        }
    }
}