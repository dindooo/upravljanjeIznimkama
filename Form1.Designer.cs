namespace upravljanjeIznimkama
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
            this.txtUnos = new System.Windows.Forms.TextBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.lblGod = new System.Windows.Forms.Label();
            this.lblRod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUnos
            // 
            this.txtUnos.Location = new System.Drawing.Point(272, 202);
            this.txtUnos.Name = "txtUnos";
            this.txtUnos.Size = new System.Drawing.Size(194, 20);
            this.txtUnos.TabIndex = 0;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(272, 254);
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(194, 20);
            this.txtIspis.TabIndex = 2;
            this.txtIspis.TabStop = false;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Font = new System.Drawing.Font("Wide Latin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesi.Location = new System.Drawing.Point(492, 202);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(81, 72);
            this.btnUnesi.TabIndex = 1;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // lblGod
            // 
            this.lblGod.AutoSize = true;
            this.lblGod.Location = new System.Drawing.Point(269, 186);
            this.lblGod.Name = "lblGod";
            this.lblGod.Size = new System.Drawing.Size(135, 13);
            this.lblGod.TabIndex = 3;
            this.lblGod.Text = "Unesi svoju godinu rodenja";
            // 
            // lblRod
            // 
            this.lblRod.AutoSize = true;
            this.lblRod.Location = new System.Drawing.Point(269, 238);
            this.lblRod.Name = "lblRod";
            this.lblRod.Size = new System.Drawing.Size(55, 13);
            this.lblRod.TabIndex = 4;
            this.lblRod.Text = "Roden si :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRod);
            this.Controls.Add(this.lblGod);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.txtUnos);
            this.Name = "Form1";
            this.Text = "Upravljanje iznimkama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnos;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Label lblGod;
        private System.Windows.Forms.Label lblRod;
    }
}

