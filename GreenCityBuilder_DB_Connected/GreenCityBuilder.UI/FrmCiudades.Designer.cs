namespace GreenCityBuilder.UI
    {
        partial class FrmCiudades
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSostenibilidad = new System.Windows.Forms.Label();
            this.nudSostenibilidad = new System.Windows.Forms.NumericUpDown();
            this.lblPoblacion = new System.Windows.Forms.Label();
            this.nudPoblacion = new System.Windows.Forms.NumericUpDown();
            this.lblContaminacion = new System.Windows.Forms.Label();
            this.nudContaminacion = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvCiudades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudSostenibilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoblacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContaminacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(20, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblSostenibilidad
            // 
            this.lblSostenibilidad.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSostenibilidad.Location = new System.Drawing.Point(20, 55);
            this.lblSostenibilidad.Name = "lblSostenibilidad";
            this.lblSostenibilidad.Size = new System.Drawing.Size(80, 25);
            this.lblSostenibilidad.TabIndex = 2;
            this.lblSostenibilidad.Text = "Nivel Sostenibilidad:";
            // 
            // nudSostenibilidad
            // 
            this.nudSostenibilidad.Location = new System.Drawing.Point(220, 58);
            this.nudSostenibilidad.Name = "nudSostenibilidad";
            this.nudSostenibilidad.Size = new System.Drawing.Size(140, 22);
            this.nudSostenibilidad.TabIndex = 3;
            this.nudSostenibilidad.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblPoblacion
            // 
            this.lblPoblacion.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoblacion.Location = new System.Drawing.Point(20, 90);
            this.lblPoblacion.Name = "lblPoblacion";
            this.lblPoblacion.Size = new System.Drawing.Size(100, 25);
            this.lblPoblacion.TabIndex = 4;
            this.lblPoblacion.Text = "Población:";
            // 
            // nudPoblacion
            // 
            this.nudPoblacion.Location = new System.Drawing.Point(239, 93);
            this.nudPoblacion.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudPoblacion.Name = "nudPoblacion";
            this.nudPoblacion.Size = new System.Drawing.Size(120, 22);
            this.nudPoblacion.TabIndex = 5;
            // 
            // lblContaminacion
            // 
            this.lblContaminacion.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaminacion.Location = new System.Drawing.Point(20, 125);
            this.lblContaminacion.Name = "lblContaminacion";
            this.lblContaminacion.Size = new System.Drawing.Size(144, 25);
            this.lblContaminacion.TabIndex = 6;
            this.lblContaminacion.Text = "Contaminación:";
            // 
            // nudContaminacion
            // 
            this.nudContaminacion.Location = new System.Drawing.Point(239, 125);
            this.nudContaminacion.Name = "nudContaminacion";
            this.nudContaminacion.Size = new System.Drawing.Size(121, 22);
            this.nudContaminacion.TabIndex = 7;
            this.nudContaminacion.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(20, 165);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 35);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(240, 165);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 35);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvCiudades
            // 
            this.dgvCiudades.AllowUserToAddRows = false;
            this.dgvCiudades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCiudades.ColumnHeadersHeight = 29;
            this.dgvCiudades.Location = new System.Drawing.Point(20, 220);
            this.dgvCiudades.Name = "dgvCiudades";
            this.dgvCiudades.ReadOnly = true;
            this.dgvCiudades.RowHeadersWidth = 51;
            this.dgvCiudades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCiudades.Size = new System.Drawing.Size(840, 320);
            this.dgvCiudades.TabIndex = 10;
            // 
            // FrmCiudades
            // 
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSostenibilidad);
            this.Controls.Add(this.nudSostenibilidad);
            this.Controls.Add(this.lblPoblacion);
            this.Controls.Add(this.nudPoblacion);
            this.Controls.Add(this.lblContaminacion);
            this.Controls.Add(this.nudContaminacion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvCiudades);
            this.Name = "FrmCiudades";
            this.Text = "FrmCiudades";
            this.Load += new System.EventHandler(this.FrmCiudades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSostenibilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoblacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContaminacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label lblNombre;
private System.Windows.Forms.TextBox txtNombre;
private System.Windows.Forms.Label lblSostenibilidad;
private System.Windows.Forms.NumericUpDown nudSostenibilidad;
private System.Windows.Forms.Label lblPoblacion;
private System.Windows.Forms.NumericUpDown nudPoblacion;
private System.Windows.Forms.Label lblContaminacion;
private System.Windows.Forms.NumericUpDown nudContaminacion;
private System.Windows.Forms.Button btnGuardar;
private System.Windows.Forms.Button btnLimpiar;
private System.Windows.Forms.DataGridView dgvCiudades;
        }
    }
