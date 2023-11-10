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
            this.SuspendLayout();
            // 
            // buttonInteractuar
            // 
            this.buttonInteractuar.Location = new System.Drawing.Point(335, 219);
            this.buttonInteractuar.Name = "buttonInteractuar";
            this.buttonInteractuar.Size = new System.Drawing.Size(85, 23);
            this.buttonInteractuar.TabIndex = 0;
            this.buttonInteractuar.Text = "Interactuar";
            this.buttonInteractuar.UseVisualStyleBackColor = true;
            this.buttonInteractuar.Click += new System.EventHandler(this.ButtonInteractuar_Click);
            // 
            // comboCriatura
            // 
            this.comboCriatura.FormattingEnabled = true;
            this.comboCriatura.Location = new System.Drawing.Point(131, 134);
            this.comboCriatura.Name = "comboCriatura";
            this.comboCriatura.Size = new System.Drawing.Size(158, 24);
            this.comboCriatura.TabIndex = 1;
            // 
            // comboItem
            // 
            this.comboItem.FormattingEnabled = true;
            this.comboItem.Location = new System.Drawing.Point(455, 134);
            this.comboItem.Name = "comboItem";
            this.comboItem.Size = new System.Drawing.Size(150, 24);
            this.comboItem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Criatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item";
            // 
            // FormItemPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboItem);
            this.Controls.Add(this.comboCriatura);
            this.Controls.Add(this.buttonInteractuar);
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
    }
}