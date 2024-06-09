namespace Fdsmlfr
{
    partial class FormGame
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
            this.panelMap = new System.Windows.Forms.Panel();
            this.Hexagon6 = new System.Windows.Forms.PictureBox();
            this.Hexagon5 = new System.Windows.Forms.PictureBox();
            this.Hexagon7 = new System.Windows.Forms.PictureBox();
            this.Hexagon4 = new System.Windows.Forms.PictureBox();
            this.Hexagon2 = new System.Windows.Forms.PictureBox();
            this.Hexagon3 = new System.Windows.Forms.PictureBox();
            this.Hexagon1 = new System.Windows.Forms.PictureBox();
            this.panelCriatura = new System.Windows.Forms.Panel();
            this.textBoxDieta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDefensa = new System.Windows.Forms.TextBox();
            this.textBoxAtaque = new System.Windows.Forms.TextBox();
            this.textBoxEnergia = new System.Windows.Forms.TextBox();
            this.textBoxVida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCriaturas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelElementos = new System.Windows.Forms.Panel();
            this.buttonAtacar = new System.Windows.Forms.Button();
            this.buttonMover = new System.Windows.Forms.Button();
            this.dataGridViewCriaturas = new System.Windows.Forms.DataGridView();
            this.ColumnCriatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHabitad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUsar = new System.Windows.Forms.Button();
            this.buttonComer = new System.Windows.Forms.Button();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ColumnItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComidas = new System.Windows.Forms.DataGridView();
            this.ColumnNombreComida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDieta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hexagon6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hexagon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hexagon7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hexagon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hexagon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hexagon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hexagon1)).BeginInit();
            this.panelCriatura.SuspendLayout();
            this.panelElementos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCriaturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComidas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.Hexagon6);
            this.panelMap.Controls.Add(this.Hexagon5);
            this.panelMap.Controls.Add(this.Hexagon7);
            this.panelMap.Controls.Add(this.Hexagon4);
            this.panelMap.Controls.Add(this.Hexagon2);
            this.panelMap.Controls.Add(this.Hexagon3);
            this.panelMap.Controls.Add(this.Hexagon1);
            this.panelMap.Location = new System.Drawing.Point(9, 39);
            this.panelMap.Margin = new System.Windows.Forms.Padding(2);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(218, 317);
            this.panelMap.TabIndex = 0;
            // 
            // Hexagon6
            // 
            this.Hexagon6.BackColor = System.Drawing.Color.Transparent;
            this.Hexagon6.Image = global::Fdsmlfr.Properties.Resources.hexagon;
            this.Hexagon6.Location = new System.Drawing.Point(15, 103);
            this.Hexagon6.Margin = new System.Windows.Forms.Padding(2);
            this.Hexagon6.Name = "Hexagon6";
            this.Hexagon6.Size = new System.Drawing.Size(59, 46);
            this.Hexagon6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hexagon6.TabIndex = 6;
            this.Hexagon6.TabStop = false;
            this.Hexagon6.Click += new System.EventHandler(this.Terreno_Click);
            // 
            // Hexagon5
            // 
            this.Hexagon5.BackColor = System.Drawing.Color.Transparent;
            this.Hexagon5.Image = global::Fdsmlfr.Properties.Resources.hexagon;
            this.Hexagon5.Location = new System.Drawing.Point(13, 187);
            this.Hexagon5.Margin = new System.Windows.Forms.Padding(2);
            this.Hexagon5.Name = "Hexagon5";
            this.Hexagon5.Size = new System.Drawing.Size(59, 46);
            this.Hexagon5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hexagon5.TabIndex = 5;
            this.Hexagon5.TabStop = false;
            this.Hexagon5.Click += new System.EventHandler(this.Terreno_Click);
            // 
            // Hexagon7
            // 
            this.Hexagon7.BackColor = System.Drawing.Color.Transparent;
            this.Hexagon7.Image = global::Fdsmlfr.Properties.Resources.hexagon;
            this.Hexagon7.Location = new System.Drawing.Point(80, 55);
            this.Hexagon7.Margin = new System.Windows.Forms.Padding(2);
            this.Hexagon7.Name = "Hexagon7";
            this.Hexagon7.Size = new System.Drawing.Size(59, 46);
            this.Hexagon7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hexagon7.TabIndex = 4;
            this.Hexagon7.TabStop = false;
            this.Hexagon7.Click += new System.EventHandler(this.Terreno_Click);
            // 
            // Hexagon4
            // 
            this.Hexagon4.BackColor = System.Drawing.Color.Transparent;
            this.Hexagon4.Image = global::Fdsmlfr.Properties.Resources.hexagon;
            this.Hexagon4.Location = new System.Drawing.Point(79, 226);
            this.Hexagon4.Margin = new System.Windows.Forms.Padding(2);
            this.Hexagon4.Name = "Hexagon4";
            this.Hexagon4.Size = new System.Drawing.Size(59, 46);
            this.Hexagon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hexagon4.TabIndex = 3;
            this.Hexagon4.TabStop = false;
            this.Hexagon4.Click += new System.EventHandler(this.Terreno_Click);
            // 
            // Hexagon2
            // 
            this.Hexagon2.BackColor = System.Drawing.Color.Transparent;
            this.Hexagon2.Image = global::Fdsmlfr.Properties.Resources.hexagon;
            this.Hexagon2.Location = new System.Drawing.Point(143, 103);
            this.Hexagon2.Margin = new System.Windows.Forms.Padding(2);
            this.Hexagon2.Name = "Hexagon2";
            this.Hexagon2.Size = new System.Drawing.Size(59, 46);
            this.Hexagon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hexagon2.TabIndex = 2;
            this.Hexagon2.TabStop = false;
            this.Hexagon2.Click += new System.EventHandler(this.Terreno_Click);
            // 
            // Hexagon3
            // 
            this.Hexagon3.BackColor = System.Drawing.Color.Transparent;
            this.Hexagon3.Image = global::Fdsmlfr.Properties.Resources.hexagon;
            this.Hexagon3.Location = new System.Drawing.Point(143, 195);
            this.Hexagon3.Margin = new System.Windows.Forms.Padding(2);
            this.Hexagon3.Name = "Hexagon3";
            this.Hexagon3.Size = new System.Drawing.Size(59, 46);
            this.Hexagon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hexagon3.TabIndex = 1;
            this.Hexagon3.TabStop = false;
            this.Hexagon3.Click += new System.EventHandler(this.Terreno_Click);
            // 
            // Hexagon1
            // 
            this.Hexagon1.BackColor = System.Drawing.Color.Transparent;
            this.Hexagon1.Image = global::Fdsmlfr.Properties.Resources.hexagon;
            this.Hexagon1.Location = new System.Drawing.Point(79, 150);
            this.Hexagon1.Margin = new System.Windows.Forms.Padding(2);
            this.Hexagon1.Name = "Hexagon1";
            this.Hexagon1.Size = new System.Drawing.Size(59, 46);
            this.Hexagon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hexagon1.TabIndex = 0;
            this.Hexagon1.TabStop = false;
            this.Hexagon1.Click += new System.EventHandler(this.Terreno_Click);
            // 
            // panelCriatura
            // 
            this.panelCriatura.Controls.Add(this.textBoxDieta);
            this.panelCriatura.Controls.Add(this.label2);
            this.panelCriatura.Controls.Add(this.textBoxDefensa);
            this.panelCriatura.Controls.Add(this.textBoxAtaque);
            this.panelCriatura.Controls.Add(this.textBoxEnergia);
            this.panelCriatura.Controls.Add(this.textBoxVida);
            this.panelCriatura.Controls.Add(this.label6);
            this.panelCriatura.Controls.Add(this.label5);
            this.panelCriatura.Controls.Add(this.label4);
            this.panelCriatura.Controls.Add(this.label3);
            this.panelCriatura.Controls.Add(this.comboBoxCriaturas);
            this.panelCriatura.Controls.Add(this.label1);
            this.panelCriatura.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCriatura.Location = new System.Drawing.Point(255, 58);
            this.panelCriatura.Margin = new System.Windows.Forms.Padding(2);
            this.panelCriatura.Name = "panelCriatura";
            this.panelCriatura.Size = new System.Drawing.Size(196, 298);
            this.panelCriatura.TabIndex = 1;
            // 
            // textBoxDieta
            // 
            this.textBoxDieta.Location = new System.Drawing.Point(68, 222);
            this.textBoxDieta.Name = "textBoxDieta";
            this.textBoxDieta.Size = new System.Drawing.Size(119, 26);
            this.textBoxDieta.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dieta";
            // 
            // textBoxDefensa
            // 
            this.textBoxDefensa.Location = new System.Drawing.Point(68, 183);
            this.textBoxDefensa.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDefensa.Name = "textBoxDefensa";
            this.textBoxDefensa.Size = new System.Drawing.Size(122, 26);
            this.textBoxDefensa.TabIndex = 11;
            // 
            // textBoxAtaque
            // 
            this.textBoxAtaque.Location = new System.Drawing.Point(68, 137);
            this.textBoxAtaque.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAtaque.Name = "textBoxAtaque";
            this.textBoxAtaque.Size = new System.Drawing.Size(122, 26);
            this.textBoxAtaque.TabIndex = 10;
            // 
            // textBoxEnergia
            // 
            this.textBoxEnergia.Location = new System.Drawing.Point(66, 99);
            this.textBoxEnergia.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEnergia.Name = "textBoxEnergia";
            this.textBoxEnergia.Size = new System.Drawing.Size(122, 26);
            this.textBoxEnergia.TabIndex = 9;
            // 
            // textBoxVida
            // 
            this.textBoxVida.Location = new System.Drawing.Point(66, 69);
            this.textBoxVida.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVida.Name = "textBoxVida";
            this.textBoxVida.Size = new System.Drawing.Size(122, 26);
            this.textBoxVida.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Defensa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ataque:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Energia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vida:";
            // 
            // comboBoxCriaturas
            // 
            this.comboBoxCriaturas.FormattingEnabled = true;
            this.comboBoxCriaturas.Location = new System.Drawing.Point(66, 23);
            this.comboBoxCriaturas.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCriaturas.Name = "comboBoxCriaturas";
            this.comboBoxCriaturas.Size = new System.Drawing.Size(122, 28);
            this.comboBoxCriaturas.TabIndex = 1;
            this.comboBoxCriaturas.SelectedIndexChanged += new System.EventHandler(this.Criatura_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criatura";
            // 
            // panelElementos
            // 
            this.panelElementos.Controls.Add(this.buttonAtacar);
            this.panelElementos.Controls.Add(this.buttonMover);
            this.panelElementos.Controls.Add(this.dataGridViewCriaturas);
            this.panelElementos.Controls.Add(this.buttonUsar);
            this.panelElementos.Controls.Add(this.buttonComer);
            this.panelElementos.Controls.Add(this.dataGridViewItems);
            this.panelElementos.Controls.Add(this.dataGridViewComidas);
            this.panelElementos.Location = new System.Drawing.Point(469, 58);
            this.panelElementos.Margin = new System.Windows.Forms.Padding(2);
            this.panelElementos.Name = "panelElementos";
            this.panelElementos.Size = new System.Drawing.Size(737, 298);
            this.panelElementos.TabIndex = 2;
            // 
            // buttonAtacar
            // 
            this.buttonAtacar.Location = new System.Drawing.Point(494, 245);
            this.buttonAtacar.Name = "buttonAtacar";
            this.buttonAtacar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtacar.TabIndex = 6;
            this.buttonAtacar.Text = "Atacar";
            this.buttonAtacar.UseVisualStyleBackColor = true;
            this.buttonAtacar.Click += new System.EventHandler(this.buttonAtacar_Click);
            // 
            // buttonMover
            // 
            this.buttonMover.Location = new System.Drawing.Point(494, 206);
            this.buttonMover.Name = "buttonMover";
            this.buttonMover.Size = new System.Drawing.Size(75, 23);
            this.buttonMover.TabIndex = 5;
            this.buttonMover.Text = "Moverse";
            this.buttonMover.UseVisualStyleBackColor = true;
            this.buttonMover.Click += new System.EventHandler(this.buttonMover_Click);
            // 
            // dataGridViewCriaturas
            // 
            this.dataGridViewCriaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCriaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCriatura,
            this.ColumnVida,
            this.ColumnHabitad});
            this.dataGridViewCriaturas.Location = new System.Drawing.Point(12, 183);
            this.dataGridViewCriaturas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCriaturas.Name = "dataGridViewCriaturas";
            this.dataGridViewCriaturas.RowHeadersWidth = 51;
            this.dataGridViewCriaturas.RowTemplate.Height = 24;
            this.dataGridViewCriaturas.Size = new System.Drawing.Size(457, 113);
            this.dataGridViewCriaturas.TabIndex = 4;
            // 
            // ColumnCriatura
            // 
            this.ColumnCriatura.HeaderText = "Nombre";
            this.ColumnCriatura.MinimumWidth = 6;
            this.ColumnCriatura.Name = "ColumnCriatura";
            this.ColumnCriatura.Width = 125;
            // 
            // ColumnVida
            // 
            this.ColumnVida.HeaderText = "Vida";
            this.ColumnVida.MinimumWidth = 6;
            this.ColumnVida.Name = "ColumnVida";
            this.ColumnVida.Width = 125;
            // 
            // ColumnHabitad
            // 
            this.ColumnHabitad.HeaderText = "Habitad";
            this.ColumnHabitad.MinimumWidth = 6;
            this.ColumnHabitad.Name = "ColumnHabitad";
            this.ColumnHabitad.Width = 125;
            // 
            // buttonUsar
            // 
            this.buttonUsar.Location = new System.Drawing.Point(611, 63);
            this.buttonUsar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUsar.Name = "buttonUsar";
            this.buttonUsar.Size = new System.Drawing.Size(56, 19);
            this.buttonUsar.TabIndex = 3;
            this.buttonUsar.Text = "Usar";
            this.buttonUsar.UseVisualStyleBackColor = true;
            this.buttonUsar.Click += new System.EventHandler(this.buttonUsar_Click);
            // 
            // buttonComer
            // 
            this.buttonComer.Location = new System.Drawing.Point(330, 69);
            this.buttonComer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonComer.Name = "buttonComer";
            this.buttonComer.Size = new System.Drawing.Size(56, 19);
            this.buttonComer.TabIndex = 2;
            this.buttonComer.Text = "Comer";
            this.buttonComer.UseVisualStyleBackColor = true;
            this.buttonComer.Click += new System.EventHandler(this.buttonComer_Click);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItem});
            this.dataGridViewItems.Location = new System.Drawing.Point(409, 23);
            this.dataGridViewItems.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowHeadersWidth = 51;
            this.dataGridViewItems.RowTemplate.Height = 24;
            this.dataGridViewItems.Size = new System.Drawing.Size(179, 122);
            this.dataGridViewItems.TabIndex = 1;
            // 
            // ColumnItem
            // 
            this.ColumnItem.HeaderText = "Item";
            this.ColumnItem.MinimumWidth = 6;
            this.ColumnItem.Name = "ColumnItem";
            this.ColumnItem.Width = 125;
            // 
            // dataGridViewComidas
            // 
            this.dataGridViewComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombreComida,
            this.ColumnDieta});
            this.dataGridViewComidas.Location = new System.Drawing.Point(12, 23);
            this.dataGridViewComidas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewComidas.Name = "dataGridViewComidas";
            this.dataGridViewComidas.RowHeadersWidth = 51;
            this.dataGridViewComidas.RowTemplate.Height = 24;
            this.dataGridViewComidas.Size = new System.Drawing.Size(294, 122);
            this.dataGridViewComidas.TabIndex = 0;
            // 
            // ColumnNombreComida
            // 
            this.ColumnNombreComida.HeaderText = "Comida";
            this.ColumnNombreComida.MinimumWidth = 6;
            this.ColumnNombreComida.Name = "ColumnNombreComida";
            this.ColumnNombreComida.Width = 125;
            // 
            // ColumnDieta
            // 
            this.ColumnDieta.HeaderText = "Dieta";
            this.ColumnDieta.MinimumWidth = 6;
            this.ColumnDieta.Name = "ColumnDieta";
            this.ColumnDieta.Width = 125;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 513);
            this.Controls.Add(this.panelElementos);
            this.Controls.Add(this.panelCriatura);
            this.Controls.Add(this.panelMap);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormGame";
            this.panelMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Hexagon6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hexagon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hexagon7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hexagon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hexagon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hexagon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hexagon1)).EndInit();
            this.panelCriatura.ResumeLayout(false);
            this.panelCriatura.PerformLayout();
            this.panelElementos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCriaturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.PictureBox Hexagon6;
        private System.Windows.Forms.PictureBox Hexagon5;
        private System.Windows.Forms.PictureBox Hexagon7;
        private System.Windows.Forms.PictureBox Hexagon4;
        private System.Windows.Forms.PictureBox Hexagon2;
        private System.Windows.Forms.PictureBox Hexagon3;
        private System.Windows.Forms.PictureBox Hexagon1;
        private System.Windows.Forms.Panel panelCriatura;
        private System.Windows.Forms.TextBox textBoxDefensa;
        private System.Windows.Forms.TextBox textBoxAtaque;
        private System.Windows.Forms.TextBox textBoxEnergia;
        private System.Windows.Forms.TextBox textBoxVida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCriaturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelElementos;
        private System.Windows.Forms.DataGridView dataGridViewCriaturas;
        private System.Windows.Forms.Button buttonUsar;
        private System.Windows.Forms.Button buttonComer;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItem;
        private System.Windows.Forms.DataGridView dataGridViewComidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombreComida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDieta;
        private System.Windows.Forms.Button buttonMover;
        private System.Windows.Forms.TextBox textBoxDieta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCriatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHabitad;
        private System.Windows.Forms.Button buttonAtacar;
    }
}