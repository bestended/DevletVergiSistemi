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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void btn_vatandasRapor_Click(object sender, EventArgs e)
        {
            VatandasRaporDetay vatandasRapor = new VatandasRaporDetay();
            vatandasRapor.Show();
            this.Hide();
        }

        private void btn_borcRapor_Click(object sender, EventArgs e)
        {
            BorcDetayRapor borcRapor = new BorcDetayRapor();
            borcRapor.Show();
            this.Hide();
        }

        private void btn_vergiRapor_Click(object sender, EventArgs e)
        {
            VergiRaporDetay vergiDetay = new VergiRaporDetay();
            vergiDetay.Show();
            this.Hide();
        }

        private void btn_bakanlikRapor_Click(object sender, EventArgs e)
        {
            BakanlikRapor raporBakanlik = new BakanlikRapor();
            raporBakanlik.Show();
            this.Hide();
        }

        private void btn_önceki_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa = new AnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
