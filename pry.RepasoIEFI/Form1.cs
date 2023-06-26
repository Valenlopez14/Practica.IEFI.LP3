using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.RepasoIEFI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Secuencia SQL Para mostrar los datos de 3 
            //tablas distintas (Gobernador, Votos y Departamentos)
            
            string SQL = @"SELECT L.gobernador, SUM(V.votos)
            AS votos FROM Listas L
            INNER JOIN Votos V ON L.lista=V.lista
            GROUP BY L.gobernador
            ORDER BY SUM(V.votos) DESC";
            Datos d = new Datos();
            dataGridView1.DataSource = d.getData(SQL);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmChart frm = new frmChart();
            frm.ShowDialog();
        }
    }
}
