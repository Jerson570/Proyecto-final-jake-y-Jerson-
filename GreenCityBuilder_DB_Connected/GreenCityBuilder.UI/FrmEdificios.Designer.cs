namespace GreenCityBuilder.UI
    {
        partial class FrmEdificios
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
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipoEdificio = new System.Windows.Forms.ComboBox();
            this.lblNombreEdificio = new System.Windows.Forms.Label();
            this.txtNombreEdificio = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.nudCosto = new System.Windows.Forms.NumericUpDown();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dgvEdificios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdificios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCiudad
            // 
            this.lblCiudad.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(20, 20);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(80, 25);
            this.lblCiudad.TabIndex = 0;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // cboCiudad
            // 
            this.cboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiudad.Location = new System.Drawing.Point(110, 20);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(220, 24);
            this.cboCiudad.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(20, 55);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(80, 25);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo:";
            // 
            // cboTipoEdificio
            // 
            this.cboTipoEdificio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEdificio.Items.AddRange(new object[] {
            "Residencial",
            "Industrial",
            "Verde"});
            this.cboTipoEdificio.Location = new System.Drawing.Point(110, 55);
            this.cboTipoEdificio.Name = "cboTipoEdificio";
            this.cboTipoEdificio.Size = new System.Drawing.Size(220, 24);
            this.cboTipoEdificio.TabIndex = 3;
            // 
            // lblNombreEdificio
            // 
            this.lblNombreEdificio.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEdificio.Location = new System.Drawing.Point(20, 90);
            this.lblNombreEdificio.Name = "lblNombreEdificio";
            this.lblNombreEdificio.Size = new System.Drawing.Size(80, 25);
            this.lblNombreEdificio.TabIndex = 4;
            this.lblNombreEdificio.Text = "Nombre:";
            // 
            // txtNombreEdificio
            // 
            this.txtNombreEdificio.Location = new System.Drawing.Point(110, 90);
            this.txtNombreEdificio.Name = "txtNombreEdificio";
            this.txtNombreEdificio.Size = new System.Drawing.Size(220, 22);
            this.txtNombreEdificio.TabIndex = 5;
            // 
            // lblCosto
            // 
            this.lblCosto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(20, 125);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(80, 25);
            this.lblCosto.TabIndex = 6;
            this.lblCosto.Text = "Costo:";
            // 
            // nudCosto
            // 
            this.nudCosto.Location = new System.Drawing.Point(110, 125);
            this.nudCosto.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudCosto.Name = "nudCosto";
            this.nudCosto.Size = new System.Drawing.Size(220, 22);
            this.nudCosto.TabIndex = 7;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(159, 167);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(120, 35);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dgvEdificios
            // 
            this.dgvEdificios.AllowUserToAddRows = false;
            this.dgvEdificios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEdificios.ColumnHeadersHeight = 29;
            this.dgvEdificios.Location = new System.Drawing.Point(20, 220);
            this.dgvEdificios.Name = "dgvEdificios";
            this.dgvEdificios.ReadOnly = true;
            this.dgvEdificios.RowHeadersWidth = 51;
            this.dgvEdificios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEdificios.Size = new System.Drawing.Size(840, 320);
            this.dgvEdificios.TabIndex = 9;
            // 
            // FrmEdificios
            // 
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.cboCiudad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cboTipoEdificio);
            this.Controls.Add(this.lblNombreEdificio);
            this.Controls.Add(this.txtNombreEdificio);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.nudCosto);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvEdificios);
            this.Name = "FrmEdificios";
            this.Text = "FrmEdificios";
            this.Load += new System.EventHandler(this.FrmEdificios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdificios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label lblCiudad;
private System.Windows.Forms.ComboBox cboCiudad;
private System.Windows.Forms.Label lblTipo;
private System.Windows.Forms.ComboBox cboTipoEdificio;
private System.Windows.Forms.Label lblNombreEdificio;
private System.Windows.Forms.TextBox txtNombreEdificio;
private System.Windows.Forms.Label lblCosto;
private System.Windows.Forms.NumericUpDown nudCosto;
private System.Windows.Forms.Button btnCrear;
private System.Windows.Forms.DataGridView dgvEdificios;
        }
    }
