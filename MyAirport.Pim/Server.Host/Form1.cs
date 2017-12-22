using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Host
{
    public partial class Form1 : Form
    {
        private ServiceHost host = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(Server.ServiceBagage.ServiceBagage));
            host.Closed += host_State;
            host.Closing += host_State;
            host.Faulted += host_State;
            host.Opened += host_State;
            host.Opening += host_State;

            this.textBox.Text = this.host.State.ToString();
            this.listBox.Items.Clear();
            this.listBox.Items.Add("Création du service.");
        }

        void host_State(object sender, EventArgs e)
        {
            this.textBox.Text = this.host.State.ToString();
            this.listBox.Items.Add("Changement d'état : " + this.host.State.ToString());
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            host.Open();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            host.Close();
        }
    }
}
