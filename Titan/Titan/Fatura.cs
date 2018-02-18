using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titan
{
    public partial class Fatura : Form
    {

        private int ServisId = -1;
        private Form[] GelinenTablo = new Form[20];

        public Fatura()
        {
            InitializeComponent();
        }

        public Fatura(int ServisId, Form[] GelinenTablo)
        {
            InitializeComponent();
            this.ServisId = ServisId;
            this.GelinenTablo = GelinenTablo;
            for (int i = 0; i < Yönlendirmeler.getgirilenTabloSayısı(); i++)
            {
                this.GelinenTablo[i] = GelinenTablo[i];
            }
            InitializeComponent();
        }



        private void Fatura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TitanDataSet.Fatura' table. You can move, or remove it, as needed.
            //this.FaturaTableAdapter.Fill(this.TitanDataSet.Fatura);

            this.reportViewer1.RefreshReport();
        }
    }
}
