namespace Fdsmlfr
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.buttonCriatura = new System.Windows.Forms.Button();
            this.buttonComida = new System.Windows.Forms.Button();
            this.buttonLucha = new System.Windows.Forms.Button();
            this.buttonItem = new System.Windows.Forms.Button();
            this.buttonUsarItem = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            this.buttonComer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCriatura
            // 
            resources.ApplyResources(this.buttonCriatura, "buttonCriatura");
            this.buttonCriatura.Name = "buttonCriatura";
            this.buttonCriatura.UseVisualStyleBackColor = true;
            this.buttonCriatura.Click += new System.EventHandler(this.buttonCriatura_Click);
            // 
            // buttonComida
            // 
            resources.ApplyResources(this.buttonComida, "buttonComida");
            this.buttonComida.Name = "buttonComida";
            this.buttonComida.UseVisualStyleBackColor = true;
            this.buttonComida.Click += new System.EventHandler(this.buttonComida_Click);
            // 
            // buttonLucha
            // 
            resources.ApplyResources(this.buttonLucha, "buttonLucha");
            this.buttonLucha.Name = "buttonLucha";
            this.buttonLucha.UseVisualStyleBackColor = true;
            this.buttonLucha.Click += new System.EventHandler(this.buttonLucha_Click);
            // 
            // buttonItem
            // 
            resources.ApplyResources(this.buttonItem, "buttonItem");
            this.buttonItem.Name = "buttonItem";
            this.buttonItem.UseVisualStyleBackColor = true;
            this.buttonItem.Click += new System.EventHandler(this.buttonItem_Click);
            // 
            // buttonUsarItem
            // 
            resources.ApplyResources(this.buttonUsarItem, "buttonUsarItem");
            this.buttonUsarItem.Name = "buttonUsarItem";
            this.buttonUsarItem.UseVisualStyleBackColor = true;
            this.buttonUsarItem.Click += new System.EventHandler(this.buttonUsarItem_Click);
            // 
            // buttonVolver
            // 
            resources.ApplyResources(this.buttonVolver, "buttonVolver");
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            // 
            // pictureBoxAdmin
            // 
            resources.ApplyResources(this.pictureBoxAdmin, "pictureBoxAdmin");
            this.pictureBoxAdmin.Name = "pictureBoxAdmin";
            this.pictureBoxAdmin.TabStop = false;
            // 
            // buttonComer
            // 
            resources.ApplyResources(this.buttonComer, "buttonComer");
            this.buttonComer.Name = "buttonComer";
            this.buttonComer.UseVisualStyleBackColor = true;
            this.buttonComer.Click += new System.EventHandler(this.buttonComer_Click);
            // 
            // FormAdmin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonComer);
            this.Controls.Add(this.pictureBoxAdmin);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonUsarItem);
            this.Controls.Add(this.buttonItem);
            this.Controls.Add(this.buttonLucha);
            this.Controls.Add(this.buttonComida);
            this.Controls.Add(this.buttonCriatura);
            this.Name = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCriatura;
        private System.Windows.Forms.Button buttonComida;
        private System.Windows.Forms.Button buttonLucha;
        private System.Windows.Forms.Button buttonItem;
        private System.Windows.Forms.Button buttonUsarItem;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.PictureBox pictureBoxAdmin;
        private System.Windows.Forms.Button buttonComer;
    }
}