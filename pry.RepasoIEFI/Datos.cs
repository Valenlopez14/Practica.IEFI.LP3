using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;


namespace pry.RepasoIEFI
{
    class Datos
    {
        public DataTable getData(string SQL)
        {
            
            OleDbDataAdapter adaptador = new OleDbDataAdapter(SQL,Properties.Settings.Default.CADENA);

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
            
        }
    }
}
