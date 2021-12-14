namespace Skins4U
{
    partial class Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagos));
            this.btnMain = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblPrecioRP = new System.Windows.Forms.Label();
            this.lblPrecioReal = new System.Windows.Forms.Label();
            this.txtPrecioRP = new System.Windows.Forms.TextBox();
            this.txtPrecioMXN = new System.Windows.Forms.TextBox();
            this.lblEstados = new System.Windows.Forms.Label();
            this.CbbCuentas = new System.Windows.Forms.ComboBox();
            this.lblCuentas = new System.Windows.Forms.Label();
            this.lblComprador = new System.Windows.Forms.Label();
            this.lblInvocador = new System.Windows.Forms.Label();
            this.txtComprador = new System.Windows.Forms.TextBox();
            this.txtInvocador = new System.Windows.Forms.TextBox();
            this.lblPlataforma = new System.Windows.Forms.Label();
            this.txtPlataforma = new System.Windows.Forms.TextBox();
            this.btnPrecios = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(885, 507);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(150, 60);
            this.btnMain.TabIndex = 10;
            this.btnMain.Text = "Lobby General";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.Location = new System.Drawing.Point(92, 507);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(150, 60);
            this.btnConfirma.TabIndex = 9;
            this.btnConfirma.Text = "Realiza el pago";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(125, 56);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(195, 25);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto Adquirido";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(101, 111);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtProducto.Size = new System.Drawing.Size(250, 31);
            this.txtProducto.TabIndex = 1;
            // 
            // lblPrecioRP
            // 
            this.lblPrecioRP.AutoSize = true;
            this.lblPrecioRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioRP.Location = new System.Drawing.Point(451, 56);
            this.lblPrecioRP.Name = "lblPrecioRP";
            this.lblPrecioRP.Size = new System.Drawing.Size(138, 25);
            this.lblPrecioRP.TabIndex = 4;
            this.lblPrecioRP.Text = "Precio en RP";
            // 
            // lblPrecioReal
            // 
            this.lblPrecioReal.AutoSize = true;
            this.lblPrecioReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioReal.Location = new System.Drawing.Point(390, 167);
            this.lblPrecioReal.Name = "lblPrecioReal";
            this.lblPrecioReal.Size = new System.Drawing.Size(277, 25);
            this.lblPrecioReal.TabIndex = 5;
            this.lblPrecioReal.Text = "Precio en pesos Mexicanos";
            // 
            // txtPrecioRP
            // 
            this.txtPrecioRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioRP.Location = new System.Drawing.Point(466, 111);
            this.txtPrecioRP.Name = "txtPrecioRP";
            this.txtPrecioRP.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPrecioRP.Size = new System.Drawing.Size(104, 31);
            this.txtPrecioRP.TabIndex = 2;
            this.txtPrecioRP.TextChanged += new System.EventHandler(this.txtPrecioRP_TextChanged);
            // 
            // txtPrecioMXN
            // 
            this.txtPrecioMXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioMXN.Location = new System.Drawing.Point(466, 212);
            this.txtPrecioMXN.Name = "txtPrecioMXN";
            this.txtPrecioMXN.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPrecioMXN.Size = new System.Drawing.Size(104, 31);
            this.txtPrecioMXN.TabIndex = 3;
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstados.Location = new System.Drawing.Point(87, 442);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(0, 25);
            this.lblEstados.TabIndex = 8;
            // 
            // CbbCuentas
            // 
            this.CbbCuentas.FormattingEnabled = true;
            this.CbbCuentas.ItemHeight = 13;
            this.CbbCuentas.Location = new System.Drawing.Point(144, 222);
            this.CbbCuentas.Name = "CbbCuentas";
            this.CbbCuentas.Size = new System.Drawing.Size(160, 21);
            this.CbbCuentas.TabIndex = 8;
            // 
            // lblCuentas
            // 
            this.lblCuentas.AutoSize = true;
            this.lblCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentas.Location = new System.Drawing.Point(125, 167);
            this.lblCuentas.Name = "lblCuentas";
            this.lblCuentas.Size = new System.Drawing.Size(212, 25);
            this.lblCuentas.TabIndex = 10;
            this.lblCuentas.Text = "Selecciona la cuenta";
            // 
            // lblComprador
            // 
            this.lblComprador.AutoSize = true;
            this.lblComprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprador.Location = new System.Drawing.Point(791, 56);
            this.lblComprador.Name = "lblComprador";
            this.lblComprador.Size = new System.Drawing.Size(118, 25);
            this.lblComprador.TabIndex = 11;
            this.lblComprador.Text = "Comprador";
            // 
            // lblInvocador
            // 
            this.lblInvocador.AutoSize = true;
            this.lblInvocador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvocador.Location = new System.Drawing.Point(803, 167);
            this.lblInvocador.Name = "lblInvocador";
            this.lblInvocador.Size = new System.Drawing.Size(106, 25);
            this.lblInvocador.TabIndex = 12;
            this.lblInvocador.Text = "Invocador";
            // 
            // txtComprador
            // 
            this.txtComprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComprador.Location = new System.Drawing.Point(734, 111);
            this.txtComprador.Name = "txtComprador";
            this.txtComprador.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtComprador.Size = new System.Drawing.Size(257, 31);
            this.txtComprador.TabIndex = 4;
            // 
            // txtInvocador
            // 
            this.txtInvocador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvocador.Location = new System.Drawing.Point(734, 212);
            this.txtInvocador.Name = "txtInvocador";
            this.txtInvocador.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtInvocador.Size = new System.Drawing.Size(257, 31);
            this.txtInvocador.TabIndex = 5;
            // 
            // lblPlataforma
            // 
            this.lblPlataforma.AutoSize = true;
            this.lblPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlataforma.Location = new System.Drawing.Point(803, 278);
            this.lblPlataforma.Name = "lblPlataforma";
            this.lblPlataforma.Size = new System.Drawing.Size(115, 25);
            this.lblPlataforma.TabIndex = 13;
            this.lblPlataforma.Text = "Plataforma";
            // 
            // txtPlataforma
            // 
            this.txtPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlataforma.Location = new System.Drawing.Point(734, 324);
            this.txtPlataforma.Name = "txtPlataforma";
            this.txtPlataforma.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPlataforma.Size = new System.Drawing.Size(257, 31);
            this.txtPlataforma.TabIndex = 6;
            // 
            // btnPrecios
            // 
            this.btnPrecios.Enabled = false;
            this.btnPrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecios.Location = new System.Drawing.Point(444, 507);
            this.btnPrecios.Name = "btnPrecios";
            this.btnPrecios.Size = new System.Drawing.Size(173, 60);
            this.btnPrecios.TabIndex = 11;
            this.btnPrecios.Text = "Checar precios";
            this.btnPrecios.UseVisualStyleBackColor = true;
            this.btnPrecios.Click += new System.EventHandler(this.btnPrecioSkins_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(420, 278);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(181, 25);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "Fecha de entrega";
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(395, 324);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtFecha.Size = new System.Drawing.Size(250, 31);
            this.txtFecha.TabIndex = 7;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 597);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnPrecios);
            this.Controls.Add(this.txtPlataforma);
            this.Controls.Add(this.lblPlataforma);
            this.Controls.Add(this.txtInvocador);
            this.Controls.Add(this.txtComprador);
            this.Controls.Add(this.lblInvocador);
            this.Controls.Add(this.lblComprador);
            this.Controls.Add(this.lblCuentas);
            this.Controls.Add(this.CbbCuentas);
            this.Controls.Add(this.lblEstados);
            this.Controls.Add(this.txtPrecioMXN);
            this.Controls.Add(this.txtPrecioRP);
            this.Controls.Add(this.lblPrecioReal);
            this.Controls.Add(this.lblPrecioRP);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.btnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblPrecioRP;
        private System.Windows.Forms.Label lblPrecioReal;
        private System.Windows.Forms.TextBox txtPrecioRP;
        private System.Windows.Forms.TextBox txtPrecioMXN;
        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.ComboBox CbbCuentas;
        private System.Windows.Forms.Label lblCuentas;
        private System.Windows.Forms.Label lblComprador;
        private System.Windows.Forms.Label lblInvocador;
        private System.Windows.Forms.TextBox txtComprador;
        private System.Windows.Forms.TextBox txtInvocador;
        private System.Windows.Forms.Label lblPlataforma;
        private System.Windows.Forms.TextBox txtPlataforma;
        private System.Windows.Forms.Button btnPrecios;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
    }
}