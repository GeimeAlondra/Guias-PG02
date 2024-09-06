using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDesconectada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObtenerNoTipado_Click(object sender, EventArgs e)
        {
            // Asignar un elemento iterable
            DataTable dataTable = new DataTable();

            String selectAll = "";
            selectAll = selectAll + "SELECT [CustomerID] " + "\n";
            selectAll = selectAll + "      ,[CompanyName] " + "\n";
            selectAll = selectAll + "      ,[ContactName] " + "\n";
            selectAll = selectAll + "      ,[ContactTitle] " + "\n";
            selectAll = selectAll + "      ,[Address] " + "\n";
            selectAll = selectAll + "      ,[City] " + "\n";
            selectAll = selectAll + "      ,[Region] " + "\n";
            selectAll = selectAll + "      ,[PostalCode] " + "\n";
            selectAll = selectAll + "      ,[Country] " + "\n";
            selectAll = selectAll + "      ,[Phone] " + "\n";
            selectAll = selectAll + "      ,[Fax] " + "\n";
            selectAll = selectAll + "  FROM [dbo].[Customers]";

            var conexion = @"Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;";
            
            // Controla DataSet
            SqlDataAdapter adapter = new SqlDataAdapter(selectAll, conexion);

            // Los resultados de DataAdapet se almacenan en dataTable
            adapter.Fill(dataTable);

            // Muestra los datos en el form
            gridNoTipado.DataSource = dataTable;
        
        }

        private void btnObtenerTipado_Click(object sender, EventArgs e)
        {

        }
    }
}
