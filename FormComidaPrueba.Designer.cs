namespace Fdsmlfr
{
    partial class FormComidaPrueba
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
            this.comboBoxCriatura = new System.Windows.Forms.ComboBox();
            this.Alimentacion = new System.Windows.Forms.Label();
            this.comboBoxComida = new System.Windows.Forms.ComboBox();
            this.textBoxDieta = new System.Windows.Forms.TextBox();
            this.textBoxDietaAnimal = new System.Windows.Forms.TextBox();
            this.textBoxEnergia = new System.Windows.Forms.TextBox();
            this.buttonComer = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCriatura
            // 
            this.comboBoxCriatura.FormattingEnabled = true;
            this.comboBoxCriatura.Location = new System.Drawing.Point(90, 131);
            this.comboBoxCriatura.Name = "comboBoxCriatura";
            this.comboBoxCriatura.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCriatura.TabIndex = 0;
            this.comboBoxCriatura.SelectedIndexChanged += new System.EventHandler(this.ponerDatosCriatura);
            // 
            // Alimentacion
            // 
            this.Alimentacion.AutoSize = true;
            this.Alimentacion.Location = new System.Drawing.Point(355, 58);
            this.Alimentacion.Name = "Alimentacion";
            this.Alimentacion.Size = new System.Drawing.Size(67, 13);
            this.Alimentacion.TabIndex = 1;
            this.Alimentacion.Text = "Alimentacion";
            // 
            // comboBoxComida
            // 
            this.comboBoxComida.FormattingEnabled = true;
            this.comboBoxComida.Location = new System.Drawing.Point(569, 131);
            this.comboBoxComida.Name = "comboBoxComida";
            this.comboBoxComida.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComida.TabIndex = 2;
            this.comboBoxComida.SelectedIndexChanged += new System.EventHandler(this.ponerDatosComida);
            // 
            // textBoxDieta
            // 
            this.textBoxDieta.Location = new System.Drawing.Point(569, 182);
            this.textBoxDieta.Name = "textBoxDieta";
            this.textBoxDieta.Size = new System.Drawing.Size(121, 20);
            this.textBoxDieta.TabIndex = 3;
            // 
            // textBoxDietaAnimal
            // 
            this.textBoxDietaAnimal.Location = new System.Drawing.Point(90, 182);
            this.textBoxDietaAnimal.Name = "textBoxDietaAnimal";
            this.textBoxDietaAnimal.Size = new System.Drawing.Size(121, 20);
            this.textBoxDietaAnimal.TabIndex = 4;
            // 
            // textBoxEnergia
            // 
            this.textBoxEnergia.Location = new System.Drawing.Point(90, 234);
            this.textBoxEnergia.Name = "textBoxEnergia";
            this.textBoxEnergia.Size = new System.Drawing.Size(121, 20);
            this.textBoxEnergia.TabIndex = 5;
            // 
            // buttonComer
            // 
            this.buttonComer.Location = new System.Drawing.Point(277, 312);
            this.buttonComer.Name = "buttonComer";
            this.buttonComer.Size = new System.Drawing.Size(75, 23);
            this.buttonComer.TabIndex = 6;
            this.buttonComer.Text = "Comer";
            this.buttonComer.UseVisualStyleBackColor = true;
            this.buttonComer.Click += new System.EventHandler(this.buttonComer_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(446, 312);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 7;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            // 
            // FormComidaPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonComer);
            this.Controls.Add(this.textBoxEnergia);
            this.Controls.Add(this.textBoxDietaAnimal);
            this.Controls.Add(this.textBoxDieta);
            this.Controls.Add(this.comboBoxComida);
            this.Controls.Add(this.Alimentacion);
            this.Controls.Add(this.comboBoxCriatura);
            this.Name = "FormComidaPrueba";
            this.Text = "FormComidaPrueba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCriatura;
        private System.Windows.Forms.Label Alimentacion;
        private System.Windows.Forms.ComboBox comboBoxComida;
        private System.Windows.Forms.TextBox textBoxDieta;
        private System.Windows.Forms.TextBox textBoxDietaAnimal;
        private System.Windows.Forms.TextBox textBoxEnergia;
        private System.Windows.Forms.Button buttonComer;
        private System.Windows.Forms.Button buttonVolver;
    }
}