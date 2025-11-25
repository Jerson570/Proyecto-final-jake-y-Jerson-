using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenCityBuilder.UI
{
    public partial class FrmPuzzleRecursos : Form
    {
        private Button[] botones;
        private HashSet<int> indicesCorrectos;
        private Timer timer;
        private int tiempoRestante = 7;

        public int RecursosGanados { get; private set; } = 0;
        public int IdRecursoGanado { get; private set; }


        public FrmPuzzleRecursos()
        {
            InitializeComponent();
            CrearPuzzle();
            IniciarTimer();
        }
        private void CrearPuzzle()
        {
        
            botones = new Button[9];
            int x = 20, y = 20;
            int index = 0;

            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Button btn = new Button();
                    btn.Width = 80;
                    btn.Height = 80;
                    btn.Left = x;
                    btn.Top = y;
                    btn.BackColor = Color.LightGray; 
                    btn.Tag = index;
                    btn.Click += Boton_Click;

                    botones[index] = btn;
                    Controls.Add(btn);

                    x += 90;
                    index++;
                }

                x = 20;
                y += 90;
            }

            
            Random rnd = new Random();
            indicesCorrectos = new HashSet<int>();

            while (indicesCorrectos.Count < 3)
            {
                indicesCorrectos.Add(rnd.Next(0, 9));
            }
        }

          

        private void FrmPuzzleRecursos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void Boton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int index = (int)btn.Tag;

            if (indicesCorrectos.Contains(index))
            {
                btn.BackColor = Color.Green;
                timer.Stop();
                RecursosGanados = 50;

                Random rnd = new Random();
                IdRecursoGanado = rnd.Next(1, 5);

                string nombreRecurso;

                switch (IdRecursoGanado)
                {
                    case 1:
                        nombreRecurso = "Agua";
                        break;
                    case 2:
                        nombreRecurso = "Energía";
                        break;
                    case 3:
                        nombreRecurso = "Alimentos";
                        break;
                    case 4:
                        nombreRecurso = "Áreas Verdes";
                        break;
                    default:
                        nombreRecurso = "Recurso";
                        break;
                }

                MessageBox.Show($"¡Correcto! Ganaste 50 de {nombreRecurso}.");

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                btn.BackColor = Color.Red;
            }
        }

        private void IniciarTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;

            this.Text = $"Puzzle - Tiempo restante: {tiempoRestante}s";

            if (tiempoRestante <= 0)
            {
                timer.Stop();
                MessageBox.Show("¡Tiempo agotado! No ganaste recursos.");
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
