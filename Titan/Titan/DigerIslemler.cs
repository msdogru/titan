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
    public partial class DigerIslemler : Form
    {
        private Form[] GelinenTablo;

        public DigerIslemler()
        {
            InitializeComponent();
        }

        public DigerIslemler(Form[] gelinentablo)
        {
            this.GelinenTablo = new Form[20];
            for (int i = 0; i < 20; i++)
            {
                this.GelinenTablo[i] = gelinentablo[i];
            }

            InitializeComponent();
        }

        
        private void DigerIslemler_Load(object sender, EventArgs e)
        {

        }

        private void BTGeri_Click(object sender, EventArgs e)
        {
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() - 1);
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()].Show();
            this.SetVisibleCore(false);
        }

        private void BTAracİşlemleri_Click(object sender, EventArgs e)
        {
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            AracBilgisiDuzenle gecmisServisGoruntule = new AracBilgisiDuzenle(GelinenTablo);
            this.SetVisibleCore(false);
            gecmisServisGoruntule.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            AracıSistemdenSilme AracSilme = new AracıSistemdenSilme(GelinenTablo);
            this.SetVisibleCore(false);
            AracSilme.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            AracınGecmisServisleriniSistemdenKAldırma AracGecmisSilme = new AracınGecmisServisleriniSistemdenKAldırma(GelinenTablo);
            this.SetVisibleCore(false);
            AracGecmisSilme.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            SirketSilme SirketSilme = new SirketSilme(GelinenTablo);
            this.SetVisibleCore(false);
            SirketSilme.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            KullanıcıSilme KullanıcıSilme = new KullanıcıSilme(GelinenTablo);
            this.SetVisibleCore(false);
            KullanıcıSilme.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            KullanıcıBilgisiDuzenle KullanıcıBilgiDüzenle = new KullanıcıBilgisiDuzenle(GelinenTablo);
            this.SetVisibleCore(false);
            KullanıcıBilgiDüzenle.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GelinenTablo[Yönlendirmeler.getgirilenTabloSayısı()] = this;
            Yönlendirmeler.setgirilenTabloSayısı(Yönlendirmeler.getgirilenTabloSayısı() + 1);
            SirketBilgileriDuzenle KullanıcıBilgiDüzenle = new SirketBilgileriDuzenle(GelinenTablo);
            this.SetVisibleCore(false);
            KullanıcıBilgiDüzenle.ShowDialog();
        }
    }
}
