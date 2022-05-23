namespace Imposible
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.juegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.estadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.opciones = new System.Windows.Forms.ToolStripMenuItem();
            this.dificultad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.solucionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevoJuego = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeImposibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.juegoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 289);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(302, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // juegoToolStripMenuItem
            // 
            this.juegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.toolStripSeparator3,
            this.estadisticas,
            this.opciones,
            this.dificultad,
            this.toolStripSeparator2,
            this.solucionarToolStripMenuItem,
            this.deshacer,
            this.toolStripSeparator1,
            this.nuevoJuego});
            this.juegoToolStripMenuItem.Name = "juegoToolStripMenuItem";
            this.juegoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.juegoToolStripMenuItem.Text = "Juego";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // estadisticas
            // 
            this.estadisticas.Name = "estadisticas";
            this.estadisticas.Size = new System.Drawing.Size(152, 22);
            this.estadisticas.Text = "Estadisticas";
            this.estadisticas.Click += new System.EventHandler(this.estadisticas_Click);
            // 
            // opciones
            // 
            this.opciones.Name = "opciones";
            this.opciones.Size = new System.Drawing.Size(152, 22);
            this.opciones.Text = "Opciones";
            this.opciones.Click += new System.EventHandler(this.opciones_Click);
            // 
            // dificultad
            // 
            this.dificultad.Name = "dificultad";
            this.dificultad.Size = new System.Drawing.Size(152, 22);
            this.dificultad.Text = "Dificultad";
            this.dificultad.Click += new System.EventHandler(this.dificultad_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // solucionarToolStripMenuItem
            // 
            this.solucionarToolStripMenuItem.Name = "solucionarToolStripMenuItem";
            this.solucionarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.solucionarToolStripMenuItem.Text = "Solucionar";
            this.solucionarToolStripMenuItem.Click += new System.EventHandler(this.solucionarToolStripMenuItem_Click);
            // 
            // deshacer
            // 
            this.deshacer.Name = "deshacer";
            this.deshacer.Size = new System.Drawing.Size(152, 22);
            this.deshacer.Text = "Deshacer";
            this.deshacer.Click += new System.EventHandler(this.deshacer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // nuevoJuego
            // 
            this.nuevoJuego.Name = "nuevoJuego";
            this.nuevoJuego.Size = new System.Drawing.Size(152, 22);
            this.nuevoJuego.Text = "Nuevo Juego";
            this.nuevoJuego.Click += new System.EventHandler(this.nuevoJuego_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeImposibleToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeImposibleToolStripMenuItem
            // 
            this.acercaDeImposibleToolStripMenuItem.Name = "acercaDeImposibleToolStripMenuItem";
            this.acercaDeImposibleToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.acercaDeImposibleToolStripMenuItem.Text = "Acerca de Imposible";
            this.acercaDeImposibleToolStripMenuItem.Click += new System.EventHandler(this.acercaDeImposibleToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(242, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "0:0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(127, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Movimientos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 313);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Imposible";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem juegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem estadisticas;
        private System.Windows.Forms.ToolStripMenuItem opciones;
        private System.Windows.Forms.ToolStripMenuItem dificultad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deshacer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem nuevoJuego;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeImposibleToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem solucionarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

