namespace Tp3_FrancoRuggiero
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbColumnas = new System.Windows.Forms.ComboBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.ContextMenuStrip = this.contextMenuStrip1;
            this.grdDatos.Location = new System.Drawing.Point(-1, 107);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.Size = new System.Drawing.Size(800, 340);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellContentClick);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblProducts.Location = new System.Drawing.Point(12, 9);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(179, 24);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Total Productos: 0";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.Lime;
            this.lblMarca.Location = new System.Drawing.Point(12, 31);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(152, 24);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Total Marcas: 0";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbFiltro.ForeColor = System.Drawing.Color.Navy;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "All",
            "CoD_ALFA",
            "Codigo",
            "Detalle",
            "Rubro",
            "Subrubro",
            "Modelo",
            "NoM_Marca",
            "Marca",
            "Serie",
            "PlantI_Rec",
            "Cuenta",
            "Cta_Costo",
            "Cta_Mercad",
            "Cta_Ajupos",
            "Cta_Ajuneg",
            "Cta_Ajuint"});
            this.cmbFiltro.Location = new System.Drawing.Point(667, 12);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 4;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sobre que columna desea realizar un filtro?";
            // 
            // cmbColumnas
            // 
            this.cmbColumnas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbColumnas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbColumnas.ForeColor = System.Drawing.Color.Purple;
            this.cmbColumnas.FormattingEnabled = true;
            this.cmbColumnas.Items.AddRange(new object[] {
            "All",
            "CoD_ALFA",
            "Codigo",
            "Detalle",
            "Rubro",
            "Subrubro",
            "Modelo",
            "NoM_Marca",
            "Marca",
            "Serie",
            "PlantI_Rec",
            "Cuenta",
            "Cta_Costo",
            "Cta_Mercad",
            "Cta_Ajupos",
            "Cta_Ajuneg",
            "Cta_Ajuint"});
            this.cmbColumnas.Location = new System.Drawing.Point(667, 39);
            this.cmbColumnas.Name = "cmbColumnas";
            this.cmbColumnas.Size = new System.Drawing.Size(121, 21);
            this.cmbColumnas.TabIndex = 6;
            this.cmbColumnas.Visible = false;
            this.cmbColumnas.SelectedIndexChanged += new System.EventHandler(this.cmbColumnas_SelectedIndexChanged);
            // 
            // lblChange
            // 
            this.lblChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(517, 42);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(56, 13);
            this.lblChange.TabIndex = 7;
            this.lblChange.Text = "Filtrar por :";
            this.lblChange.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarHTMLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 26);
            // 
            // exportarHTMLToolStripMenuItem
            // 
            this.exportarHTMLToolStripMenuItem.Name = "exportarHTMLToolStripMenuItem";
            this.exportarHTMLToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exportarHTMLToolStripMenuItem.Text = "Exportar HTML";
            this.exportarHTMLToolStripMenuItem.Click += new System.EventHandler(this.exportarHTMLToolStripMenuItem_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.cmbColumnas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.grdDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbColumnas;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportarHTMLToolStripMenuItem;
    }
}

