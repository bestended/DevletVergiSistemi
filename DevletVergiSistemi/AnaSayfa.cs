using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevletVergiSistemi
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        

       

        private void rbtn_vergiler_Click(object sender, EventArgs e)
        {
            Vergi vergiEkrani = new Vergi();
            vergiEkrani.Show();
            this.Hide();
            


        }

        private void rbtn_bakanliklar_Click(object sender, EventArgs e)
        {
            Bakanliklarim bakanlikEkran = new Bakanliklarim();
            bakanlikEkran.Show();
            this.Hide();




        }

        private void rbtn_vatandas_Click(object sender, EventArgs e)
        {
            Vatandaslarim vatandas = new Vatandaslarim();
            vatandas.Show();
            this.Hide();



        }

      

        private void rbtn_borclar_Click(object sender, EventArgs e)
        {
            Borclarim borc = new Borclarim();
            borc.Show();

            this.Hide();


        }
    }
}
