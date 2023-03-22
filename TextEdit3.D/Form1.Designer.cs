namespace TextEdit3.D
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
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxZapis = new System.Windows.Forms.TextBox();
            this.btnOtvori = new System.Windows.Forms.Button();
            this.btnOtvoriNovi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Location = new System.Drawing.Point(122, 42);
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(126, 20);
            this.txtBoxIme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime datoteke:";
            // 
            // txtBoxZapis
            // 
            this.txtBoxZapis.Location = new System.Drawing.Point(26, 77);
            this.txtBoxZapis.Multiline = true;
            this.txtBoxZapis.Name = "txtBoxZapis";
            this.txtBoxZapis.Size = new System.Drawing.Size(554, 349);
            this.txtBoxZapis.TabIndex = 2;
            // 
            // btnOtvori
            // 
            this.btnOtvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOtvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnOtvori.Location = new System.Drawing.Point(586, 77);
            this.btnOtvori.Name = "btnOtvori";
            this.btnOtvori.Size = new System.Drawing.Size(202, 86);
            this.btnOtvori.TabIndex = 3;
            this.btnOtvori.Text = "Otvori. txt datoteku ";
            this.btnOtvori.UseVisualStyleBackColor = false;
            this.btnOtvori.Click += new System.EventHandler(this.btnOtvori_Click);
            // 
            // btnOtvoriNovi
            // 
            this.btnOtvoriNovi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOtvoriNovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnOtvoriNovi.Location = new System.Drawing.Point(586, 210);
            this.btnOtvoriNovi.Name = "btnOtvoriNovi";
            this.btnOtvoriNovi.Size = new System.Drawing.Size(202, 89);
            this.btnOtvoriNovi.TabIndex = 4;
            this.btnOtvoriNovi.Text = "Otvori novi prazni dokument";
            this.btnOtvoriNovi.UseVisualStyleBackColor = false;
            this.btnOtvoriNovi.Click += new System.EventHandler(this.btnOtvoriNovi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSpremi.Location = new System.Drawing.Point(586, 355);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(202, 71);
            this.btnSpremi.TabIndex = 5;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOtvoriNovi);
            this.Controls.Add(this.btnOtvori);
            this.Controls.Add(this.txtBoxZapis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxIme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxZapis;
        private System.Windows.Forms.Button btnOtvori;
        private System.Windows.Forms.Button btnOtvoriNovi;
        private System.Windows.Forms.Button btnSpremi;
    }
}

