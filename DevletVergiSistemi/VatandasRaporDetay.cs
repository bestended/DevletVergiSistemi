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
    public partial class VatandasRaporDetay : Form
    {
        VergiSistemiEntities con = new VergiSistemiEntities();

        public VatandasRaporDetay()
        {
            InitializeComponent();
        }

        private void btn_adresSorgu_Click(object sender, EventArgs e)
        {

            dgw_vatandasRaporDetay.DataSource = con.adreIli(txt_sehirSorgu.Text);

        }

        private void btn_meslekSorgu_Click(object sender, EventArgs e)
        {
            dgw_vatandasRaporDetay.DataSource = con.meslekSorgu(txt_meslekSorgu.Text);
        }

     

        private void btn_meslekBorcDurumBakanlikAd_Click(object sender, EventArgs e)
        {
            dgw_vatandasRaporDetay.DataSource = con.meslekBorcDurumBakanlikAd();
        }

        private void btn_tcBaslangiciDokuz_Click(object sender, EventArgs e)
        {
            dgw_vatandasRaporDetay.DataSource = con.tcBasDokuzBitBes();
        }

        private void btn_kisiNoTcAdresBorcAdTutar_Click(object sender, EventArgs e)
        {
            dgw_vatandasRaporDetay.DataSource = con.kisiNoTcAdresBorcAdTutar(Convert.ToInt32(txt_kisiNoTcAdresBorcAdTutar.Text));
        }
    }
}
