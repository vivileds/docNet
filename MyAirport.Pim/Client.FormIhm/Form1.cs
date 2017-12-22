using System;
using MyAirport.Pim.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.FormIhm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Appel via IdBagage
            var bagage1 = MyAirport.Pim.Model.Factory.Model.GetBagage(24389425);
            //Appel via codeIata
            var bagage2 = MyAirport.Pim.Model.Factory.Model.GetBagage(this.textBox1.Text);
            //Appel via codeIata mais avec deux valeur trouvées
            var bagage3 = MyAirport.Pim.Model.Factory.Model.GetBagage("007410201500");
            
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            BagageDefinition bag = new BagageDefinition();
            bag.Compagnie = this.tbCompagnie.Text;
            bag.Ligne = Convert.ToInt32(this.tbLigne.Text);
            bag.JourExploitation = Convert.ToInt32(this.tbJourExploitation.Text);
            bag.Itineraire = this.tbItineraire.Text;
            bag.ClasseBagage = Convert.ToChar(this.tbClasseBag.Text);
            bag.CodeIata = this.tbCodeIata.Text;
            bag.Continuation = this.cbContinuation.Checked;
            bag.Rush = this.cbRush.Checked;

            MyAirport.Pim.Model.Factory.Model.CreateBagage(bag);
        }

        private void tbClasseBag_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyAirport.Pim.Model.Factory.Model.GetBagage(this.textBox2.Text);
        }

        private void tbCodeIata_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCompagnie_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
			MyAirport.Pim.Model.Factory.Model.GetBagage(this.tbCodeIata.Text);
		}

		// TODO: Nouveau bagage button 
		private void button4_Click(object sender, EventArgs e) {
			// Should reset all fields of the UI

			// TextBox Classe bagage
			this.tbClasseBag.Text = "";
			// TextBox Code Iata
			this.tbCodeIata.Text = "";
			// TextBox Compagnie
			this.tbCompagnie.Text = "";
			// Checkbox Continuation
			this.cbContinuation.Checked = false;
			// TextBox Itinéraire
			this.tbItineraire.Text = "";
			// TextBox Jour d'exploitation
			this.tbJourExploitation.Text = "";
			// TextBox Ligne
			this.tbLigne.Text = "";
			this.tbAlpha.Text = "";
			// Checkbox Rush
			this.cbRush.Checked = false;
		}
	}
}
