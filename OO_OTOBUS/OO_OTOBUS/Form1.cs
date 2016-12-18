using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_OTOBUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Musteri> MusteriList = new List<Musteri>();
        Musteri musteri = new Musteri();



        private void button1_Click(object sender, EventArgs e)
        {
            musteri.Adi = txtboxAdSoyad.Text;
            musteri.Cinsiyet = txtboxCinsiyet.Text;
            musteri.OtobusTuru = txtboxOtobusTuru.Text;
            MusteriList.Add(musteri);
            listBox1.Items.Add(musteri);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("İsim\t"+ "Cinsiyet\t" + "Otobüs Türü");
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Devam Etmek istiyormusunuz ?","Onay Ekranı",MessageBoxButtons.YesNo);

            if (result==DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
