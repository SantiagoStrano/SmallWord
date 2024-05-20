namespace Fdsmlfr
{
    partial class FormCriatura
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textNomb = new System.Windows.Forms.TextBox();
            this.comboReino = new System.Windows.Forms.ComboBox();
            this.comboDiet = new System.Windows.Forms.ComboBox();
            this.textEnerg = new System.Windows.Forms.TextBox();
            this.textVida = new System.Windows.Forms.TextBox();
            this.textAtaq = new System.Windows.Forms.TextBox();
            this.textDef = new System.Windows.Forms.TextBox();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.checkedListHabitad = new System.Windows.Forms.CheckedListBox();
            this.dataGridCriatura = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ataque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defensa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dieta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCriatura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Habitad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dieta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Energia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Vida:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 231);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ataque:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 271);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Defensa:";
            // 
            // textNomb
            // 
            this.textNomb.Location = new System.Drawing.Point(257, 93);
            this.textNomb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNomb.Name = "textNomb";
            this.textNomb.Size = new System.Drawing.Size(120, 20);
            this.textNomb.TabIndex = 9;
            // 
            // comboReino
            // 
            this.comboReino.FormattingEnabled = true;
            this.comboReino.Location = new System.Drawing.Point(687, 91);
            this.comboReino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboReino.Name = "comboReino";
            this.comboReino.Size = new System.Drawing.Size(120, 21);
            this.comboReino.TabIndex = 10;
            // 
            // comboDiet
            // 
            this.comboDiet.FormattingEnabled = true;
            this.comboDiet.Location = new System.Drawing.Point(687, 146);
            this.comboDiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboDiet.Name = "comboDiet";
            this.comboDiet.Size = new System.Drawing.Size(120, 21);
            this.comboDiet.TabIndex = 11;
            // 
            // textEnerg
            // 
            this.textEnerg.Location = new System.Drawing.Point(257, 146);
            this.textEnerg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textEnerg.Name = "textEnerg";
            this.textEnerg.Size = new System.Drawing.Size(120, 20);
            this.textEnerg.TabIndex = 12;
            // 
            // textVida
            // 
            this.textVida.Location = new System.Drawing.Point(257, 191);
            this.textVida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textVida.Name = "textVida";
            this.textVida.Size = new System.Drawing.Size(120, 20);
            this.textVida.TabIndex = 13;
            // 
            // textAtaq
            // 
            this.textAtaq.Location = new System.Drawing.Point(257, 231);
            this.textAtaq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textAtaq.Name = "textAtaq";
            this.textAtaq.Size = new System.Drawing.Size(120, 20);
            this.textAtaq.TabIndex = 14;
            // 
            // textDef
            // 
            this.textDef.Location = new System.Drawing.Point(257, 271);
            this.textDef.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDef.Name = "textDef";
            this.textDef.Size = new System.Drawing.Size(120, 20);
            this.textDef.TabIndex = 15;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(367, 344);
            this.buttonCrear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(56, 19);
            this.buttonCrear.TabIndex = 16;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.ButtonCrear_Click);
            // 
            // checkedListHabitad
            // 
            this.checkedListHabitad.FormattingEnabled = true;
            this.checkedListHabitad.Location = new System.Drawing.Point(687, 196);
            this.checkedListHabitad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListHabitad.Name = "checkedListHabitad";
            this.checkedListHabitad.Size = new System.Drawing.Size(120, 109);
            this.checkedListHabitad.TabIndex = 17;
            // 
            // dataGridCriatura
            // 
            this.dataGridCriatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCriatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.energia,
            this.vida,
            this.ataque,
            this.defensa,
            this.reino,
            this.dieta,
            this.habitad});
            this.dataGridCriatura.Location = new System.Drawing.Point(101, 388);
            this.dataGridCriatura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridCriatura.Name = "dataGridCriatura";
            this.dataGridCriatura.RowHeadersWidth = 51;
            this.dataGridCriatura.RowTemplate.Height = 24;
            this.dataGridCriatura.Size = new System.Drawing.Size(874, 122);
            this.dataGridCriatura.TabIndex = 18;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // energia
            // 
            this.energia.HeaderText = "Energia";
            this.energia.MinimumWidth = 6;
            this.energia.Name = "energia";
            this.energia.Width = 125;
            // 
            // vida
            // 
            this.vida.HeaderText = "Vida";
            this.vida.MinimumWidth = 6;
            this.vida.Name = "vida";
            this.vida.Width = 125;
            // 
            // ataque
            // 
            this.ataque.HeaderText = "Ataque";
            this.ataque.MinimumWidth = 6;
            this.ataque.Name = "ataque";
            this.ataque.Width = 125;
            // 
            // defensa
            // 
            this.defensa.HeaderText = "Defensa";
            this.defensa.MinimumWidth = 6;
            this.defensa.Name = "defensa";
            this.defensa.Width = 125;
            // 
            // reino
            // 
            this.reino.HeaderText = "Reino";
            this.reino.MinimumWidth = 6;
            this.reino.Name = "reino";
            this.reino.Width = 125;
            // 
            // dieta
            // 
            this.dieta.HeaderText = "Dieta";
            this.dieta.MinimumWidth = 6;
            this.dieta.Name = "dieta";
            this.dieta.Width = 125;
            // 
            // habitad
            // 
            this.habitad.HeaderText = "Habitad";
            this.habitad.MinimumWidth = 6;
            this.habitad.Name = "habitad";
            this.habitad.Width = 125;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(478, 344);
            this.buttonVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(56, 19);
            this.buttonVolver.TabIndex = 20;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.ButtonVolver_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(579, 340);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 21;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(699, 342);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 22;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.ButtonModificar_Click);
            // 
            // FormCriatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 584);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.dataGridCriatura);
            this.Controls.Add(this.checkedListHabitad);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.textDef);
            this.Controls.Add(this.textAtaq);
            this.Controls.Add(this.textVida);
            this.Controls.Add(this.textEnerg);
            this.Controls.Add(this.comboDiet);
            this.Controls.Add(this.comboReino);
            this.Controls.Add(this.textNomb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCriatura";
            this.Text = "FormCriatura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCriatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textNomb;
        private System.Windows.Forms.ComboBox comboReino;
        private System.Windows.Forms.ComboBox comboDiet;
        private System.Windows.Forms.TextBox textEnerg;
        private System.Windows.Forms.TextBox textVida;
        private System.Windows.Forms.TextBox textAtaq;
        private System.Windows.Forms.TextBox textDef;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.CheckedListBox checkedListHabitad;
        private System.Windows.Forms.DataGridView dataGridCriatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn energia;
        private System.Windows.Forms.DataGridViewTextBoxColumn vida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ataque;
        private System.Windows.Forms.DataGridViewTextBoxColumn defensa;
        private System.Windows.Forms.DataGridViewTextBoxColumn reino;
        private System.Windows.Forms.DataGridViewTextBoxColumn dieta;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitad;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
    }
}