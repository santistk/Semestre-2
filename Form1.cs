using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBiblioteca.Modelos;


namespace GestionBiblioteca
{
    public partial class Form1 : Form
    {
        private List<Libro> libros;
        private List<Miembro> miembros;
        private List<Prestamo> prestamos;

        public Form1()
        {
            InitializeComponent();
            libros = new List<Libro>();
            miembros = new List<Miembro>();
            prestamos = new List<Prestamo>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboTipoLibro.Items.Add("Físico");
            comboTipoLibro.Items.Add("Electrónico");
            comboMiembros.DataSource = miembros;
            comboMiembros.DisplayMember = "Nombre";
        }

        private void buttonAgregarLibro_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textTitulo.Text) ||
                string.IsNullOrWhiteSpace(textAutor.Text) ||
                !int.TryParse(textAño.Text, out int año))
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.");
                return;
            }

            
            Libro libro;
            if (comboTipoLibro.SelectedItem.ToString() == "Físico")
            {
                libro = new LibroFisico(
                    textTitulo.Text,
                    textAutor.Text,
                    año,
                    textUbicacion.Text
                );
            }
            else
            {
                if (!double.TryParse(textTamañoArchivo.Text, out double tamañoArchivo))
                {
                    MessageBox.Show("Por favor, ingresa un tamaño de archivo válido.");
                    return;
                }
                libro = new LibroElectronico(
                    textTitulo.Text,
                    textAutor.Text,
                    año,
                    textFormato.Text,
                    tamañoArchivo
                );
            }

            libros.Add(libro);
            ActualizarDataGridViewLibros();
            LimpiarCamposLibro();
        }

        private void buttonEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dataGridViewLibro.SelectedRows.Count > 0)
            {
                var row = dataGridViewLibro.SelectedRows[0];
                var libro = (Libro)row.DataBoundItem;
                libros.Remove(libro);
                ActualizarDataGridViewLibros();
            }
        }

        private void buttonRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            if (dataGridViewLibro.SelectedRows.Count > 0 && comboMiembros.SelectedItem != null)
            {
                var libro = (Libro)dataGridViewLibro.SelectedRows[0].DataBoundItem;
                var miembro = (Miembro)comboMiembros.SelectedItem;

                var prestamo = new Prestamo
                {
                    Libro = libro,
                    Miembro = miembro,
                    FechaPrestamo = DateTime.Now
                };

                prestamos.Add(prestamo);
                ActualizarDataGridViewPrestamos();
            }
            else
            {
                MessageBox.Show("Selecciona un libro y un miembro para registrar el préstamo.");
            }
        }

        private void buttonDevolverLibro_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrestamos.SelectedRows.Count > 0)
            {
                var row = dataGridViewPrestamos.SelectedRows[0];
                var prestamo = (Prestamo)row.DataBoundItem;
                prestamo.FechaDevolucion = DateTime.Now;
                ActualizarDataGridViewPrestamos();
                ActualizarDataGridViewDevoluciones();
            }
        }

        private void buttonAgregarMiembro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombreMiembro.Text) ||
                !int.TryParse(textNumeroMiembro.Text, out int numeroMiembro))
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.");
                return;
            }

            var miembro = new Miembro
            {
                Nombre = textNombreMiembro.Text,
                NumeroMiembro = numeroMiembro
            };

            miembros.Add(miembro);
            comboMiembros.DataSource = null;
            comboMiembros.DataSource = miembros;
            comboMiembros.DisplayMember = "Nombre";
            LimpiarCamposMiembro();
        }

        private void ActualizarDataGridViewLibros()
        {
            dataGridViewLibro.DataSource = null;
            dataGridViewLibro.DataSource = libros;
        }

        private void ActualizarDataGridViewPrestamos()
        {
            dataGridViewPrestamos.DataSource = null;
            dataGridViewPrestamos.DataSource = prestamos.Where(p => p.FechaDevolucion == null).ToList();
        }

        private void ActualizarDataGridViewDevoluciones()
        {
            dataGridViewDevoluciones.DataSource = null;
            dataGridViewDevoluciones.DataSource = prestamos.Where(p => p.FechaDevolucion != null).ToList();
        }

        private void LimpiarCamposLibro()
        {
            textTitulo.Clear();
            textAutor.Clear();
            textAño.Clear();
            textUbicacion.Clear();
            textFormato.Clear();
            textTamañoArchivo.Clear();
            comboTipoLibro.SelectedIndex = -1;
        }

        private void LimpiarCamposMiembro()
        {
            textNombreMiembro.Clear();
            textNumeroMiembro.Clear();
        }
    }
}