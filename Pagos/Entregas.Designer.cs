namespace Skins4U
{
    partial class Entregas
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dGVEntregas = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnNOEntregado = new System.Windows.Forms.Button();
            this.btnEntregado = new System.Windows.Forms.Button();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.btnRegresa = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnBuscarEntregado = new System.Windows.Forms.Button();
            this.btnBuscarNoEntregado = new System.Windows.Forms.Button();
            this.dGVNoEntregados = new System.Windows.Forms.DataGridView();
            this.lblEntregados = new System.Windows.Forms.Label();
            this.lblNoEntregados = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEntregas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNoEntregados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(93, 276);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 53);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dGVEntregas
            // 
            this.dGVEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEntregas.Location = new System.Drawing.Point(398, 576);
            this.dGVEntregas.Name = "dGVEntregas";
            this.dGVEntregas.Size = new System.Drawing.Size(788, 147);
            this.dGVEntregas.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(42, 149);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(217, 31);
            this.txtBuscar.TabIndex = 5;
            // 
            // btnNOEntregado
            // 
            this.btnNOEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNOEntregado.Location = new System.Drawing.Point(152, 449);
            this.btnNOEntregado.Name = "btnNOEntregado";
            this.btnNOEntregado.Size = new System.Drawing.Size(107, 53);
            this.btnNOEntregado.TabIndex = 3;
            this.btnNOEntregado.Text = "No entregado";
            this.btnNOEntregado.UseVisualStyleBackColor = true;
            this.btnNOEntregado.Click += new System.EventHandler(this.btnNOEntregado_Click);
            // 
            // btnEntregado
            // 
            this.btnEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregado.Location = new System.Drawing.Point(39, 449);
            this.btnEntregado.Name = "btnEntregado";
            this.btnEntregado.Size = new System.Drawing.Size(107, 53);
            this.btnEntregado.TabIndex = 2;
            this.btnEntregado.Text = "Entregado";
            this.btnEntregado.UseVisualStyleBackColor = true;
            this.btnEntregado.Click += new System.EventHandler(this.btnEntgregado_Click);
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.Location = new System.Drawing.Point(110, 102);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(80, 29);
            this.lblFiltros.TabIndex = 9;
            this.lblFiltros.Text = "Filtros";
            // 
            // btnRegresa
            // 
            this.btnRegresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresa.Location = new System.Drawing.Point(83, 576);
            this.btnRegresa.Name = "btnRegresa";
            this.btnRegresa.Size = new System.Drawing.Size(127, 62);
            this.btnRegresa.TabIndex = 4;
            this.btnRegresa.Text = "Regresa al lobby";
            this.btnRegresa.UseVisualStyleBackColor = true;
            this.btnRegresa.Click += new System.EventHandler(this.btnRegresa_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(35, 536);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(163, 402);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(48, 31);
            this.txtID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(88, 404);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(42, 29);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "ID:";
            // 
            // btnBuscarEntregado
            // 
            this.btnBuscarEntregado.Enabled = false;
            this.btnBuscarEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEntregado.Location = new System.Drawing.Point(39, 195);
            this.btnBuscarEntregado.Name = "btnBuscarEntregado";
            this.btnBuscarEntregado.Size = new System.Drawing.Size(107, 53);
            this.btnBuscarEntregado.TabIndex = 16;
            this.btnBuscarEntregado.Text = "Entregado";
            this.btnBuscarEntregado.UseVisualStyleBackColor = true;
            // 
            // btnBuscarNoEntregado
            // 
            this.btnBuscarNoEntregado.Enabled = false;
            this.btnBuscarNoEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNoEntregado.Location = new System.Drawing.Point(152, 195);
            this.btnBuscarNoEntregado.Name = "btnBuscarNoEntregado";
            this.btnBuscarNoEntregado.Size = new System.Drawing.Size(107, 53);
            this.btnBuscarNoEntregado.TabIndex = 17;
            this.btnBuscarNoEntregado.Text = "No entregado";
            this.btnBuscarNoEntregado.UseVisualStyleBackColor = true;
            // 
            // dGVNoEntregados
            // 
            this.dGVNoEntregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNoEntregados.Location = new System.Drawing.Point(398, 69);
            this.dGVNoEntregados.Name = "dGVNoEntregados";
            this.dGVNoEntregados.Size = new System.Drawing.Size(788, 399);
            this.dGVNoEntregados.TabIndex = 18;
            // 
            // lblEntregados
            // 
            this.lblEntregados.AutoSize = true;
            this.lblEntregados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntregados.Location = new System.Drawing.Point(725, 498);
            this.lblEntregados.Name = "lblEntregados";
            this.lblEntregados.Size = new System.Drawing.Size(137, 29);
            this.lblEntregados.TabIndex = 19;
            this.lblEntregados.Text = "Entregados";
            // 
            // lblNoEntregados
            // 
            this.lblNoEntregados.AutoSize = true;
            this.lblNoEntregados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoEntregados.Location = new System.Drawing.Point(702, 17);
            this.lblNoEntregados.Name = "lblNoEntregados";
            this.lblNoEntregados.Size = new System.Drawing.Size(175, 29);
            this.lblNoEntregados.TabIndex = 20;
            this.lblNoEntregados.Text = "No Entregados";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(93, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 53);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Actualizar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Entregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 742);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblNoEntregados);
            this.Controls.Add(this.lblEntregados);
            this.Controls.Add(this.dGVNoEntregados);
            this.Controls.Add(this.btnBuscarNoEntregado);
            this.Controls.Add(this.btnBuscarEntregado);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRegresa);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.btnEntregado);
            this.Controls.Add(this.btnNOEntregado);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dGVEntregas);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Entregas";
            this.Text = "Entregas";
            this.Load += new System.EventHandler(this.Entregas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEntregas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNoEntregados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dGVEntregas;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnNOEntregado;
        private System.Windows.Forms.Button btnEntregado;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Button btnRegresa;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnBuscarEntregado;
        private System.Windows.Forms.Button btnBuscarNoEntregado;
        private System.Windows.Forms.DataGridView dGVNoEntregados;
        private System.Windows.Forms.Label lblEntregados;
        private System.Windows.Forms.Label lblNoEntregados;
        private System.Windows.Forms.Button btnRefresh;
    }
}