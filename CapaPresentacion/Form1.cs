using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;
using Microsoft.Office.Interop.Excel;
using objExcel = Microsoft.Office.Interop.Excel;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        SqlConnection conn;
        CN_Productos objetoCN = new CN_Productos();
        private string idProducto = null;
        private bool Editar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProdctos();
            this.FormClosed += new FormClosedEventHandler(Cerrarforms);
            getData();
        }

        private void Cerrarforms(object sender, EventArgs e)
        {
            MessageBox.Show("ESTA A PUNTO DE VOLVER AL LOGIN");
            Login formprincipal = new Login();
            this.Hide();
            formprincipal.Show();
        }

        private void MostrarProdctos()
        {
            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarPRod(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarProdctos();
                    limpiarForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex);
                }
            }
            if (Editar == true)
            {

                try
                {
                    objetoCN.EditarProd(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, idProducto);
                    MessageBox.Show("Se actualizo correctamente");
                    MostrarProdctos();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                textBox1.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila, :)");
        }

        private void limpiarForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "";
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarPRod(idProducto);
                MessageBox.Show("Esta a punto de eliminar un producto, esta seguro?");
                MessageBox.Show("Eliminado correctamente");
                MostrarProdctos();
            }
            else
            {
                MessageBox.Show("Seleccion la fila :)");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            objExcel.Application objAplicacion = new objExcel.Application();
            Workbook objLibro = objAplicacion.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet objHoja = (Worksheet)objAplicacion.ActiveSheet;

            objAplicacion.Visible = false;

            foreach (DataGridViewColumn columna in dataGridView1.Columns)
            {
                objHoja.Cells[1, columna.Index + 1] = columna.HeaderText;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    objHoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value;
                }
            }

            objLibro.SaveAs(ruta + "\\ReporteTXT.xlsx");
            objLibro.Close();
            objAplicacion.Quit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CD_Productos cProdcutos = new CD_Productos();
            dataGridView1.DataSource = cProdcutos.Buscar(txtBuscar.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getData()
        {
            CD_Productos cProdcutos = new CD_Productos();
            dataGridView1.DataSource = cProdcutos.Mostrar();
        }
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Ingrese nombre del producto") txtBuscar.Text = "";
        }

        private void txtBuscar_Leave_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Ingrese nombre del producto";
                getData();
            }
        }
    }
}