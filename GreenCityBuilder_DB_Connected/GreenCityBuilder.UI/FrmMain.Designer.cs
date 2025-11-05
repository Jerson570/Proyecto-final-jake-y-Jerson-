namespace GreenCityBuilder.UI
    {
        partial class FrmMain
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnCiudades = new System.Windows.Forms.Button();
            this.btnEdificios = new System.Windows.Forms.Button();
            this.btnRecursos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(99, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(312, 50);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GreenCity Builder";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(20, 70);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(350, 25);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Seleccione un módulo para comenzar";
            // 
            // btnCiudades
            // 
            this.btnCiudades.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCiudades.Location = new System.Drawing.Point(72, 105);
            this.btnCiudades.Name = "btnCiudades";
            this.btnCiudades.Size = new System.Drawing.Size(214, 56);
            this.btnCiudades.TabIndex = 2;
            this.btnCiudades.Text = "Gestionar Ciudades";
            this.btnCiudades.Click += new System.EventHandler(this.btnCiudades_Click);
            // 
            // btnEdificios
            // 
            this.btnEdificios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdificios.Location = new System.Drawing.Point(72, 167);
            this.btnEdificios.Name = "btnEdificios";
            this.btnEdificios.Size = new System.Drawing.Size(214, 56);
            this.btnEdificios.TabIndex = 3;
            this.btnEdificios.Text = "Gestionar Edificios";
            this.btnEdificios.Click += new System.EventHandler(this.btnEdificios_Click);
            // 
            // btnRecursos
            // 
            this.btnRecursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecursos.Location = new System.Drawing.Point(72, 229);
            this.btnRecursos.Name = "btnRecursos";
            this.btnRecursos.Size = new System.Drawing.Size(214, 56);
            this.btnRecursos.TabIndex = 4;
            this.btnRecursos.Text = "Ver Recursos";
            this.btnRecursos.Click += new System.EventHandler(this.btnRecursos_Click);
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.btnCiudades);
            this.Controls.Add(this.btnEdificios);
            this.Controls.Add(this.btnRecursos);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Label lblTitulo;
private System.Windows.Forms.Label lblSubtitulo;
private System.Windows.Forms.Button btnCiudades;
private System.Windows.Forms.Button btnEdificios;
private System.Windows.Forms.Button btnRecursos;
        }
    }
