namespace Fdsmlfr
{
    partial class FormItemPrueba
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
            this.buttonInteractuar = new System.Windows.Forms.Button();
            this.comboCriatura = new System.Windows.Forms.ComboBox();
            this.comboItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEnergia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEfectos = new System.Windows.Forms.TextBox();
            this.Efectos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInteractuar
            // 
            this.buttonInteractuar.Location = new System.Drawing.Point(341, 253);
            this.buttonInteractuar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInteractuar.Name = "buttonInteractuar";
            this.buttonInteractuar.Size = new System.Drawing.Size(74, 19);
            this.buttonInteractuar.TabIndex = 0;
            this.buttonInteractuar.Text = "Interactuar";
            this.buttonInteractuar.UseVisualStyleBackColor = true;
            this.buttonInteractuar.Click += new System.EventHandler(this.ButtonInteractuar_Click);
            // 
            // comboCriatura
            // 
            this.comboCriatura.FormattingEnabled = true;
            this.comboCriatura.Location = new System.Drawing.Point(98, 109);
            this.comboCriatura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboCriatura.Name = "comboCriatura";
            this.comboCriatura.Size = new System.Drawing.Size(120, 21);
            this.comboCriatura.TabIndex = 1;
            this.comboCriatura.SelectedIndexChanged += new System.EventHandler(this.PonerDatosCriatura);
            // 
            // comboItem
            // 
            this.comboItem.FormattingEnabled = true;
            this.comboItem.Location = new System.Drawing.Point(341, 109);
            this.comboItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboItem.Name = "comboItem";
            this.comboItem.Size = new System.Drawing.Size(114, 21);
            this.comboItem.TabIndex = 2;
            this.comboItem.SelectedIndexChanged += new System.EventHandler(this.PonerDatosItem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Criatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item";
            // 
            // textBoxEnergia
            // 
            this.textBoxEnergia.Location = new System.Drawing.Point(98, 253);
            this.textBoxEnergia.Name = "textBoxEnergia";
            this.textBoxEnergia.Size = new System.Drawing.Size(120, 20);
            this.textBoxEnergia.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Energia";
            // 
            // textBoxVida
            // 
            this.textBoxVida.Location = new System.Drawing.Point(98, 178);
            this.textBoxVida.Name = "textBoxVida";
            this.textBoxVida.Size = new System.Drawing.Size(120, 20);
            this.textBoxVida.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vida";
            // 
            // textBoxEfectos
            // 
            this.textBoxEfectos.Location = new System.Drawing.Point(307, 178);
            this.textBoxEfectos.Name = "textBoxEfectos";
            this.textBoxEfectos.Size = new System.Drawing.Size(260, 20);
            this.textBoxEfectos.TabIndex = 14;
            // 
            // Efectos
            // 
            this.Efectos.AutoSize = true;
            this.Efectos.Location = new System.Drawing.Point(338, 147);
            this.Efectos.Name = "Efectos";
            this.Efectos.Size = new System.Drawing.Size(43, 13);
            this.Efectos.TabIndex = 13;
            this.Efectos.Text = "Efectos";
            // 
            // FormItemPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBoxEfectos);
            this.Controls.Add(this.Efectos);
            this.Controls.Add(this.textBoxEnergia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxVida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboItem);
            this.Controls.Add(this.comboCriatura);
            this.Controls.Add(this.buttonInteractuar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormItemPrueba";
            this.Text = "FormItemPrueba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInteractuar;
        private System.Windows.Forms.ComboBox comboCriatura;
        private System.Windows.Forms.ComboBox comboItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEnergia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEfectos;
        private System.Windows.Forms.Label Efectos;
    }
}