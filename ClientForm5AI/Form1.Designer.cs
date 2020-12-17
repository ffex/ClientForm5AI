
namespace ClientForm5AI
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.btnConnetti = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessaggio = new System.Windows.Forms.TextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.lstMessaggiServ = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Server";
            // 
            // txtIPServer
            // 
            this.txtIPServer.Location = new System.Drawing.Point(84, 18);
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.Size = new System.Drawing.Size(100, 22);
            this.txtIPServer.TabIndex = 1;
            this.txtIPServer.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Porta";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(248, 18);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(100, 22);
            this.txtPorta.TabIndex = 3;
            this.txtPorta.Text = "23000";
            // 
            // btnConnetti
            // 
            this.btnConnetti.Location = new System.Drawing.Point(387, 9);
            this.btnConnetti.Name = "btnConnetti";
            this.btnConnetti.Size = new System.Drawing.Size(75, 40);
            this.btnConnetti.TabIndex = 4;
            this.btnConnetti.Text = "Connetti";
            this.btnConnetti.UseVisualStyleBackColor = true;
            this.btnConnetti.Click += new System.EventHandler(this.btnConnetti_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Messaggio:";
            // 
            // txtMessaggio
            // 
            this.txtMessaggio.Enabled = false;
            this.txtMessaggio.Location = new System.Drawing.Point(98, 63);
            this.txtMessaggio.Name = "txtMessaggio";
            this.txtMessaggio.Size = new System.Drawing.Size(250, 22);
            this.txtMessaggio.TabIndex = 6;
            // 
            // btnInvia
            // 
            this.btnInvia.Enabled = false;
            this.btnInvia.Location = new System.Drawing.Point(387, 55);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 38);
            this.btnInvia.TabIndex = 7;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // lstMessaggiServ
            // 
            this.lstMessaggiServ.FormattingEnabled = true;
            this.lstMessaggiServ.ItemHeight = 16;
            this.lstMessaggiServ.Location = new System.Drawing.Point(12, 107);
            this.lstMessaggiServ.Name = "lstMessaggiServ";
            this.lstMessaggiServ.Size = new System.Drawing.Size(450, 324);
            this.lstMessaggiServ.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 460);
            this.Controls.Add(this.lstMessaggiServ);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.txtMessaggio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConnetti);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIPServer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Button btnConnetti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMessaggio;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.ListBox lstMessaggiServ;
    }
}

