namespace Fdsmlfr
{
    partial class FormHome
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
            this.buttonCriatura = new System.Windows.Forms.Button();
            this.buttonComida = new System.Windows.Forms.Button();
            this.buttonLucha = new System.Windows.Forms.Button();
            this.buttonItem = new System.Windows.Forms.Button();
            this.buttonUsarItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCriatura
            // 
            this.buttonCriatura.Location = new System.Drawing.Point(78, 62);
            this.buttonCriatura.Name = "buttonCriatura";
            this.buttonCriatura.Size = new System.Drawing.Size(182, 23);
            this.buttonCriatura.TabIndex = 0;
            this.buttonCriatura.Text = "Crear Criaturas";
            this.buttonCriatura.UseVisualStyleBackColor = true;
            this.buttonCriatura.Click += new System.EventHandler(this.buttonCriatura_Click);
            // 
            // buttonComida
            // 
            this.buttonComida.Location = new System.Drawing.Point(78, 103);
            this.buttonComida.Name = "buttonComida";
            this.buttonComida.Size = new System.Drawing.Size(182, 23);
            this.buttonComida.TabIndex = 1;
            this.buttonComida.Text = "Crear Comida";
            this.buttonComida.UseVisualStyleBackColor = true;
            this.buttonComida.Click += new System.EventHandler(this.buttonComida_Click);
            // 
            // buttonLucha
            // 
            this.buttonLucha.Location = new System.Drawing.Point(78, 149);
            this.buttonLucha.Name = "buttonLucha";
            this.buttonLucha.Size = new System.Drawing.Size(182, 23);
            this.buttonLucha.TabIndex = 2;
            this.buttonLucha.Text = "Lucha";
            this.buttonLucha.UseVisualStyleBackColor = true;
            this.buttonLucha.Click += new System.EventHandler(this.buttonLucha_Click);
            // 
            // buttonItem
            // 
            this.buttonItem.Location = new System.Drawing.Point(78, 198);
            this.buttonItem.Name = "buttonItem";
            this.buttonItem.Size = new System.Drawing.Size(182, 23);
            this.buttonItem.TabIndex = 3;
            this.buttonItem.Text = "Crear Item";
            this.buttonItem.UseVisualStyleBackColor = true;
            this.buttonItem.Click += new System.EventHandler(this.buttonItem_Click);
            // 
            // buttonUsarItem
            // 
            this.buttonUsarItem.Location = new System.Drawing.Point(78, 247);
            this.buttonUsarItem.Name = "buttonUsarItem";
            this.buttonUsarItem.Size = new System.Drawing.Size(182, 23);
            this.buttonUsarItem.TabIndex = 4;
            this.buttonUsarItem.Text = "Usar Item";
            this.buttonUsarItem.UseVisualStyleBackColor = true;
            this.buttonUsarItem.Click += new System.EventHandler(this.buttonUsarItem_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUsarItem);
            this.Controls.Add(this.buttonItem);
            this.Controls.Add(this.buttonLucha);
            this.Controls.Add(this.buttonComida);
            this.Controls.Add(this.buttonCriatura);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCriatura;
        private System.Windows.Forms.Button buttonComida;
        private System.Windows.Forms.Button buttonLucha;
        private System.Windows.Forms.Button buttonItem;
        private System.Windows.Forms.Button buttonUsarItem;
    }
}