using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Espacio de nombre para incorporar el CHART
using System.Windows.Forms.DataVisualization.Charting;

namespace pry.RepasoIEFI
{
    public partial class frmChart : Form
    {
        public frmChart()
        {
            InitializeComponent();
        }

        private void frmChart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SQL = @"SELECT L.gobernador, SUM(V.votos)
            AS votos FROM Listas L
            INNER JOIN Votos V ON L.lista=V.lista
            GROUP BY L.gobernador
            ORDER BY SUM(V.votos) DESC";

            Datos d = new Datos();
            DataTable tabla = d.getData(SQL);

            Series serie = new Series();

            serie = chart1.Series.Add("Resultados");

            //Llenar el Chart con los datos de la tabla d ACCES 
            foreach (DataRow fila in tabla.Rows)
            {
                serie.Points.AddXY(fila["gobernador"], fila["votos"]);
            }
        }
    }
}
