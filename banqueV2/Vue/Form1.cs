using banqueV2;
using banqueV2.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestHeritage;

namespace banqueV2
{
    public partial class Form1 : Form
    {
        List<Compte> lstcpt = new List<Compte>();
        Client c1;
        Client c2;
        Client c3;
        Client c4;

        /*Compte compte1;
        Compte compte2;
        Compte compte3;*/


        Courant compte1;
        Courant compte2;
        Epargne compte3;
        Courant compte4;

        private string nameFile = "fichier";
    public Form1()
        {
            InitializeComponent();
        }



        private void crediterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnValider.Enabled = true;
            btnValider.Text = "Créditer";
            lbMontant.Text = "Créditer à : ";
        }

        private void debiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnValider.Enabled = true;
            btnValider.Text = "Débiter";
            lbMontant.Text = "Débiter à : ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnValider.Enabled = false;
            c1 = new Client(1, "Dupont", "Toto", "Creteil");
            c2 = new Client(2, "Abadala", "Momo", "Creteil");
            c3 = new Client(3, "Lucas", "Todd", "Creteil");
            c4 = new Client(4, "Vincent", "Frank", "Creteil");



            compte1 = new Courant(0,10,c1);
            compte2 = new Courant(0, 11, c2);
            compte3 = new Epargne(10);
            compte4 = new Courant(0, 13, c3);

            /*compte1 = new Compte(10, c1);
              compte2 = new Compte(11, c2);
              compte3 = new Compte(12, c3); */

            lstcpt.Add(compte1);
            lstcpt.Add(compte2);
            lstcpt.Add(compte3);    

            Object obj = Serialise.Recup("fichier"); //il va récupérér a partir du file , l'objet qui va être sérialisé

            if (obj != null){ //on va effecter obj dans la liste
                lstcpt = (List<Compte>)obj;

                //après avoir récupérer on met a jour la listebox avec la méthode affiche
            }



            Afficher();
        }


        private void Afficher()
        {

            listBanque.DataSource = null;
            listBanque.DataSource = lstcpt;
            Serialise.Sauve("file", lstcpt);

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Courant c = (Courant)listBanque.SelectedItem;
            if (btnValider.Text == "Créditer")
            {
                c.crediter(Convert.ToDouble(tbSaisie.Text));
            }

            if (btnValider.Text == "Débiter")
            {
                c.débiter(Convert.ToDouble(tbSaisie.Text));

            }
            else if(btnValider.Text == "Découvert")
            {
                try
                {
                    if (c.setdecouvert(Convert.ToDouble(tbSaisie.Text)))
                    {
                        MessageBox.Show("C'est fait");
                    }
                } 
                catch(DecouvertException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Afficher();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compte c = (Compte)listBanque.SelectedItem;
            Client c1 = c.Propriétaire;

            Form2 f1 = new Form2(c1);
            f1.ShowDialog();


        }

        private void découvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnValider.Text = "Découvert";
            lbMontant.Text = "Découvert à : ";
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
