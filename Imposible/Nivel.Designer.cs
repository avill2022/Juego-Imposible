namespace Imposible
{
    partial class Nivel
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new System.Windows.Forms.Button();
            this.Facil = new System.Windows.Forms.RadioButton();
            this.Intermedio = new System.Windows.Forms.RadioButton();
            this.Dificil = new System.Windows.Forms.RadioButton();
            this.Imposible = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(158, 207);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 25;
            this.okButton.Text = "&Aceptar";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Facil
            // 
            this.Facil.AutoSize = true;
            this.Facil.Location = new System.Drawing.Point(36, 57);
            this.Facil.Name = "Facil";
            this.Facil.Size = new System.Drawing.Size(47, 17);
            this.Facil.TabIndex = 26;
            this.Facil.TabStop = true;
            this.Facil.Text = "Facil";
            this.Facil.UseVisualStyleBackColor = true;
            this.Facil.Click += new System.EventHandler(this.Facil_Click);
            // 
            // Intermedio
            // 
            this.Intermedio.AutoSize = true;
            this.Intermedio.Location = new System.Drawing.Point(36, 92);
            this.Intermedio.Name = "Intermedio";
            this.Intermedio.Size = new System.Drawing.Size(74, 17);
            this.Intermedio.TabIndex = 27;
            this.Intermedio.TabStop = true;
            this.Intermedio.Text = "Intermedio";
            this.Intermedio.UseVisualStyleBackColor = true;
            this.Intermedio.Click += new System.EventHandler(this.Intermedio_Click);
            // 
            // Dificil
            // 
            this.Dificil.AutoSize = true;
            this.Dificil.Location = new System.Drawing.Point(36, 128);
            this.Dificil.Name = "Dificil";
            this.Dificil.Size = new System.Drawing.Size(50, 17);
            this.Dificil.TabIndex = 28;
            this.Dificil.TabStop = true;
            this.Dificil.Text = "Dificil";
            this.Dificil.UseVisualStyleBackColor = true;
            this.Dificil.Click += new System.EventHandler(this.Dificil_Click);
            // 
            // Imposible
            // 
            this.Imposible.AutoSize = true;
            this.Imposible.Location = new System.Drawing.Point(36, 162);
            this.Imposible.Name = "Imposible";
            this.Imposible.Size = new System.Drawing.Size(69, 17);
            this.Imposible.TabIndex = 29;
            this.Imposible.TabStop = true;
            this.Imposible.Text = "Imposible";
            this.Imposible.UseVisualStyleBackColor = true;
            this.Imposible.Click += new System.EventHandler(this.Imposible_Click);
            // 
            // Nivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 242);
            this.Controls.Add(this.Imposible);
            this.Controls.Add(this.Dificil);
            this.Controls.Add(this.Intermedio);
            this.Controls.Add(this.Facil);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Nivel";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nivel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.RadioButton Facil;
        private System.Windows.Forms.RadioButton Intermedio;
        private System.Windows.Forms.RadioButton Dificil;
        private System.Windows.Forms.RadioButton Imposible;

    }
}
