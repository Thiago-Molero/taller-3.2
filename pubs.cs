using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pubs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnionUbicaciones_Click(object sender, EventArgs e)
        {
            using (var context = new pubsEntities1())
            {
                context.Configuration.LazyLoadingEnabled = false;
                var autoresCA = context.authors.Where(a => a.state == "CA")
                                       .Select(a => new { a.au_fname, a.au_lname, a.state });
                var autoresUT = context.authors.Where(a => a.state == "UT")
                                       .Select(a => new { a.au_fname, a.au_lname, a.state });
                var resultado = autoresCA.Union(autoresUT).ToList();

                dgv1.DataSource = null;
                dgv1.DataSource = resultado;
            }
        }

        private void btnUnionPersonas_Click(object sender, EventArgs e)
        {
            using (var context = new pubsEntities1())
            {
                context.Configuration.LazyLoadingEnabled = false;

                var autores = context.authors.Select(a => new { Nombre = a.au_fname, Apellido = a.au_lname, Tipo = "Autor" });
                var empleados = context.employees.Select(emp => new { Nombre = emp.fname, Apellido = emp.lname, Tipo = "Empleado" });

                var resultado = autores.Union(empleados).ToList();

                dgv1.DataSource = null;
                dgv1.DataSource = resultado;
            }
        }

        private void btnUnionPrecios_Click(object sender, EventArgs e)
        {
            using (var context = new pubsEntities1())
            {
                context.Configuration.LazyLoadingEnabled = false;

                var baratos = context.titles.Where(t => t.price < 10).Select(t => new { Titulo = t.title1, t.price });   
                var caros = context.titles.Where(t => t.price > 20).Select(t => new { Titulo = t.title1, t.price });

                var resultado = baratos.Union(caros).ToList();


                dgv1.DataSource = null;
                dgv1.DataSource = resultado;
            }
        }

        private void btnDiferenciaAutores_Click(object sender, EventArgs e)
        {
            using (var context = new pubsEntities1())
            {
                context.Configuration.LazyLoadingEnabled = false;

                var todosLosAutores = context.authors.Select(a => new { a.au_fname, a.au_lname, a.state });
                var autoresCalifornia = context.authors.Where(a => a.state == "CA").Select(a => new { a.au_fname, a.au_lname, a.state });

                var resultado = todosLosAutores.Except(autoresCalifornia).ToList();

                dgv1.DataSource = null;
                dgv1.DataSource = resultado;
            }
        }

        private void btnDiferenciaAnticipos_Click(object sender, EventArgs e)
        {
            using (var context = new pubsEntities1())
            {
                context.Configuration.LazyLoadingEnabled = false;

                var buenAnticipo = context.titles.Where(t => t.advance > 5000).Select(t => new { t.title1, t.price });
                var muyCaros = context.titles.Where(t => t.price > 15).Select(t => new { t.title1, t.price });

                // Libros que le dieron buen anticipo al autor, EXCEPTO los que cuestan más de 15
                var resultado = buenAnticipo.Except(muyCaros).ToList();

                dgv1.DataSource = null;
                dgv1.DataSource = resultado;
            }
        }

        private void btnDiferenciaEditores_Click(object sender, EventArgs e)
        {
            using (var context = new pubsEntities1())
            {
                context.Configuration.LazyLoadingEnabled = false;

                var editoresUSA = context.publishers.Where(p => p.country == "USA").Select(p => new { p.pub_name, p.state });
                var editoresNY = context.publishers.Where(p => p.state == "NY").Select(p => new { p.pub_name, p.state });

                var resultado = editoresUSA.Except(editoresNY).ToList();

                dgv1.DataSource = null;
                dgv1.DataSource = resultado;
            }
        }

        private void btnCartesianoAutoresEditores_Click(object sender, EventArgs e)
        {
            using (var context = new pubsEntities1())
            {
                context.Configuration.LazyLoadingEnabled = false;

                // Álgebra Relacional: Producto Cartesiano
                var resultado = (from a in context.authors
                                 from p in context.publishers
                                 select new
                                 {
                                     Autor = a.au_fname + " " + a.au_lname,
                                     Editorial = p.pub_name
                                 }).ToList();

                dgv1.DataSource = null;
                dgv1.DataSource = resultado;
            }
        }

        private void btnCartesianoTiendasCargos_Click(object sender, EventArgs e)
        {
            using (var context = new pubsEntities1())
            {
                context.Configuration.LazyLoadingEnabled = false;

                var resultado = (from s in context.stores
                                 from j in context.jobs
                                 select new
                                 {
                                     Tienda = s.stor_name,
                                     Cargo = j.job_desc
                                 }).ToList();

                dgv1.DataSource = null;
                dgv1.DataSource = resultado;
            }
        }

        private void btnCartesianoAutoresLibros_Click(object sender, EventArgs e)
        {
            using (var context = new pubsEntities1())
            {
                context.Configuration.LazyLoadingEnabled = false;

                var resultado = (from a in context.authors
                                 from t in context.titles
                                 select new
                                 {
                                     Autor = a.au_fname,
                                     Libro = t.title1
                                 }).ToList();

                dgv1.DataSource = null;
                dgv1.DataSource = resultado;
            }
        }
    }
}
