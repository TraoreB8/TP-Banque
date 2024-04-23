using banqueV2.Controleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banqueV2bdd
{
    public partial class Form1 : Form
    {
        Mgr monManager;
        List<Compte> lescomptes = new List<Compte>();
        List<Client> leclient = new List<Client>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBanque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
