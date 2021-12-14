namespace Skins4U
{
    partial class Manejo_cuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manejo_cuentas));
            this.btnMain = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dGVCuentas = new System.Windows.Forms.DataGridView();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.lblNick = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblVendedorelim = new System.Windows.Forms.Label();
            this.lblNombre_elim = new System.Windows.Forms.Label();
            this.txtNick_elim = new System.Windows.Forms.TextBox();
            this.btnAceptar_Elim = new System.Windows.Forms.Button();
            this.CBRegiones = new System.Windows.Forms.ComboBox();
            this.lblExeption = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnSaldosUp = new System.Windows.Forms.Button();
            this.txtNickUp = new System.Windows.Forms.TextBox();
            this.lblNickUp = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblSaldoUp = new System.Windows.Forms.Label();
            this.txtSaldoUp = new System.Windows.Forms.TextBox();
            this.btnUndo_Elim = new System.Windows.Forms.Button();
            this.btnUndo_Up = new System.Windows.Forms.Button();
            this.btnUndo_Insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(912, 501);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(150, 60);
            this.btnMain.TabIndex = 11;
            this.btnMain.Text = "Lobby General";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(72, 373);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 60);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dGVCuentas
            // 
            this.dGVCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCuentas.Location = new System.Drawing.Point(678, 34);
            this.dGVCuentas.Name = "dGVCuentas";
            this.dGVCuentas.Size = new System.Drawing.Size(384, 387);
            this.dGVCuentas.TabIndex = 3;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(53, 64);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(180, 25);
            this.lblVendedor.TabIndex = 4;
            this.lblVendedor.Text = "Agrega Vendedor";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(54, 140);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(195, 20);
            this.txtNick.TabIndex = 1;
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNick.Location = new System.Drawing.Point(126, 105);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(54, 25);
            this.lblNick.TabIndex = 6;
            this.lblNick.Text = "Nick";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(113, 181);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(67, 25);
            this.lblSaldo.TabIndex = 7;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(54, 225);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(195, 20);
            this.txtSaldo.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(678, 501);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 60);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Actualiza";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblVendedorelim
            // 
            this.lblVendedorelim.AutoSize = true;
            this.lblVendedorelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorelim.Location = new System.Drawing.Point(348, 64);
            this.lblVendedorelim.Name = "lblVendedorelim";
            this.lblVendedorelim.Size = new System.Drawing.Size(181, 25);
            this.lblVendedorelim.TabIndex = 10;
            this.lblVendedorelim.Text = "Elimina Vendedor";
            // 
            // lblNombre_elim
            // 
            this.lblNombre_elim.AutoSize = true;
            this.lblNombre_elim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre_elim.Location = new System.Drawing.Point(412, 105);
            this.lblNombre_elim.Name = "lblNombre_elim";
            this.lblNombre_elim.Size = new System.Drawing.Size(54, 25);
            this.lblNombre_elim.TabIndex = 11;
            this.lblNombre_elim.Text = "Nick";
            // 
            // txtNick_elim
            // 
            this.txtNick_elim.Location = new System.Drawing.Point(337, 140);
            this.txtNick_elim.Name = "txtNick_elim";
            this.txtNick_elim.Size = new System.Drawing.Size(195, 20);
            this.txtNick_elim.TabIndex = 5;
            // 
            // btnAceptar_Elim
            // 
            this.btnAceptar_Elim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar_Elim.Location = new System.Drawing.Point(362, 166);
            this.btnAceptar_Elim.Name = "btnAceptar_Elim";
            this.btnAceptar_Elim.Size = new System.Drawing.Size(150, 60);
            this.btnAceptar_Elim.TabIndex = 6;
            this.btnAceptar_Elim.Text = "Aceptar";
            this.btnAceptar_Elim.UseVisualStyleBackColor = true;
            this.btnAceptar_Elim.Click += new System.EventHandler(this.btnAceptar_Elim_Click);
            // 
            // CBRegiones
            // 
            this.CBRegiones.FormattingEnabled = true;
            this.CBRegiones.Location = new System.Drawing.Point(283, 16);
            this.CBRegiones.Name = "CBRegiones";
            this.CBRegiones.Size = new System.Drawing.Size(139, 21);
            this.CBRegiones.TabIndex = 16;
            // 
            // lblExeption
            // 
            this.lblExeption.AutoSize = true;
            this.lblExeption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExeption.Location = new System.Drawing.Point(39, 536);
            this.lblExeption.Name = "lblExeption";
            this.lblExeption.Size = new System.Drawing.Size(0, 25);
            this.lblExeption.TabIndex = 17;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.Location = new System.Drawing.Point(179, 12);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(98, 25);
            this.lblRegion.TabIndex = 19;
            this.lblRegion.Text = "Servidor:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(54, 315);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(195, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(104, 266);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(86, 25);
            this.lblUsuario.TabIndex = 20;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnSaldosUp
            // 
            this.btnSaldosUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaldosUp.Location = new System.Drawing.Point(362, 452);
            this.btnSaldosUp.Name = "btnSaldosUp";
            this.btnSaldosUp.Size = new System.Drawing.Size(150, 60);
            this.btnSaldosUp.TabIndex = 9;
            this.btnSaldosUp.Text = "Aceptar";
            this.btnSaldosUp.UseVisualStyleBackColor = true;
            this.btnSaldosUp.Click += new System.EventHandler(this.btnSaldosUp_Click);
            // 
            // txtNickUp
            // 
            this.txtNickUp.Location = new System.Drawing.Point(337, 337);
            this.txtNickUp.Name = "txtNickUp";
            this.txtNickUp.Size = new System.Drawing.Size(195, 20);
            this.txtNickUp.TabIndex = 7;
            // 
            // lblNickUp
            // 
            this.lblNickUp.AutoSize = true;
            this.lblNickUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickUp.Location = new System.Drawing.Point(412, 309);
            this.lblNickUp.Name = "lblNickUp";
            this.lblNickUp.Size = new System.Drawing.Size(54, 25);
            this.lblNickUp.TabIndex = 24;
            this.lblNickUp.Text = "Nick";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(348, 266);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(172, 25);
            this.lblUpdate.TabIndex = 23;
            this.lblUpdate.Text = "Actualiza Saldos";
            // 
            // lblSaldoUp
            // 
            this.lblSaldoUp.AutoSize = true;
            this.lblSaldoUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoUp.Location = new System.Drawing.Point(402, 373);
            this.lblSaldoUp.Name = "lblSaldoUp";
            this.lblSaldoUp.Size = new System.Drawing.Size(67, 25);
            this.lblSaldoUp.TabIndex = 25;
            this.lblSaldoUp.Text = "Saldo";
            // 
            // txtSaldoUp
            // 
            this.txtSaldoUp.Location = new System.Drawing.Point(337, 413);
            this.txtSaldoUp.Name = "txtSaldoUp";
            this.txtSaldoUp.Size = new System.Drawing.Size(195, 20);
            this.txtSaldoUp.TabIndex = 8;
            // 
            // btnUndo_Elim
            // 
            this.btnUndo_Elim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo_Elim.Location = new System.Drawing.Point(518, 192);
            this.btnUndo_Elim.Name = "btnUndo_Elim";
            this.btnUndo_Elim.Size = new System.Drawing.Size(72, 34);
            this.btnUndo_Elim.TabIndex = 27;
            this.btnUndo_Elim.Text = "Undo";
            this.btnUndo_Elim.UseVisualStyleBackColor = true;
            this.btnUndo_Elim.Visible = false;
            this.btnUndo_Elim.Click += new System.EventHandler(this.btnUndo_Elim_Click);
            // 
            // btnUndo_Up
            // 
            this.btnUndo_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo_Up.Location = new System.Drawing.Point(518, 478);
            this.btnUndo_Up.Name = "btnUndo_Up";
            this.btnUndo_Up.Size = new System.Drawing.Size(72, 34);
            this.btnUndo_Up.TabIndex = 28;
            this.btnUndo_Up.Text = "Undo";
            this.btnUndo_Up.UseVisualStyleBackColor = true;
            this.btnUndo_Up.Visible = false;
            this.btnUndo_Up.Click += new System.EventHandler(this.btnUndo_Up_Click);
            // 
            // btnUndo_Insert
            // 
            this.btnUndo_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo_Insert.Location = new System.Drawing.Point(108, 439);
            this.btnUndo_Insert.Name = "btnUndo_Insert";
            this.btnUndo_Insert.Size = new System.Drawing.Size(72, 34);
            this.btnUndo_Insert.TabIndex = 29;
            this.btnUndo_Insert.Text = "Undo";
            this.btnUndo_Insert.UseVisualStyleBackColor = true;
            this.btnUndo_Insert.Visible = false;
            this.btnUndo_Insert.Click += new System.EventHandler(this.btnUndo_Insert_Click);
            // 
            // Manejo_cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 597);
            this.Controls.Add(this.btnUndo_Insert);
            this.Controls.Add(this.btnUndo_Up);
            this.Controls.Add(this.btnUndo_Elim);
            this.Controls.Add(this.txtSaldoUp);
            this.Controls.Add(this.lblSaldoUp);
            this.Controls.Add(this.btnSaldosUp);
            this.Controls.Add(this.txtNickUp);
            this.Controls.Add(this.lblNickUp);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblExeption);
            this.Controls.Add(this.CBRegiones);
            this.Controls.Add(this.btnAceptar_Elim);
            this.Controls.Add(this.txtNick_elim);
            this.Controls.Add(this.lblNombre_elim);
            this.Controls.Add(this.lblVendedorelim);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblNick);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.dGVCuentas);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manejo_cuentas";
            this.Text = "Manejo de cuentas";
            this.Load += new System.EventHandler(this.Manejo_cuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dGVCuentas;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblVendedorelim;
        private System.Windows.Forms.Label lblNombre_elim;
        private System.Windows.Forms.TextBox txtNick_elim;
        private System.Windows.Forms.Button btnAceptar_Elim;
        private System.Windows.Forms.ComboBox CBRegiones;
        private System.Windows.Forms.Label lblExeption;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnSaldosUp;
        private System.Windows.Forms.TextBox txtNickUp;
        private System.Windows.Forms.Label lblNickUp;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblSaldoUp;
        private System.Windows.Forms.TextBox txtSaldoUp;
        private System.Windows.Forms.Button btnUndo_Elim;
        private System.Windows.Forms.Button btnUndo_Up;
        private System.Windows.Forms.Button btnUndo_Insert;
    }
}