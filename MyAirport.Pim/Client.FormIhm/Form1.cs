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
			BagageDefinition bagage = MyAirport.Pim.Model.Factory.Model.GetBagage(this.tbCodeIata.Text);
			if (null != bagage) {
				// Fetch value and put into fields
				this.tbClasseBag.Text = bagage.ClasseBagage.ToString();
				this.tbCodeIata.Text = bagage.CodeIata;
				this.tbCompagnie.Text = bagage.Compagnie;
				this.cbContinuation.Checked = bagage.Continuation;
				this.tbItineraire.Text = bagage.Itineraire;
				this.tbJourExploitation.Text = bagage.JourExploitation.ToString();
				this.tbLigne.Text = bagage.Ligne.ToString();
				this.tbAlpha.Text = bagage.LigneAlpha.ToString();
				this.cbRush.Checked = bagage.Rush;

				setOnReadOnlyFields();

				// Bagage found: impossible de create a new one, so disable Créer button
				this.createButton.Enabled = false;
			} else {
				setOnWriteFields();
				this.textBox1.ReadOnly = true;
				this.createButton.Enabled = true;
			}
		}

		// Lock fields into read-only state
		private void setOnReadOnlyFields() {
			this.textBox1.ReadOnly = true;
			this.tbClasseBag.ReadOnly = true;
			this.tbCodeIata.ReadOnly = true;
			this.tbCompagnie.ReadOnly = true;
			this.cbContinuation.Enabled = false;
			this.tbItineraire.ReadOnly = true;
			this.tbJourExploitation.ReadOnly = true;
			this.tbLigne.ReadOnly = true;
			this.tbAlpha.ReadOnly = true;
			this.cbRush.Enabled = false;
		}
		private void setOnWriteFields() {
			this.textBox1.ReadOnly = false;
			this.tbClasseBag.ReadOnly = false;
			this.tbCodeIata.ReadOnly = false;
			this.tbCompagnie.ReadOnly = false;
			this.cbContinuation.Enabled = true;
			this.tbItineraire.ReadOnly = false;
			this.tbJourExploitation.ReadOnly = false;
			this.tbLigne.ReadOnly = false;
			this.tbAlpha.ReadOnly = false;
			this.cbRush.Enabled = true;
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
