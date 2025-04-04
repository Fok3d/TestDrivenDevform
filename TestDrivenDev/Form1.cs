using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDrivenDev
{

    

    public partial class Form1 : Form
    {
       

        private Hrac hrac;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnVytvorit_Click(object sender, EventArgs e)
        {
            string jmeno = txtJmeno.Text;
            
            string specializace = cmbSpecializace.SelectedItem?.ToString() ?? "Kouzelník";
            int x = Convert.ToInt32(txtPoziceX.Text);
            int y = Convert.ToInt32(txtPoziceY.Text);
            hrac = new Hrac(jmeno, specializace);
            AktualizovatInfo(x,y);
        }

        private void btnZmenPozici_Click(object sender, EventArgs e)
        {
            if (hrac != null && int.TryParse(txtPoziceX.Text, out int x) && int.TryParse(txtPoziceY.Text, out int y))
            {
                hrac.ZmenaPozice(x, y);
                AktualizovatInfo(x,y);
            }
        }

       

        private void AktualizovatInfo(int x,int y)
        {
            if (hrac != null)
            {
                lblInfo.Text = hrac.ToString();
                lblPozice.Text = $"Souradnice x:{x} Souradnice y:{y}";
                lblJmeno.Text = "Jméno postavy: " +txtJmeno.Text.ToString();
                lblSpecializace.Text= "Specializace: " + cmbSpecializace.Text.ToString();
                

            }
        }

        private void btnPridatXP_Click_1(object sender, EventArgs e)
        {
           
            int x = Convert.ToInt32(txtPoziceX.Text);
            int y = Convert.ToInt32(txtPoziceY.Text);
            if (hrac != null)
            {
                hrac.level += 1;
                AktualizovatInfo(x, y);
            }
        }
    }
}
