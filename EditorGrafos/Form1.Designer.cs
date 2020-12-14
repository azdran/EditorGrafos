namespace EditorGrafos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafo1ToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafo1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moverNodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dirigidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noDirigidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adyacenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafo1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafo1ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.nodoToolStripMenuItem,
            this.aristaToolStripMenuItem,
            this.matrizToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafo1ToolStripMenuItem10});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // grafo1ToolStripMenuItem10
            // 
            this.grafo1ToolStripMenuItem10.Name = "grafo1ToolStripMenuItem10";
            this.grafo1ToolStripMenuItem10.Size = new System.Drawing.Size(112, 22);
            this.grafo1ToolStripMenuItem10.Text = "Grafo 1";
            this.grafo1ToolStripMenuItem10.Click += new System.EventHandler(this.grafo1ToolStripMenuItem10_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafo1ToolStripMenuItem1});
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            // 
            // grafo1ToolStripMenuItem1
            // 
            this.grafo1ToolStripMenuItem1.Name = "grafo1ToolStripMenuItem1";
            this.grafo1ToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.grafo1ToolStripMenuItem1.Text = "Grafo 1";
            this.grafo1ToolStripMenuItem1.Click += new System.EventHandler(this.grafo1ToolStripMenuItem1_Click);
            // 
            // nodoToolStripMenuItem
            // 
            this.nodoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.moverToolStripMenuItem,
            this.moverNodoToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.nodoToolStripMenuItem.Name = "nodoToolStripMenuItem";
            this.nodoToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.nodoToolStripMenuItem.Text = "Nodo";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafo1ToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // grafo1ToolStripMenuItem
            // 
            this.grafo1ToolStripMenuItem.Name = "grafo1ToolStripMenuItem";
            this.grafo1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grafo1ToolStripMenuItem.Text = "Grafo 1";
            this.grafo1ToolStripMenuItem.Click += new System.EventHandler(this.grafo1ToolStripMenuItem_Click);
            // 
            // moverToolStripMenuItem
            // 
            this.moverToolStripMenuItem.Name = "moverToolStripMenuItem";
            this.moverToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moverToolStripMenuItem.Text = "Mover todo";
            this.moverToolStripMenuItem.Click += new System.EventHandler(this.moverToolStripMenuItem_Click);
            // 
            // moverNodoToolStripMenuItem
            // 
            this.moverNodoToolStripMenuItem.Name = "moverNodoToolStripMenuItem";
            this.moverNodoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moverNodoToolStripMenuItem.Text = "Mover nodo";
            this.moverNodoToolStripMenuItem.Click += new System.EventHandler(this.moverNodoToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // aristaToolStripMenuItem
            // 
            this.aristaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dirigidaToolStripMenuItem,
            this.noDirigidaToolStripMenuItem,
            this.eliminarToolStripMenuItem1});
            this.aristaToolStripMenuItem.Name = "aristaToolStripMenuItem";
            this.aristaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.aristaToolStripMenuItem.Text = "Arista";
            // 
            // dirigidaToolStripMenuItem
            // 
            this.dirigidaToolStripMenuItem.Name = "dirigidaToolStripMenuItem";
            this.dirigidaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dirigidaToolStripMenuItem.Text = "Dirigida";
            this.dirigidaToolStripMenuItem.Click += new System.EventHandler(this.dirigidaToolStripMenuItem_Click);
            // 
            // noDirigidaToolStripMenuItem
            // 
            this.noDirigidaToolStripMenuItem.Name = "noDirigidaToolStripMenuItem";
            this.noDirigidaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.noDirigidaToolStripMenuItem.Text = "No dirigida";
            this.noDirigidaToolStripMenuItem.Click += new System.EventHandler(this.noDirigidaToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // matrizToolStripMenuItem
            // 
            this.matrizToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adyacenciaToolStripMenuItem,
            this.pesoToolStripMenuItem});
            this.matrizToolStripMenuItem.Name = "matrizToolStripMenuItem";
            this.matrizToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.matrizToolStripMenuItem.Text = "Matriz";
            // 
            // adyacenciaToolStripMenuItem
            // 
            this.adyacenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafo1ToolStripMenuItem2});
            this.adyacenciaToolStripMenuItem.Name = "adyacenciaToolStripMenuItem";
            this.adyacenciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adyacenciaToolStripMenuItem.Text = "Adyacencia";
            this.adyacenciaToolStripMenuItem.Click += new System.EventHandler(this.adyacenciaToolStripMenuItem_Click);
            // 
            // grafo1ToolStripMenuItem2
            // 
            this.grafo1ToolStripMenuItem2.Name = "grafo1ToolStripMenuItem2";
            this.grafo1ToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.grafo1ToolStripMenuItem2.Text = "Grafo 1";
            this.grafo1ToolStripMenuItem2.Click += new System.EventHandler(this.grafo1ToolStripMenuItem2_Click);
            // 
            // pesoToolStripMenuItem
            // 
            this.pesoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafo1ToolStripMenuItem3});
            this.pesoToolStripMenuItem.Name = "pesoToolStripMenuItem";
            this.pesoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pesoToolStripMenuItem.Text = "Peso";
            // 
            // grafo1ToolStripMenuItem3
            // 
            this.grafo1ToolStripMenuItem3.Name = "grafo1ToolStripMenuItem3";
            this.grafo1ToolStripMenuItem3.Size = new System.Drawing.Size(112, 22);
            this.grafo1ToolStripMenuItem3.Text = "Grafo 1";
            this.grafo1ToolStripMenuItem3.Click += new System.EventHandler(this.grafo1ToolStripMenuItem3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(994, 713);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dirigidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noDirigidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem grafo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafo1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem matrizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adyacenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafo1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem moverNodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafo1ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem grafo1ToolStripMenuItem10;
    }
}

