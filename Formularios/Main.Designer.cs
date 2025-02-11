namespace Hurren2
{
    partial class Main
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
            menuStrip1 = new MenuStrip();
            registroToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            listadoDeProductosToolStripMenuItem = new ToolStripMenuItem();
            articulosEnSubastaToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem = new ToolStripMenuItem();
            catalogoToolStripMenuItem = new ToolStripMenuItem();
            joyeriaToolStripMenuItem = new ToolStripMenuItem();
            electronicosToolStripMenuItem = new ToolStripMenuItem();
            utilidadesToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            sobreNosotrosToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registroToolStripMenuItem, aToolStripMenuItem, utilidadesToolStripMenuItem, ayudaToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            registroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, listadoDeProductosToolStripMenuItem, articulosEnSubastaToolStripMenuItem, clientesToolStripMenuItem });
            registroToolStripMenuItem.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registroToolStripMenuItem.Image = Properties.Resources.Registro;
            registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            registroToolStripMenuItem.ShowShortcutKeys = false;
            registroToolStripMenuItem.Size = new Size(89, 24);
            registroToolStripMenuItem.Text = "Registro";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Image = Properties.Resources.nuevo_usuario;
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(198, 22);
            usuarioToolStripMenuItem.Text = "Usuario";
            usuarioToolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // listadoDeProductosToolStripMenuItem
            // 
            listadoDeProductosToolStripMenuItem.Image = Properties.Resources.listado_de_producto;
            listadoDeProductosToolStripMenuItem.Name = "listadoDeProductosToolStripMenuItem";
            listadoDeProductosToolStripMenuItem.Size = new Size(198, 22);
            listadoDeProductosToolStripMenuItem.Text = "Listado de productos";
            listadoDeProductosToolStripMenuItem.Click += listadoDeProductosToolStripMenuItem_Click;
            // 
            // articulosEnSubastaToolStripMenuItem
            // 
            articulosEnSubastaToolStripMenuItem.Image = Properties.Resources.articulos_en_subastas;
            articulosEnSubastaToolStripMenuItem.Name = "articulosEnSubastaToolStripMenuItem";
            articulosEnSubastaToolStripMenuItem.Size = new Size(198, 22);
            articulosEnSubastaToolStripMenuItem.Text = "Articulos en subasta";
            articulosEnSubastaToolStripMenuItem.Click += articulosEnSubastaToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Image = Properties.Resources.comentario;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(198, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { catalogoToolStripMenuItem });
            aToolStripMenuItem.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aToolStripMenuItem.Image = Properties.Resources.articulo_web;
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(93, 24);
            aToolStripMenuItem.Text = "Articulos";
            // 
            // catalogoToolStripMenuItem
            // 
            catalogoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { joyeriaToolStripMenuItem, electronicosToolStripMenuItem });
            catalogoToolStripMenuItem.Image = Properties.Resources.folleto;
            catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            catalogoToolStripMenuItem.Size = new Size(133, 22);
            catalogoToolStripMenuItem.Text = "Categoria";
            // 
            // joyeriaToolStripMenuItem
            // 
            joyeriaToolStripMenuItem.Image = Properties.Resources.joyas;
            joyeriaToolStripMenuItem.Name = "joyeriaToolStripMenuItem";
            joyeriaToolStripMenuItem.Size = new Size(148, 22);
            joyeriaToolStripMenuItem.Text = "Joyeria";
            joyeriaToolStripMenuItem.Click += joyeriaToolStripMenuItem_Click;
            // 
            // electronicosToolStripMenuItem
            // 
            electronicosToolStripMenuItem.Image = Properties.Resources.placa_de_circuito;
            electronicosToolStripMenuItem.Name = "electronicosToolStripMenuItem";
            electronicosToolStripMenuItem.Size = new Size(148, 22);
            electronicosToolStripMenuItem.Text = "Electronicos";
            electronicosToolStripMenuItem.Click += electronicosToolStripMenuItem_Click;
            // 
            // utilidadesToolStripMenuItem
            // 
            utilidadesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraToolStripMenuItem });
            utilidadesToolStripMenuItem.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            utilidadesToolStripMenuItem.Image = Properties.Resources.herramientas_manuales;
            utilidadesToolStripMenuItem.Name = "utilidadesToolStripMenuItem";
            utilidadesToolStripMenuItem.Size = new Size(102, 24);
            utilidadesToolStripMenuItem.Text = "Utilidades ";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Image = Properties.Resources.calculadora;
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(146, 22);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreNosotrosToolStripMenuItem });
            ayudaToolStripMenuItem.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ayudaToolStripMenuItem.Image = Properties.Resources.seguridad_social;
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(78, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // sobreNosotrosToolStripMenuItem
            // 
            sobreNosotrosToolStripMenuItem.Image = Properties.Resources.sobre_nosotros;
            sobreNosotrosToolStripMenuItem.Name = "sobreNosotrosToolStripMenuItem";
            sobreNosotrosToolStripMenuItem.Size = new Size(163, 22);
            sobreNosotrosToolStripMenuItem.Text = "Sobre nosotros";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            salirToolStripMenuItem.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salirToolStripMenuItem.Image = Properties.Resources.salida_de_emergencia;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(66, 24);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1bb76ce6_31aa_4474_b93d_75c6710ec900;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem registroToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem catalogoToolStripMenuItem;
        private ToolStripMenuItem utilidadesToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem sobreNosotrosToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem listadoDeProductosToolStripMenuItem;
        private ToolStripMenuItem articulosEnSubastaToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem joyeriaToolStripMenuItem;
        private ToolStripMenuItem electronicosToolStripMenuItem;
    }
}