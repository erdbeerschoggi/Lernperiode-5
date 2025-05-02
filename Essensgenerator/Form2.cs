using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smthNew
{
    public partial class Form2 : Form
    {
        public Form2(string gerichtVorschlag)
        {
            InitializeComponent();
            txtAusgabe.Text = gerichtVorschlag; // Gerichtsvorschlag in die TextBox setzen
        }

      
        private void txtAusgabe_TextChanged(object sender, EventArgs e)
        {
            txtAusgabe.ReadOnly = true;
        }

    }
}
