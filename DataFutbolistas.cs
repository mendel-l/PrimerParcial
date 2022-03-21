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
        public DataFutbolistas()
        {
            InitializeComponent();
        }

        void ReadDepartamento()
        {
            FileStream stream = new FileStream(@"Departamentos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Departamentos();
                dato.NoIdentificacion = partes[0];
                dato.Departamento = partes[1];

                departamento.Add(dato);
            }
            reader.Close();

            comboBoxDepartamentos.DataSource = departamento;
            comboBoxDepartamentos.DisplayMember = "Departamento";
            comboBoxDepartamentos.Refresh();
        }

        void ReadTemperatura()
        {
            FileStream stream = new FileStream(@"Temperatura.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new ClimaDepartamento();

                dato.NoIdentificacion = partes[0];
                dato.Departamento = departamento.First(x => x.NoIdentificacion == partes[0]).Departamento;
                dato.Clima = partes[1];
                dato.FechaClima = DateTime.Parse(partes[2]);

                climaDep.Add(dato);
            }
            reader.Close();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {

        }
    }
}
