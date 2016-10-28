namespace Presentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageVentas = new System.Windows.Forms.TabPage();
            this.tabPageProductos = new System.Windows.Forms.TabPage();
            this.tabPageClientes = new System.Windows.Forms.TabPage();
            this.tabPageProveedores = new System.Windows.Forms.TabPage();
            this.tabPageFacturas = new System.Windows.Forms.TabPage();
            this.toolStripVentas = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAbrir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancela = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCerrar = new System.Windows.Forms.ToolStripButton();
            this.tabControlVentas = new System.Windows.Forms.TabControl();
            this.tabPageSeleccionarCliente = new System.Windows.Forms.TabPage();
            this.tabPageConfigurarPedido = new System.Windows.Forms.TabPage();
            this.splitContainerSeleccionarCliente = new System.Windows.Forms.SplitContainer();
            this.tabControlSeleccionarCliente = new System.Windows.Forms.TabControl();
            this.tabPageSeleccionarClienteIndividuo = new System.Windows.Forms.TabPage();
            this.tabPageSeleccionarClienteEmpresa = new System.Windows.Forms.TabPage();
            this.dataGridViewSeleccionarClienteIndividuo = new System.Windows.Forms.DataGridView();
            this.dataGridViewSeleccionarClienteEmpresa = new System.Windows.Forms.DataGridView();
            this.groupBoxClienteSeleccionado = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageVentas.SuspendLayout();
            this.toolStripVentas.SuspendLayout();
            this.tabControlVentas.SuspendLayout();
            this.tabPageSeleccionarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSeleccionarCliente)).BeginInit();
            this.splitContainerSeleccionarCliente.Panel1.SuspendLayout();
            this.splitContainerSeleccionarCliente.Panel2.SuspendLayout();
            this.splitContainerSeleccionarCliente.SuspendLayout();
            this.tabControlSeleccionarCliente.SuspendLayout();
            this.tabPageSeleccionarClienteIndividuo.SuspendLayout();
            this.tabPageSeleccionarClienteEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeleccionarClienteIndividuo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeleccionarClienteEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 392);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(576, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageVentas);
            this.tabControl1.Controls.Add(this.tabPageProductos);
            this.tabControl1.Controls.Add(this.tabPageClientes);
            this.tabControl1.Controls.Add(this.tabPageProveedores);
            this.tabControl1.Controls.Add(this.tabPageFacturas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 368);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageVentas
            // 
            this.tabPageVentas.Controls.Add(this.tabControlVentas);
            this.tabPageVentas.Controls.Add(this.toolStripVentas);
            this.tabPageVentas.Location = new System.Drawing.Point(4, 22);
            this.tabPageVentas.Name = "tabPageVentas";
            this.tabPageVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVentas.Size = new System.Drawing.Size(568, 342);
            this.tabPageVentas.TabIndex = 1;
            this.tabPageVentas.Text = "Ventas";
            this.tabPageVentas.UseVisualStyleBackColor = true;
            // 
            // tabPageProductos
            // 
            this.tabPageProductos.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductos.Name = "tabPageProductos";
            this.tabPageProductos.Size = new System.Drawing.Size(386, 276);
            this.tabPageProductos.TabIndex = 2;
            this.tabPageProductos.Text = "Productos";
            this.tabPageProductos.UseVisualStyleBackColor = true;
            // 
            // tabPageClientes
            // 
            this.tabPageClientes.Location = new System.Drawing.Point(4, 22);
            this.tabPageClientes.Name = "tabPageClientes";
            this.tabPageClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClientes.Size = new System.Drawing.Size(386, 276);
            this.tabPageClientes.TabIndex = 0;
            this.tabPageClientes.Text = "Clientes";
            this.tabPageClientes.UseVisualStyleBackColor = true;
            // 
            // tabPageProveedores
            // 
            this.tabPageProveedores.Location = new System.Drawing.Point(4, 22);
            this.tabPageProveedores.Name = "tabPageProveedores";
            this.tabPageProveedores.Size = new System.Drawing.Size(386, 276);
            this.tabPageProveedores.TabIndex = 3;
            this.tabPageProveedores.Text = "Proveedores";
            this.tabPageProveedores.UseVisualStyleBackColor = true;
            // 
            // tabPageFacturas
            // 
            this.tabPageFacturas.Location = new System.Drawing.Point(4, 22);
            this.tabPageFacturas.Name = "tabPageFacturas";
            this.tabPageFacturas.Size = new System.Drawing.Size(386, 276);
            this.tabPageFacturas.TabIndex = 4;
            this.tabPageFacturas.Text = "Facturas";
            this.tabPageFacturas.UseVisualStyleBackColor = true;
            // 
            // toolStripVentas
            // 
            this.toolStripVentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAbrir,
            this.toolStripButtonCancela,
            this.toolStripButtonCerrar});
            this.toolStripVentas.Location = new System.Drawing.Point(3, 3);
            this.toolStripVentas.Name = "toolStripVentas";
            this.toolStripVentas.Size = new System.Drawing.Size(562, 25);
            this.toolStripVentas.TabIndex = 0;
            this.toolStripVentas.Text = "toolStrip1";
            // 
            // toolStripButtonAbrir
            // 
            this.toolStripButtonAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAbrir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbrir.Image")));
            this.toolStripButtonAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbrir.Name = "toolStripButtonAbrir";
            this.toolStripButtonAbrir.Size = new System.Drawing.Size(37, 22);
            this.toolStripButtonAbrir.Text = "Abrir";
            this.toolStripButtonAbrir.ToolTipText = "Comienza una nueva transacción de venta.";
            // 
            // toolStripButtonCancela
            // 
            this.toolStripButtonCancela.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancela.Enabled = false;
            this.toolStripButtonCancela.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancela.Image")));
            this.toolStripButtonCancela.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancela.Name = "toolStripButtonCancela";
            this.toolStripButtonCancela.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancela.Text = "Cancelar";
            this.toolStripButtonCancela.ToolTipText = "Cancela una transacción de venta en curso.";
            // 
            // toolStripButtonCerrar
            // 
            this.toolStripButtonCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCerrar.Enabled = false;
            this.toolStripButtonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCerrar.Image")));
            this.toolStripButtonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCerrar.Name = "toolStripButtonCerrar";
            this.toolStripButtonCerrar.Size = new System.Drawing.Size(43, 22);
            this.toolStripButtonCerrar.Text = "Cerrar";
            this.toolStripButtonCerrar.ToolTipText = "Confirma la transacción de venta.";
            // 
            // tabControlVentas
            // 
            this.tabControlVentas.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlVentas.Controls.Add(this.tabPageSeleccionarCliente);
            this.tabControlVentas.Controls.Add(this.tabPageConfigurarPedido);
            this.tabControlVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlVentas.Location = new System.Drawing.Point(3, 28);
            this.tabControlVentas.Name = "tabControlVentas";
            this.tabControlVentas.SelectedIndex = 0;
            this.tabControlVentas.Size = new System.Drawing.Size(562, 311);
            this.tabControlVentas.TabIndex = 1;
            // 
            // tabPageSeleccionarCliente
            // 
            this.tabPageSeleccionarCliente.Controls.Add(this.splitContainerSeleccionarCliente);
            this.tabPageSeleccionarCliente.Location = new System.Drawing.Point(4, 4);
            this.tabPageSeleccionarCliente.Name = "tabPageSeleccionarCliente";
            this.tabPageSeleccionarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSeleccionarCliente.Size = new System.Drawing.Size(554, 285);
            this.tabPageSeleccionarCliente.TabIndex = 0;
            this.tabPageSeleccionarCliente.Text = "Seleccionar cliente";
            this.tabPageSeleccionarCliente.UseVisualStyleBackColor = true;
            // 
            // tabPageConfigurarPedido
            // 
            this.tabPageConfigurarPedido.Location = new System.Drawing.Point(4, 4);
            this.tabPageConfigurarPedido.Name = "tabPageConfigurarPedido";
            this.tabPageConfigurarPedido.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfigurarPedido.Size = new System.Drawing.Size(518, 225);
            this.tabPageConfigurarPedido.TabIndex = 1;
            this.tabPageConfigurarPedido.Text = "Configurar pedido";
            this.tabPageConfigurarPedido.UseVisualStyleBackColor = true;
            // 
            // splitContainerSeleccionarCliente
            // 
            this.splitContainerSeleccionarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSeleccionarCliente.Location = new System.Drawing.Point(3, 3);
            this.splitContainerSeleccionarCliente.Name = "splitContainerSeleccionarCliente";
            // 
            // splitContainerSeleccionarCliente.Panel1
            // 
            this.splitContainerSeleccionarCliente.Panel1.Controls.Add(this.tabControlSeleccionarCliente);
            // 
            // splitContainerSeleccionarCliente.Panel2
            // 
            this.splitContainerSeleccionarCliente.Panel2.Controls.Add(this.groupBoxClienteSeleccionado);
            this.splitContainerSeleccionarCliente.Size = new System.Drawing.Size(548, 279);
            this.splitContainerSeleccionarCliente.SplitterDistance = 182;
            this.splitContainerSeleccionarCliente.TabIndex = 0;
            // 
            // tabControlSeleccionarCliente
            // 
            this.tabControlSeleccionarCliente.Controls.Add(this.tabPageSeleccionarClienteIndividuo);
            this.tabControlSeleccionarCliente.Controls.Add(this.tabPageSeleccionarClienteEmpresa);
            this.tabControlSeleccionarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSeleccionarCliente.Location = new System.Drawing.Point(0, 0);
            this.tabControlSeleccionarCliente.Multiline = true;
            this.tabControlSeleccionarCliente.Name = "tabControlSeleccionarCliente";
            this.tabControlSeleccionarCliente.SelectedIndex = 0;
            this.tabControlSeleccionarCliente.Size = new System.Drawing.Size(182, 279);
            this.tabControlSeleccionarCliente.TabIndex = 0;
            // 
            // tabPageSeleccionarClienteIndividuo
            // 
            this.tabPageSeleccionarClienteIndividuo.Controls.Add(this.dataGridViewSeleccionarClienteIndividuo);
            this.tabPageSeleccionarClienteIndividuo.Location = new System.Drawing.Point(4, 22);
            this.tabPageSeleccionarClienteIndividuo.Name = "tabPageSeleccionarClienteIndividuo";
            this.tabPageSeleccionarClienteIndividuo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSeleccionarClienteIndividuo.Size = new System.Drawing.Size(162, 193);
            this.tabPageSeleccionarClienteIndividuo.TabIndex = 0;
            this.tabPageSeleccionarClienteIndividuo.Text = "Particular";
            this.tabPageSeleccionarClienteIndividuo.UseVisualStyleBackColor = true;
            // 
            // tabPageSeleccionarClienteEmpresa
            // 
            this.tabPageSeleccionarClienteEmpresa.Controls.Add(this.dataGridViewSeleccionarClienteEmpresa);
            this.tabPageSeleccionarClienteEmpresa.Location = new System.Drawing.Point(4, 22);
            this.tabPageSeleccionarClienteEmpresa.Name = "tabPageSeleccionarClienteEmpresa";
            this.tabPageSeleccionarClienteEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSeleccionarClienteEmpresa.Size = new System.Drawing.Size(174, 253);
            this.tabPageSeleccionarClienteEmpresa.TabIndex = 1;
            this.tabPageSeleccionarClienteEmpresa.Text = "Empresa";
            this.tabPageSeleccionarClienteEmpresa.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSeleccionarClienteIndividuo
            // 
            this.dataGridViewSeleccionarClienteIndividuo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeleccionarClienteIndividuo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSeleccionarClienteIndividuo.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSeleccionarClienteIndividuo.Name = "dataGridViewSeleccionarClienteIndividuo";
            this.dataGridViewSeleccionarClienteIndividuo.Size = new System.Drawing.Size(156, 187);
            this.dataGridViewSeleccionarClienteIndividuo.TabIndex = 0;
            // 
            // dataGridViewSeleccionarClienteEmpresa
            // 
            this.dataGridViewSeleccionarClienteEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeleccionarClienteEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSeleccionarClienteEmpresa.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSeleccionarClienteEmpresa.Name = "dataGridViewSeleccionarClienteEmpresa";
            this.dataGridViewSeleccionarClienteEmpresa.Size = new System.Drawing.Size(168, 247);
            this.dataGridViewSeleccionarClienteEmpresa.TabIndex = 0;
            // 
            // groupBoxClienteSeleccionado
            // 
            this.groupBoxClienteSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxClienteSeleccionado.Location = new System.Drawing.Point(26, 22);
            this.groupBoxClienteSeleccionado.Name = "groupBoxClienteSeleccionado";
            this.groupBoxClienteSeleccionado.Size = new System.Drawing.Size(317, 100);
            this.groupBoxClienteSeleccionado.TabIndex = 0;
            this.groupBoxClienteSeleccionado.TabStop = false;
            this.groupBoxClienteSeleccionado.Text = "Cliente seleccionado";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 414);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageVentas.ResumeLayout(false);
            this.tabPageVentas.PerformLayout();
            this.toolStripVentas.ResumeLayout(false);
            this.toolStripVentas.PerformLayout();
            this.tabControlVentas.ResumeLayout(false);
            this.tabPageSeleccionarCliente.ResumeLayout(false);
            this.splitContainerSeleccionarCliente.Panel1.ResumeLayout(false);
            this.splitContainerSeleccionarCliente.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSeleccionarCliente)).EndInit();
            this.splitContainerSeleccionarCliente.ResumeLayout(false);
            this.tabControlSeleccionarCliente.ResumeLayout(false);
            this.tabPageSeleccionarClienteIndividuo.ResumeLayout(false);
            this.tabPageSeleccionarClienteEmpresa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeleccionarClienteIndividuo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeleccionarClienteEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageClientes;
        private System.Windows.Forms.TabPage tabPageVentas;
        private System.Windows.Forms.TabPage tabPageProductos;
        private System.Windows.Forms.TabPage tabPageProveedores;
        private System.Windows.Forms.TabPage tabPageFacturas;
        private System.Windows.Forms.ToolStrip toolStripVentas;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbrir;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancela;
        private System.Windows.Forms.ToolStripButton toolStripButtonCerrar;
        private System.Windows.Forms.TabControl tabControlVentas;
        private System.Windows.Forms.TabPage tabPageSeleccionarCliente;
        private System.Windows.Forms.TabPage tabPageConfigurarPedido;
        private System.Windows.Forms.SplitContainer splitContainerSeleccionarCliente;
        private System.Windows.Forms.TabControl tabControlSeleccionarCliente;
        private System.Windows.Forms.TabPage tabPageSeleccionarClienteIndividuo;
        private System.Windows.Forms.TabPage tabPageSeleccionarClienteEmpresa;
        private System.Windows.Forms.DataGridView dataGridViewSeleccionarClienteIndividuo;
        private System.Windows.Forms.DataGridView dataGridViewSeleccionarClienteEmpresa;
        private System.Windows.Forms.GroupBox groupBoxClienteSeleccionado;
    }
}

