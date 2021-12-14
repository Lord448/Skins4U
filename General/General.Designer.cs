namespace Skins4U
{
    partial class General
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
            this.btnCuentas = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.DGvCuentas = new System.Windows.Forms.DataGridView();
            this.lblDataBase = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dGVPagos = new System.Windows.Forms.DataGridView();
            this.lblCuentas = new System.Windows.Forms.Label();
            this.lblExeption = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGvCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCuentas
            // 
            this.btnCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentas.Location = new System.Drawing.Point(125, 94);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(173, 73);
            this.btnCuentas.TabIndex = 0;
            this.btnCuentas.Text = "Manejo de Cuentas con RP";
            this.btnCuentas.UseVisualStyleBackColor = true;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.Location = new System.Drawing.Point(723, 94);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(149, 73);
            this.btnPagos.TabIndex = 3;
            this.btnPagos.Text = "Realiza transacciones";
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // DGvCuentas
            // 
            this.DGvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGvCuentas.Location = new System.Drawing.Point(29, 324);
            this.DGvCuentas.Name = "DGvCuentas";
            this.DGvCuentas.Size = new System.Drawing.Size(347, 214);
            this.DGvCuentas.TabIndex = 4;
            // 
            // lblDataBase
            // 
            this.lblDataBase.AutoSize = true;
            this.lblDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBase.Location = new System.Drawing.Point(703, 281);
            this.lblDataBase.Name = "lblDataBase";
            this.lblDataBase.Size = new System.Drawing.Size(180, 25);
            this.lblDataBase.TabIndex = 5;
            this.lblDataBase.Text = "Compras y pagos";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(407, 413);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(122, 38);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Actualizar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dGVPagos
            // 
            this.dGVPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPagos.Location = new System.Drawing.Point(554, 324);
            this.dGVPagos.Name = "dGVPagos";
            this.dGVPagos.Size = new System.Drawing.Size(469, 214);
            this.dGVPagos.TabIndex = 8;
            // 
            // lblCuentas
            // 
            this.lblCuentas.AutoSize = true;
            this.lblCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentas.Location = new System.Drawing.Point(130, 281);
            this.lblCuentas.Name = "lblCuentas";
            this.lblCuentas.Size = new System.Drawing.Size(168, 25);
            this.lblCuentas.TabIndex = 9;
            this.lblCuentas.Text = "Cuentas con RP";
            // 
            // lblExeption
            // 
            this.lblExeption.AutoSize = true;
            this.lblExeption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExeption.Location = new System.Drawing.Point(342, 202);
            this.lblExeption.Name = "lblExeption";
            this.lblExeption.Size = new System.Drawing.Size(0, 25);
            this.lblExeption.TabIndex = 10;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(424, 94);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(149, 73);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "Checar las entregas";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(12, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(146, 25);
            this.lblVersion.TabIndex = 12;
            this.lblVersion.Text = "Version - 0.1b";
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 597);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblExeption);
            this.Controls.Add(this.lblCuentas);
            this.Controls.Add(this.dGVPagos);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblDataBase);
            this.Controls.Add(this.DGvCuentas);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.btnCuentas);
            this.Name = "General";
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.General_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGvCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCuentas;
        private System.Windows.Forms.Button btnPagos;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DataGridView DGvCuentas;
        private System.Windows.Forms.Label lblDataBase;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dGVPagos;
        private System.Windows.Forms.Label lblCuentas;
        private System.Windows.Forms.Label lblExeption;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblVersion;
    }
}

