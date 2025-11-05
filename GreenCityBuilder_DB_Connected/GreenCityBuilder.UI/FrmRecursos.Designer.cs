namespace GreenCityBuilder.UI
    {
        partial class FrmRecursos
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
            this.lblCiudadR = new System.Windows.Forms.Label();
            this.cboCiudadR = new System.Windows.Forms.ComboBox();
            this.dgvRecursos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCiudadR
            // 
            this.lblCiudadR.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudadR.Location = new System.Drawing.Point(20, 20);
            this.lblCiudadR.Name = "lblCiudadR";
            this.lblCiudadR.Size = new System.Drawing.Size(80, 25);
            this.lblCiudadR.TabIndex = 0;
            this.lblCiudadR.Text = "Ciudad:";
            // 
            // cboCiudadR
            // 
            this.cboCiudadR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiudadR.Location = new System.Drawing.Point(106, 21);
            this.cboCiudadR.Name = "cboCiudadR";
            this.cboCiudadR.Size = new System.Drawing.Size(220, 24);
            this.cboCiudadR.TabIndex = 1;
            // 
            // dgvRecursos
            // 
            this.dgvRecursos.AllowUserToAddRows = false;
            this.dgvRecursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecursos.ColumnHeadersHeight = 29;
            this.dgvRecursos.Location = new System.Drawing.Point(20, 60);
            this.dgvRecursos.Name = "dgvRecursos";
            this.dgvRecursos.ReadOnly = true;
            this.dgvRecursos.RowHeadersWidth = 51;
            this.dgvRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecursos.Size = new System.Drawing.Size(840, 440);
            this.dgvRecursos.TabIndex = 2;
            // 
            // FrmRecursos
            // 
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lblCiudadR);
            this.Controls.Add(this.cboCiudadR);
            this.Controls.Add(this.dgvRecursos);
            this.Name = "FrmRecursos";
            this.Text = "FrmRecursos";
            this.Load += new System.EventHandler(this.FrmRecursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Label lblCiudadR;
private System.Windows.Forms.ComboBox cboCiudadR;
private System.Windows.Forms.DataGridView dgvRecursos;
        }
    }
