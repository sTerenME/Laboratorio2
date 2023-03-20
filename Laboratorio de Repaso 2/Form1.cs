using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_de_Repaso_2
{
    public partial class Form1 : Form
    {
        List<Alquileres> Alquileres = new List<Alquileres>();
        List<Vehiculos> Vehiculos = new List<Vehiculos>();
        List<Clientes> Clientes = new List<Clientes>();
        List<Resumen> Resumen = new List<Resumen>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leer();leer2();leer3();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Clientes;
            dataGridView1.Refresh();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = Vehiculos;
            dataGridView2.Refresh();
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = Resumen;
            dataGridView3.Refresh();
        }

        void leer()
        {
            string fileName = "Clientes.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Clientes cliTemp = new Clientes();

                cliTemp.Nit = reader.ReadLine();
                cliTemp.Nombre = reader.ReadLine(); ;
                cliTemp.Direccion = reader.ReadLine();
                Clientes.Add(cliTemp);
            }

            reader.Close();
        }

        void leer2()
        {
            string fileName = "Vehiculos.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1&& reader.ReadLine()!=null)
            {
                Vehiculos vehTemp = new Vehiculos();

                vehTemp.Placa = reader.ReadLine();
                vehTemp.Marca = reader.ReadLine();
                vehTemp.Modelo = reader.ReadLine();
                vehTemp.Color = reader.ReadLine(); ;
                vehTemp.Prepork = Convert.ToDouble(reader.ReadLine());
                Vehiculos.Add(vehTemp);
            }

            reader.Close();
        }

        void leer3()
        {
            string fileName = "Alquileres.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Alquileres alqTemp = new Alquileres();

                alqTemp.Nit = reader.ReadLine();
                alqTemp.Placa = reader.ReadLine();
                alqTemp.Fechaalquiler = Convert.ToDateTime(reader.ReadLine());
                alqTemp.Fechadevolucion = Convert.ToDateTime(reader.ReadLine()); ;
                alqTemp.Krecorridos = Convert.ToInt32(reader.ReadLine());
                Alquileres.Add(alqTemp);
            }

            reader.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarV_Click(object sender, EventArgs e)
        {
           /* Vehiculos vehTemp = new Vehiculos();
            vehTemp.Direccion = texto;
            vehTemp.Veces = 1;
            vehTemp.Fecha = DateTime.Now;
            vehTemp.Add(urlTemp);

            File.Delete(fileName);
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            int i = 0;
            foreach (var url in urls)
            {
                writer.WriteLine(urls[i].Direccion);
                i++;
            }
            writer.Close();*/
        }
    }
}
