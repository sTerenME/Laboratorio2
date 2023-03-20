using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Clientes;
            dataGridView1.Refresh();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = Vehiculos;
            dataGridView2.Refresh();
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = ;
            dataGridView3.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
