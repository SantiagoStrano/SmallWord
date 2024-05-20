namespace Fdsmlfr
{
    partial class FormPelea
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCriatAtack = new System.Windows.Forms.ComboBox();
            this.comboBoxCriatDef = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxVidaAtac = new System.Windows.Forms.TextBox();
            this.textBoxAtacEnerg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxVidaDef = new System.Windows.Forms.TextBox();
            this.textBoxEnergDef = new System.Windows.Forms.TextBox();
            this.buttonAtacar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAtacPnAtc = new System.Windows.Forms.TextBox();
            this.textBoxDefensorPnDef = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pelea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Atacante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Defensor";
            // 
            // comboCriatAtack
            // 
            this.comboCriatAtack.FormattingEnabled = true;
            this.comboCriatAtack.Location = new System.Drawing.Point(139, 151);
            this.comboCriatAtack.Name = "comboCriatAtack";
            this.comboCriatAtack.Size = new System.Drawing.Size(159, 24);
            this.comboCriatAtack.TabIndex = 3;
            this.comboCriatAtack.SelectedIndexChanged += new System.EventHandler(this.PonerDatosAtacante);
            // 
            // comboBoxCriatDef
            // 
            this.comboBoxCriatDef.FormattingEnabled = true;
            this.comboBoxCriatDef.Location = new System.Drawing.Point(429, 151);
            this.comboBoxCriatDef.Name = "comboBoxCriatDef";
            this.comboBoxCriatDef.Size = new System.Drawing.Size(155, 24);
            this.comboBoxCriatDef.TabIndex = 4;
            this.comboBoxCriatDef.SelectedIndexChanged += new System.EventHandler(this.PonerDatosDefensor);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vida: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Energia";
            // 
            // textBoxVidaAtac
            // 
            this.textBoxVidaAtac.Location = new System.Drawing.Point(148, 203);
            this.textBoxVidaAtac.Name = "textBoxVidaAtac";
            this.textBoxVidaAtac.Size = new System.Drawing.Size(100, 22);
            this.textBoxVidaAtac.TabIndex = 7;
            // 
            // textBoxAtacEnerg
            // 
            this.textBoxAtacEnerg.Location = new System.Drawing.Point(148, 258);
            this.textBoxAtacEnerg.Name = "textBoxAtacEnerg";
            this.textBoxAtacEnerg.Size = new System.Drawing.Size(100, 22);
            this.textBoxAtacEnerg.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vida: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Energia";
            // 
            // textBoxVidaDef
            // 
            this.textBoxVidaDef.Location = new System.Drawing.Point(456, 210);
            this.textBoxVidaDef.Name = "textBoxVidaDef";
            this.textBoxVidaDef.Size = new System.Drawing.Size(100, 22);
            this.textBoxVidaDef.TabIndex = 11;
            // 
            // textBoxEnergDef
            // 
            this.textBoxEnergDef.Location = new System.Drawing.Point(456, 261);
            this.textBoxEnergDef.Name = "textBoxEnergDef";
            this.textBoxEnergDef.Size = new System.Drawing.Size(100, 22);
            this.textBoxEnergDef.TabIndex = 12;
            // 
            // buttonAtacar
            // 
            this.buttonAtacar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAtacar.Location = new System.Drawing.Point(296, 384);
            this.buttonAtacar.Name = "buttonAtacar";
            this.buttonAtacar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtacar.TabIndex = 13;
            this.buttonAtacar.Text = "Atacar";
            this.buttonAtacar.UseVisualStyleBackColor = true;
            this.buttonAtacar.Click += new System.EventHandler(this.ButtonAtacar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pnt Ataque";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Pnt Defensa";
            // 
            // textBoxAtacPnAtc
            // 
            this.textBoxAtacPnAtc.Location = new System.Drawing.Point(161, 319);
            this.textBoxAtacPnAtc.Name = "textBoxAtacPnAtc";
            this.textBoxAtacPnAtc.Size = new System.Drawing.Size(51, 22);
            this.textBoxAtacPnAtc.TabIndex = 16;
            // 
            // textBoxDefensorPnDef
            // 
            this.textBoxDefensorPnDef.Location = new System.Drawing.Point(482, 322);
            this.textBoxDefensorPnDef.Name = "textBoxDefensorPnDef";
            this.textBoxDefensorPnDef.Size = new System.Drawing.Size(51, 22);
            this.textBoxDefensorPnDef.TabIndex = 17;
            // 
            // FormPelea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDefensorPnDef);
            this.Controls.Add(this.textBoxAtacPnAtc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonAtacar);
            this.Controls.Add(this.textBoxEnergDef);
            this.Controls.Add(this.textBoxVidaDef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAtacEnerg);
            this.Controls.Add(this.textBoxVidaAtac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxCriatDef);
            this.Controls.Add(this.comboCriatAtack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPelea";
            this.Text = "FormPelea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCriatAtack;
        private System.Windows.Forms.ComboBox comboBoxCriatDef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxVidaAtac;
        private System.Windows.Forms.TextBox textBoxAtacEnerg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxVidaDef;
        private System.Windows.Forms.TextBox textBoxEnergDef;
        private System.Windows.Forms.Button buttonAtacar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAtacPnAtc;
        private System.Windows.Forms.TextBox textBoxDefensorPnDef;
    }
}