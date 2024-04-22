using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form5.unite_uygulama_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                MessageBox.Show("kullanıcı adınızı giriniz", "uyarı");
            }
            if(string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("şifre giriniz", "uyarı");
            }
            
        }
    }
}
