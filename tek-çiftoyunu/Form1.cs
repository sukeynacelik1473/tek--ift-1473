using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tek_çiftoyunu
{
    public partial class Form1 : Form
    {
        int sayi,puan;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            //rasgele sayı kutuphanesı (sınıf)

            Random random = new Random();

            int sayi = random.Next(0, 100);//0.100 arasında  rasgele tam sayı uret
            lblSayı.Text= sayi.ToString();
            btnCift.Enabled=true;
            btnTek.Enabled=true;
        }

        private void btnCift_Click(object sender, EventArgs e)
        {
            if( sayi % 2 == 0)
            {
                puan += 5;
            }
            else
            {
                puan -= 3;
            }
            lblPuan.Text=puan.ToString();   
            btnCift.Enabled=true;
            btnTek.Enabled=true;
        }

        private void lblPuan_Click(object sender, EventArgs e)
        {

        }

        private void btnTek_Click(object sender, EventArgs e)
        {
            if ( sayi % 2 != 0)
            {
                puan += 5;
            }
            else
            {
                puan -= 3;
            }
            lblPuan.Text =puan.ToString();
            btnCift.Enabled =false;
            btnTek.Enabled =false;
        }
    }
}
