namespace Fdsmlfr
{
    partial class FormItem
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
            this.checkedListBoxEstrategia = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreateItem = new System.Windows.Forms.Button();
            this.dataGridItems = new System.Windows.Forms.DataGridView();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEfectos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // checkedListBoxEstrategia
            // 
            this.checkedListBoxEstrategia.FormattingEnabled = true;
            this.checkedListBoxEstrategia.Location = new System.Drawing.Point(149, 164);
            this.checkedListBoxEstrategia.Name = "checkedListBoxEstrategia";
            this.checkedListBoxEstrategia.Size = new System.Drawing.Size(120, 89);
            this.checkedListBoxEstrategia.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Efectos";
            // 
            // buttonCreateItem
            // 
            this.buttonCreateItem.Location = new System.Drawing.Point(104, 304);
            this.buttonCreateItem.Name = "buttonCreateItem";
            this.buttonCreateItem.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateItem.TabIndex = 4;
            this.buttonCreateItem.Text = "Crear";
            this.buttonCreateItem.UseVisualStyleBackColor = true;
            this.buttonCreateItem.Click += new System.EventHandler(this.buttonCreateItem_Click);
            // 
            // dataGridItems
            // 
            this.dataGridItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnEfectos});
            this.dataGridItems.Location = new System.Drawing.Point(418, 112);
            this.dataGridItems.Name = "dataGridItems";
            this.dataGridItems.RowHeadersWidth = 51;
            this.dataGridItems.RowTemplate.Height = 24;
            this.dataGridItems.Size = new System.Drawing.Size(305, 150);
            this.dataGridItems.TabIndex = 5;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(149, 109);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(120, 22);
            this.textNombre.TabIndex = 6;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.MinimumWidth = 6;
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.Width = 125;
            // 
            // ColumnEfectos
            // 
            this.ColumnEfectos.HeaderText = "Efectos";
            this.ColumnEfectos.MinimumWidth = 6;
            this.ColumnEfectos.Name = "ColumnEfectos";
            this.ColumnEfectos.Width = 125;
            // 
            // FormItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.dataGridItems);
            this.Controls.Add(this.buttonCreateItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBoxEstrategia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormItem";
            this.Text = "FormItem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBoxEstrategia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreateItem;
        private System.Windows.Forms.DataGridView dataGridItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEfectos;
        private System.Windows.Forms.TextBox textNombre;
    }
}