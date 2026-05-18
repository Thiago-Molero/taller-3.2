using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //operaciones de Selección (σ)
        private void btnSeleccionComparacion_Click(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities1())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var resultado = context.Products
                                       .Where(p => p.UnitPrice > 50)
                                       .ToList();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = resultado;
            }
        }

        private void btnSeleccionRango_Click(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities1())
            {
                context.Configuration.LazyLoadingEnabled = false;
                DateTime fechaInicio = new DateTime(1997, 1, 1);
                DateTime fechaFin = new DateTime(1997, 12, 31);
                var resultado = context.Orders
                                       .Where(o => o.OrderDate >= fechaInicio && o.OrderDate <= fechaFin)
                                       .ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = resultado;
            }
        }

        private void btnSeleccionPertenencia_Click(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities1())
            {
                context.Configuration.LazyLoadingEnabled = false;
                string[] paisesPermitidos = { "Mexico", "Spain", "UK" };
                var resultado = context.Customers
                                       .Where(c => paisesPermitidos.Contains(c.Country))
                                       .ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = resultado;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Proyecciones
        private void btnProyeccionBasica_Click(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities1())
            {
                var resultado = context.Employees
                                       .Select(emp => new
                                       {
                                           emp.FirstName,
                                           emp.LastName,
                                           emp.Title
                                       })
                                       .ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = resultado;
            }
        }

        private void btnProyeccionSinDuplicados_Click(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities1())
            {
                var resultado = context.Customers
                                       .Select(c => new
                                       {
                                           c.Country,
                                           c.City
                                       })
                                       .Distinct() 
                                       .ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = resultado;
            }
        }

        private void btnProyeccionSubconjunto_Click(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities1())
            {
                var resultado = context.Products
                                       .Select(p => new
                                       {
                                           p.ProductName,
                                           p.UnitsInStock,
                                           p.UnitsOnOrder
                                       })
                                       .ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = resultado;
            }
        }

        //Renombramiento (ρ)
        private void btnRenombramientoSimple_Click(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities1())
            {
                var resultado = context.Products
                                       .Select(p => new
                                       {
                                           Nombre_Del_Producto = p.ProductName,
                                           Precio_Unitario = p.UnitPrice
                                       })
                                       .ToList();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = resultado;
            }
        }
        private void btnRenombramientoEstructurado_Click(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities1())
            {
                var resultado = context.Customers
                                       .Select(c => new
                                       {
                                           Razon_Social = c.CompanyName,
                                           Contacto_Principal = c.ContactName,
                                           Numero_Telefonico = c.Phone
                                       })
                                       .ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = resultado;
            }
        }
        private void btnRenombramientoCalculado_Click(object sender, EventArgs e)
        {
            using (var context = new NorthwindEntities1())
            {
                var resultado = context.Employees
                                       .Select(emp => new
                                       {
                                           Nombre_Completo_Empleado = emp.FirstName + " " + emp.LastName,
                                           Cargo = emp.Title
                                       })
                                       .ToList();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = resultado;
            }
        }

    }
}
