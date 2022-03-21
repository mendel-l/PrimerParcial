using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class DataFutbolistas : Form
    {
        List<Jugador> jugadores = new List<Jugador>();
        List<Resultado> resultadoPartido = new List<Resultado>();

        List<ResultadoJugador> resdeljugador = new List<ResultadoJugador>();
        public DataFutbolistas()
        {
            InitializeComponent();

            ReadJugador();
            ReadGol();
            ActualizarGred();

        }
        void ReadJugador()
        {
            FileStream stream = new FileStream(@"Jugador.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Jugador();
                dato.IDjugador = partes[0];
                dato.Name = partes[1];
                dato.Equipo = partes[2];

                jugadores.Add(dato);
            }
            reader.Close();

            comboBoxName.DataSource = jugadores;
            comboBoxName.DisplayMember = "Name";
            comboBoxName.Refresh();
        }

        void ReadGol()
        {
            FileStream stream = new FileStream(@"GolesAnotados.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Resultado();
                dato.IDjugador = partes[0];
                dato.FechaJuego = DateTime.Parse(partes[1]);
                dato.NameEquipoRival = partes[2];
                dato.NoGolesAnotados = Convert.ToInt32(partes[3]);

                resultadoPartido.Add(dato);
            }
            reader.Close();
        }

        void ActualizarGred()
        {
            dataGridViewResultado.DataSource = null;
            dataGridViewResultado.Refresh();
            var SerchNamePlayer = ((Jugador)comboBoxName.SelectedValue).Name;
            dataGridViewResultado.DataSource = jugadores.Where(x => x.Name == SerchNamePlayer).ToList();
            dataGridViewResultado.Refresh();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            ReadJugador();
            ReadGol();

            for (int i = 0; i < jugadores.Count; i++)
            {
                for (int j = 0; j < resultadoPartido.Count; j++)
                {
                    if (jugadores[i].IDjugador == resultadoPartido[j].IDjugador)
                    {
                        ResultadoJugador Resumenjugador = new ResultadoJugador();
                        Resumenjugador.NombreJugador = jugadores[j].Name;
                        Resumenjugador.NumeroDeGoles = resultadoPartido[j].NoGolesAnotados;

                        resdeljugador.Add(Resumenjugador);
                    }
                }
            }
            ActualizarGred();
        }

        private void CargarGrid(List<ResultadoJugador> auxData)
        {
            dataGridViewResultado.DataSource = null;
            dataGridViewResultado.Refresh();
            dataGridViewResultado.DataSource = auxData;
            dataGridViewResultado.Refresh();
        }

        private void buttonOrdanarGoles_Click(object sender, EventArgs e)
        {
            resdeljugador = resdeljugador.OrderByDescending(c => c.NumeroDeGoles).ToList();
            CargarGrid(resdeljugador);
        }
    }
}
