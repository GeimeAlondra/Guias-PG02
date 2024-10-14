namespace CapaDesconectada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizarNT = new System.Windows.Forms.Button();
            this.btnBuscarNoTipado = new System.Windows.Forms.Button();
            this.tboxBuscarNoTipado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObtenerNoTipado = new System.Windows.Forms.Button();
            this.gridNoTipado = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnActualizarT = new System.Windows.Forms.Button();
            this.btnInsertarT = new System.Windows.Forms.Button();
            this.btnBuscarTipado = new System.Windows.Forms.Button();
            this.tboxBuscarTipado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObtenerTipado = new System.Windows.Forms.Button();
            this.gridTipado = new System.Windows.Forms.DataGridView();
            this.tboxCustomerID = new System.Windows.Forms.TextBox();
            this.tboxCompanyName = new System.Windows.Forms.TextBox();
            this.tboxContactName = new System.Windows.Forms.TextBox();
            this.tboxContactTitle = new System.Windows.Forms.TextBox();
            this.tboxAddress = new System.Windows.Forms.TextBox();
            this.btnInsertarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminarClienteNt = new System.Windows.Forms.Button();
            this.btnEliminarT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoTipado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarClienteNt);
            this.groupBox1.Controls.Add(this.btnActualizarNT);
            this.groupBox1.Controls.Add(this.btnBuscarNoTipado);
            this.groupBox1.Controls.Add(this.tboxBuscarNoTipado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnObtenerNoTipado);
            this.groupBox1.Controls.Add(this.gridNoTipado);
            this.groupBox1.Location = new System.Drawing.Point(29, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DataSet no Tipado";
            // 
            // btnActualizarNT
            // 
            this.btnActualizarNT.Location = new System.Drawing.Point(204, 343);
            this.btnActualizarNT.Name = "btnActualizarNT";
            this.btnActualizarNT.Size = new System.Drawing.Size(108, 23);
            this.btnActualizarNT.TabIndex = 5;
            this.btnActualizarNT.Text = "Actualizar";
            this.btnActualizarNT.UseVisualStyleBackColor = true;
            this.btnActualizarNT.Click += new System.EventHandler(this.btnActualizarNT_Click);
            // 
            // btnBuscarNoTipado
            // 
            this.btnBuscarNoTipado.Location = new System.Drawing.Point(46, 343);
            this.btnBuscarNoTipado.Name = "btnBuscarNoTipado";
            this.btnBuscarNoTipado.Size = new System.Drawing.Size(114, 23);
            this.btnBuscarNoTipado.TabIndex = 4;
            this.btnBuscarNoTipado.Text = "Buscar Cliente";
            this.btnBuscarNoTipado.UseVisualStyleBackColor = true;
            this.btnBuscarNoTipado.Click += new System.EventHandler(this.btnBuscarNoTipado_Click);
            // 
            // tboxBuscarNoTipado
            // 
            this.tboxBuscarNoTipado.Location = new System.Drawing.Point(92, 302);
            this.tboxBuscarNoTipado.Name = "tboxBuscarNoTipado";
            this.tboxBuscarNoTipado.Size = new System.Drawing.Size(220, 20);
            this.tboxBuscarNoTipado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // btnObtenerNoTipado
            // 
            this.btnObtenerNoTipado.Location = new System.Drawing.Point(92, 260);
            this.btnObtenerNoTipado.Name = "btnObtenerNoTipado";
            this.btnObtenerNoTipado.Size = new System.Drawing.Size(150, 23);
            this.btnObtenerNoTipado.TabIndex = 1;
            this.btnObtenerNoTipado.Text = "Obtener Datos No Tipados";
            this.btnObtenerNoTipado.UseVisualStyleBackColor = true;
            this.btnObtenerNoTipado.Click += new System.EventHandler(this.btnObtenerNoTipado_Click);
            // 
            // gridNoTipado
            // 
            this.gridNoTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNoTipado.Location = new System.Drawing.Point(6, 29);
            this.gridNoTipado.Name = "gridNoTipado";
            this.gridNoTipado.Size = new System.Drawing.Size(339, 211);
            this.gridNoTipado.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarT);
            this.groupBox2.Controls.Add(this.btnActualizarT);
            this.groupBox2.Controls.Add(this.btnInsertarT);
            this.groupBox2.Controls.Add(this.btnBuscarTipado);
            this.groupBox2.Controls.Add(this.tboxBuscarTipado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnObtenerTipado);
            this.groupBox2.Controls.Add(this.gridTipado);
            this.groupBox2.Location = new System.Drawing.Point(408, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 417);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DataSet Tipado";
            // 
            // btnActualizarT
            // 
            this.btnActualizarT.Location = new System.Drawing.Point(210, 343);
            this.btnActualizarT.Name = "btnActualizarT";
            this.btnActualizarT.Size = new System.Drawing.Size(106, 23);
            this.btnActualizarT.TabIndex = 9;
            this.btnActualizarT.Text = "Actualizar";
            this.btnActualizarT.UseVisualStyleBackColor = true;
            this.btnActualizarT.Click += new System.EventHandler(this.btnActualizarT_Click);
            // 
            // btnInsertarT
            // 
            this.btnInsertarT.Location = new System.Drawing.Point(50, 372);
            this.btnInsertarT.Name = "btnInsertarT";
            this.btnInsertarT.Size = new System.Drawing.Size(106, 23);
            this.btnInsertarT.TabIndex = 8;
            this.btnInsertarT.Text = "Enviar";
            this.btnInsertarT.UseVisualStyleBackColor = true;
            this.btnInsertarT.Click += new System.EventHandler(this.btnInsertarT_Click);
            // 
            // btnBuscarTipado
            // 
            this.btnBuscarTipado.Location = new System.Drawing.Point(50, 343);
            this.btnBuscarTipado.Name = "btnBuscarTipado";
            this.btnBuscarTipado.Size = new System.Drawing.Size(106, 23);
            this.btnBuscarTipado.TabIndex = 7;
            this.btnBuscarTipado.Text = "Buscar Cliente";
            this.btnBuscarTipado.UseVisualStyleBackColor = true;
            this.btnBuscarTipado.Click += new System.EventHandler(this.btnBuscarTipado_Click);
            // 
            // tboxBuscarTipado
            // 
            this.tboxBuscarTipado.Location = new System.Drawing.Point(96, 302);
            this.tboxBuscarTipado.Name = "tboxBuscarTipado";
            this.tboxBuscarTipado.Size = new System.Drawing.Size(220, 20);
            this.tboxBuscarTipado.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar:";
            // 
            // btnObtenerTipado
            // 
            this.btnObtenerTipado.Location = new System.Drawing.Point(96, 260);
            this.btnObtenerTipado.Name = "btnObtenerTipado";
            this.btnObtenerTipado.Size = new System.Drawing.Size(142, 23);
            this.btnObtenerTipado.TabIndex = 1;
            this.btnObtenerTipado.Text = "Obtener Datos Tipados";
            this.btnObtenerTipado.UseVisualStyleBackColor = true;
            this.btnObtenerTipado.Click += new System.EventHandler(this.btnObtenerTipado_Click);
            // 
            // gridTipado
            // 
            this.gridTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipado.Location = new System.Drawing.Point(6, 29);
            this.gridTipado.Name = "gridTipado";
            this.gridTipado.Size = new System.Drawing.Size(350, 211);
            this.gridTipado.TabIndex = 0;
            // 
            // tboxCustomerID
            // 
            this.tboxCustomerID.Location = new System.Drawing.Point(878, 54);
            this.tboxCustomerID.Name = "tboxCustomerID";
            this.tboxCustomerID.Size = new System.Drawing.Size(154, 20);
            this.tboxCustomerID.TabIndex = 7;
            // 
            // tboxCompanyName
            // 
            this.tboxCompanyName.Location = new System.Drawing.Point(878, 94);
            this.tboxCompanyName.Name = "tboxCompanyName";
            this.tboxCompanyName.Size = new System.Drawing.Size(154, 20);
            this.tboxCompanyName.TabIndex = 8;
            // 
            // tboxContactName
            // 
            this.tboxContactName.Location = new System.Drawing.Point(878, 133);
            this.tboxContactName.Name = "tboxContactName";
            this.tboxContactName.Size = new System.Drawing.Size(154, 20);
            this.tboxContactName.TabIndex = 9;
            // 
            // tboxContactTitle
            // 
            this.tboxContactTitle.Location = new System.Drawing.Point(878, 172);
            this.tboxContactTitle.Name = "tboxContactTitle";
            this.tboxContactTitle.Size = new System.Drawing.Size(154, 20);
            this.tboxContactTitle.TabIndex = 10;
            // 
            // tboxAddress
            // 
            this.tboxAddress.Location = new System.Drawing.Point(878, 212);
            this.tboxAddress.Name = "tboxAddress";
            this.tboxAddress.Size = new System.Drawing.Size(154, 20);
            this.tboxAddress.TabIndex = 11;
            // 
            // btnInsertarCliente
            // 
            this.btnInsertarCliente.Location = new System.Drawing.Point(823, 265);
            this.btnInsertarCliente.Name = "btnInsertarCliente";
            this.btnInsertarCliente.Size = new System.Drawing.Size(163, 23);
            this.btnInsertarCliente.TabIndex = 8;
            this.btnInsertarCliente.Text = "Insertar Cliente";
            this.btnInsertarCliente.UseVisualStyleBackColor = true;
            this.btnInsertarCliente.Click += new System.EventHandler(this.btnInsertarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(804, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Customer ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(787, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Company Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(794, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contact Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(802, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Contact Title:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(820, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Address:";
            // 
            // btnEliminarClienteNt
            // 
            this.btnEliminarClienteNt.Location = new System.Drawing.Point(118, 388);
            this.btnEliminarClienteNt.Name = "btnEliminarClienteNt";
            this.btnEliminarClienteNt.Size = new System.Drawing.Size(114, 23);
            this.btnEliminarClienteNt.TabIndex = 6;
            this.btnEliminarClienteNt.Text = "Eliminar";
            this.btnEliminarClienteNt.UseVisualStyleBackColor = true;
            this.btnEliminarClienteNt.Click += new System.EventHandler(this.btnEliminarClienteNt_Click);
            // 
            // btnEliminarT
            // 
            this.btnEliminarT.Location = new System.Drawing.Point(210, 372);
            this.btnEliminarT.Name = "btnEliminarT";
            this.btnEliminarT.Size = new System.Drawing.Size(106, 23);
            this.btnEliminarT.TabIndex = 10;
            this.btnEliminarT.Text = "Eliminar";
            this.btnEliminarT.UseVisualStyleBackColor = true;
            this.btnEliminarT.Click += new System.EventHandler(this.btnEliminarT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 470);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInsertarCliente);
            this.Controls.Add(this.tboxAddress);
            this.Controls.Add(this.tboxContactTitle);
            this.Controls.Add(this.tboxContactName);
            this.Controls.Add(this.tboxCompanyName);
            this.Controls.Add(this.tboxCustomerID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoTipado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObtenerNoTipado;
        private System.Windows.Forms.DataGridView gridNoTipado;
        private System.Windows.Forms.Button btnObtenerTipado;
        private System.Windows.Forms.DataGridView gridTipado;
        private System.Windows.Forms.Button btnBuscarNoTipado;
        private System.Windows.Forms.TextBox tboxBuscarNoTipado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarTipado;
        private System.Windows.Forms.TextBox tboxBuscarTipado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxCustomerID;
        private System.Windows.Forms.TextBox tboxCompanyName;
        private System.Windows.Forms.TextBox tboxContactName;
        private System.Windows.Forms.TextBox tboxContactTitle;
        private System.Windows.Forms.TextBox tboxAddress;
        private System.Windows.Forms.Button btnInsertarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInsertarT;
        private System.Windows.Forms.Button btnActualizarNT;
        private System.Windows.Forms.Button btnActualizarT;
        private System.Windows.Forms.Button btnEliminarClienteNt;
        private System.Windows.Forms.Button btnEliminarT;
    }
}

