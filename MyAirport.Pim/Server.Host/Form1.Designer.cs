namespace Server.Host
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.State = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonClose);
            this.groupBox.Controls.Add(this.textBox);
            this.groupBox.Controls.Add(this.buttonCreate);
            this.groupBox.Controls.Add(this.State);
            this.groupBox.Controls.Add(this.buttonOpen);
            this.groupBox.Location = new System.Drawing.Point(2, 1);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(362, 103);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "groupBox";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(82, 27);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 3;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(10, 71);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(44, 30);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(32, 13);
            this.State.TabIndex = 1;
            this.State.Text = "State";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(140, 71);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(2, 106);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(362, 238);
            this.listBox.TabIndex = 4;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(275, 71);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 351);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonClose;
    }
}

