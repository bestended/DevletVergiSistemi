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
    public partial class BorcDetayRapor : Form
    {
        VergiSistemiEntities con = new VergiSistemiEntities();

        public BorcDetayRapor()
        {
            InitializeComponent();
        }

        private void btn_secilenIkiTarih_Click(object sender, EventArgs e)
        {

            dgw_borcRapor.DataSource = con.secilenIkiTarihim(Convert.ToDateTime(dtp_baslangicTarihi.Text), Convert.ToDateTime(dtp_bitisTarihi.Text));
        }

      
    }
}
