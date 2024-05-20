using System;

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
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCreateItem = new System.Windows.Forms.Button();
            this.dataGridItems = new System.Windows.Forms.DataGridView();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEfectos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.comboEfectos = new System.Windows.Forms.ComboBox();
            this.textCant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.dataGridEfectos = new System.Windows.Forms.DataGridView();
            this.Efecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonElimarEfecto = new System.Windows.Forms.Button();
            this.buttonEliminarItem = new System.Windows.Forms.Button();
            this.buttonModificarItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEfectos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 429);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Efectos";
            // 
            // buttonCreateItem
            // 
            this.buttonCreateItem.Location = new System.Drawing.Point(672, 459);
            this.buttonCreateItem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateItem.Name = "buttonCreateItem";
            this.buttonCreateItem.Size = new System.Drawing.Size(56, 19);
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
            this.dataGridItems.Location = new System.Drawing.Point(1054, 91);
            this.dataGridItems.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridItems.Name = "dataGridItems";
            this.dataGridItems.RowHeadersWidth = 51;
            this.dataGridItems.RowTemplate.Height = 24;
            this.dataGridItems.Size = new System.Drawing.Size(423, 122);
            this.dataGridItems.TabIndex = 5;
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
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(681, 426);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(91, 20);
            this.textNombre.TabIndex = 6;
            // 
            // comboEfectos
            // 
            this.comboEfectos.FormattingEnabled = true;
            this.comboEfectos.Location = new System.Drawing.Point(672, 125);
            this.comboEfectos.Name = "comboEfectos";
            this.comboEfectos.Size = new System.Drawing.Size(121, 21);
            this.comboEfectos.TabIndex = 7;
            // 
            // textCant
            // 
            this.textCant.Location = new System.Drawing.Point(672, 169);
            this.textCant.Name = "textCant";
            this.textCant.Size = new System.Drawing.Size(121, 20);
            this.textCant.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(640, 212);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 10;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // dataGridEfectos
            // 
            this.dataGridEfectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEfectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Efecto,
            this.Valor});
            this.dataGridEfectos.Location = new System.Drawing.Point(602, 265);
            this.dataGridEfectos.Name = "dataGridEfectos";
            this.dataGridEfectos.Size = new System.Drawing.Size(240, 150);
            this.dataGridEfectos.TabIndex = 11;
            // 
            // Efecto
            // 
            this.Efecto.HeaderText = "Efecto";
            this.Efecto.Name = "Efecto";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // buttonElimarEfecto
            // 
            this.buttonElimarEfecto.Location = new System.Drawing.Point(862, 319);
            this.buttonElimarEfecto.Name = "buttonElimarEfecto";
            this.buttonElimarEfecto.Size = new System.Drawing.Size(75, 23);
            this.buttonElimarEfecto.TabIndex = 12;
            this.buttonElimarEfecto.Text = "Eliminar";
            this.buttonElimarEfecto.UseVisualStyleBackColor = true;
            this.buttonElimarEfecto.Click += new System.EventHandler(this.buttonEliminarEfecto_Click);
            // 
            // buttonEliminarItem
            // 
            this.buttonEliminarItem.Location = new System.Drawing.Point(1322, 234);
            this.buttonEliminarItem.Name = "buttonEliminarItem";
            this.buttonEliminarItem.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarItem.TabIndex = 14;
            this.buttonEliminarItem.Text = "Eliminar";
            this.buttonEliminarItem.UseVisualStyleBackColor = true;
            this.buttonEliminarItem.Click += new System.EventHandler(this.buttonEliminarItem_Click);
            // 
            // buttonModificarItem
            // 
            this.buttonModificarItem.Location = new System.Drawing.Point(1322, 275);
            this.buttonModificarItem.Name = "buttonModificarItem";
            this.buttonModificarItem.Size = new System.Drawing.Size(75, 23);
            this.buttonModificarItem.TabIndex = 15;
            this.buttonModificarItem.Text = "Modificar";
            this.buttonModificarItem.UseVisualStyleBackColor = true;
            this.buttonModificarItem.Click += new System.EventHandler(this.buttonModificarItem_Click);
            // 
            // FormItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 480);
            this.Controls.Add(this.buttonModificarItem);
            this.Controls.Add(this.buttonEliminarItem);
            this.Controls.Add(this.buttonElimarEfecto);
            this.Controls.Add(this.dataGridEfectos);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCant);
            this.Controls.Add(this.comboEfectos);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.dataGridItems);
            this.Controls.Add(this.buttonCreateItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormItem";
            this.Text = "FormItem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEfectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreateItem;
        private System.Windows.Forms.DataGridView dataGridItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEfectos;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.ComboBox comboEfectos;
        private System.Windows.Forms.TextBox textCant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.DataGridView dataGridEfectos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Efecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Button buttonElimarEfecto;
        private System.Windows.Forms.Button buttonEliminarItem;
        private System.Windows.Forms.Button buttonModificarItem;
    }
}