using AccesoDatos;
using CapaDesconectada.NorthwindTableAdapters;
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
        private void RellenarForm(Customers cliente)
        {
            if (cliente != null)
            {
                tboxCustomerID.Text = cliente.CustomerID;
                tboxCompanyName.Text = cliente.CompanyName;
                tboxContactName.Text = cliente.ContactName;
                tboxContactTitle.Text = cliente.ContactTitle;
                tboxAddress.Text = cliente.Address;
            }
            if (cliente == null)
            {
                MessageBox.Show("Objeto vacío");
            }
        }

        #region No Tipado 

        private CustomerRepository customerRepository = new CustomerRepository();

        private void btnObtenerNoTipado_Click(object sender, EventArgs e)
        {
            gridNoTipado.DataSource = customerRepository.ObtenerTodos();
        }

        private void btnBuscarNoTipado_Click(object sender, EventArgs e)
        {
            var cliente = customerRepository.ObtenerPorID(tboxBuscarNoTipado.Text);

            RellenarForm(cliente);

            if (cliente == null)
            {
                MessageBox.Show("El objeto esta vacío");
            }
            if (cliente != null)
            {
                var listaClientes = new List<Customers> { cliente };
                gridNoTipado.DataSource = listaClientes;
            }
        }

        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            int insertados = customerRepository.InsertarCliente(cliente);
            MessageBox.Show($"{insertados} registrados");
        }

        private Customers CrearCliente()
        {
            var cliente = new Customers
            {
                CustomerID = tboxCustomerID.Text,
                CompanyName = tboxCompanyName.Text,
                ContactName = tboxContactName.Text,
                ContactTitle = tboxContactTitle.Text,
                Address = tboxAddress.Text,
            };
            return cliente;
        }

        private void btnActualizarNT_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            var actulaizadas = customerRepository.ActualizarCliente(cliente);
            MessageBox.Show($"{actulaizadas} filas actulizadas");
        }

        #endregion

        #region Tipado

        CustomersTableAdapter adaptador = new CustomersTableAdapter();
        
        private void btnObtenerTipado_Click(object sender, EventArgs e)
        {
            var customers = adaptador.GetData();
            gridTipado.DataSource = customers;
        }

        private void btnBuscarTipado_Click(object sender, EventArgs e)
        {
            var customer = adaptador.GetDataByCustomerID(tboxBuscarTipado.Text);

            if (customer != null)
            {
                //var cliente = customerRepository.ExtraerInformacionCliente(customer);
                //Console.WriteLine(customer);
                gridTipado.DataSource = customer;
            }
        }

        private void btnInsertarT_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            int insertados = adaptador.Insert(cliente.CustomerID, cliente.CompanyName, 
                cliente.ContactName, cliente.ContactTitle, cliente.Address, cliente.City, 
                cliente.Region, cliente.PostalCode, cliente.Country, cliente.Phone, cliente.Fax
                );

            MessageBox.Show($"{insertados} registros insertados");
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }
    }
}
