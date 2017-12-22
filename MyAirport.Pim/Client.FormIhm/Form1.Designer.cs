namespace Client.FormIhm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.insertButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.cbRush = new System.Windows.Forms.CheckBox();
			this.tbAlpha = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tbLigne = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbJourExploitation = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbItineraire = new System.Windows.Forms.TextBox();
			this.cbContinuation = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbCompagnie = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbCodeIata = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbClasseBag = new System.Windows.Forms.TextBox();
			this.createButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(435, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(50, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.insertButton);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(497, 87);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Recherche";
			// 
			// insertButton
			// 
			this.insertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.insertButton.Location = new System.Drawing.Point(435, 53);
			this.insertButton.Name = "insertButton";
			this.insertButton.Size = new System.Drawing.Size(50, 23);
			this.insertButton.TabIndex = 3;
			this.insertButton.Text = "Insert";
			this.insertButton.UseVisualStyleBackColor = true;
			this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "CodeIata :";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(74, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(355, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "401640989800";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.createButton);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.cbRush);
			this.groupBox2.Controls.Add(this.tbAlpha);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.tbLigne);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.tbJourExploitation);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.tbItineraire);
			this.groupBox2.Controls.Add(this.cbContinuation);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.tbCompagnie);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.tbCodeIata);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.tbClasseBag);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 87);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(497, 253);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Résultat";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(371, 209);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(105, 27);
			this.button4.TabIndex = 18;
			this.button4.Text = "Nouveau bagage";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(400, 23);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(76, 27);
			this.button3.TabIndex = 17;
			this.button3.Text = "Rechercher";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(133, 224);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(68, 20);
			this.textBox2.TabIndex = 16;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// button2
			// 
			this.button2.AccessibleName = "";
			this.button2.Location = new System.Drawing.Point(12, 213);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(53, 23);
			this.button2.TabIndex = 15;
			this.button2.Text = "GetById";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// cbRush
			// 
			this.cbRush.AutoSize = true;
			this.cbRush.Location = new System.Drawing.Point(111, 202);
			this.cbRush.Name = "cbRush";
			this.cbRush.Size = new System.Drawing.Size(51, 17);
			this.cbRush.TabIndex = 14;
			this.cbRush.Text = "Rush";
			this.cbRush.UseVisualStyleBackColor = true;
			// 
			// tbAlpha
			// 
			this.tbAlpha.Location = new System.Drawing.Point(174, 176);
			this.tbAlpha.Name = "tbAlpha";
			this.tbAlpha.Size = new System.Drawing.Size(37, 20);
			this.tbAlpha.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 179);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(39, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Ligne :";
			// 
			// tbLigne
			// 
			this.tbLigne.Location = new System.Drawing.Point(111, 176);
			this.tbLigne.Name = "tbLigne";
			this.tbLigne.Size = new System.Drawing.Size(57, 20);
			this.tbLigne.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 153);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Jour d\'exploitation :";
			// 
			// tbJourExploitation
			// 
			this.tbJourExploitation.Location = new System.Drawing.Point(111, 150);
			this.tbJourExploitation.Name = "tbJourExploitation";
			this.tbJourExploitation.Size = new System.Drawing.Size(100, 20);
			this.tbJourExploitation.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 127);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Itinéraire :";
			// 
			// tbItineraire
			// 
			this.tbItineraire.Location = new System.Drawing.Point(111, 124);
			this.tbItineraire.Name = "tbItineraire";
			this.tbItineraire.Size = new System.Drawing.Size(100, 20);
			this.tbItineraire.TabIndex = 7;
			// 
			// cbContinuation
			// 
			this.cbContinuation.AutoSize = true;
			this.cbContinuation.Location = new System.Drawing.Point(111, 101);
			this.cbContinuation.Name = "cbContinuation";
			this.cbContinuation.Size = new System.Drawing.Size(85, 17);
			this.cbContinuation.TabIndex = 6;
			this.cbContinuation.Text = "Continuation";
			this.cbContinuation.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Compagnie :";
			// 
			// tbCompagnie
			// 
			this.tbCompagnie.Location = new System.Drawing.Point(111, 75);
			this.tbCompagnie.Name = "tbCompagnie";
			this.tbCompagnie.Size = new System.Drawing.Size(100, 20);
			this.tbCompagnie.TabIndex = 4;
			this.tbCompagnie.TextChanged += new System.EventHandler(this.tbCompagnie_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Code Iata :";
			// 
			// tbCodeIata
			// 
			this.tbCodeIata.Location = new System.Drawing.Point(111, 49);
			this.tbCodeIata.Name = "tbCodeIata";
			this.tbCodeIata.Size = new System.Drawing.Size(100, 20);
			this.tbCodeIata.TabIndex = 2;
			this.tbCodeIata.TextChanged += new System.EventHandler(this.tbCodeIata_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Classe bagage :";
			// 
			// tbClasseBag
			// 
			this.tbClasseBag.Location = new System.Drawing.Point(111, 23);
			this.tbClasseBag.Name = "tbClasseBag";
			this.tbClasseBag.Size = new System.Drawing.Size(100, 20);
			this.tbClasseBag.TabIndex = 0;
			this.tbClasseBag.TextChanged += new System.EventHandler(this.tbClasseBag_TextChanged);
			// 
			// createButton
			// 
			this.createButton.Location = new System.Drawing.Point(388, 127);
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(75, 23);
			this.createButton.TabIndex = 19;
			this.createButton.Text = "Créer";
			this.createButton.UseVisualStyleBackColor = true;
			this.createButton.Click += new System.EventHandler(this.createButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 340);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbClasseBag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCompagnie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodeIata;
        private System.Windows.Forms.CheckBox cbContinuation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbItineraire;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLigne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbJourExploitation;
        private System.Windows.Forms.TextBox tbAlpha;
        private System.Windows.Forms.CheckBox cbRush;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button createButton;
	}
}

