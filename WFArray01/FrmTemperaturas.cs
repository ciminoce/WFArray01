using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFArray01
{
    public partial class FrmTemperaturas : Form
    {
        private double[] temperaturas = new double[7];
        private int index = -1;//Variable para controlar las posiciones en el vector
        private bool esEdicion = false;

        private DataGridViewRow r;

        private readonly string _archivo = Environment.CurrentDirectory + @"\Temperaturas.txt";
        public FrmTemperaturas()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var temperatura = double.Parse(TemperaturaTextBox.Text);
                if (!temperaturas.Contains(temperatura))
                {
                    if (!esEdicion)
                    {
                        index++;
                        temperaturas[index] = temperatura;

                        DataGridViewRow r = new DataGridViewRow();
                        r.CreateCells(DatosDataGridView);
                        SetearFila(r, temperatura);
                        AgregarFila(r);
                        MessageBox.Show("Registro agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        temperaturas[indexSeleccionado] = temperatura;
                        SetearFila(r, temperatura);
                        esEdicion = false;
                        MessageBox.Show("Registro Modificado", "Mensaje", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }
                    InicializarControles();
                    if (index < 6)
                    {
                        TemperaturaTextBox.Enabled = true;
                        OKButton.Enabled = true;
                        CancelarButton.Enabled = true;
                    }
                    else
                    {
                        TemperaturaTextBox.Enabled = false;
                        OKButton.Enabled = false;
                        CancelarButton.Enabled = false;
                    }

                }
                else
                {
                    errorProvider1.SetError(TemperaturaTextBox, "Temperatura repetida!!!");
                    TemperaturaTextBox.SelectAll();
                    TemperaturaTextBox.Focus();
                }
            }
        }

        private void SetearFila(DataGridViewRow r, double temperatura)
        {
            r.Cells[colCelsius.Index].Value = temperatura;
            r.Cells[colFahrenheit.Index].Value = ConvertirFahrenheit(temperatura);
            r.Cells[colReaumur.Index].Value = ConvertirReaumur(temperatura);

            r.Tag = temperatura;

        }

        private void InicializarControles()
        {
            TemperaturaTextBox.Clear();
            TemperaturaTextBox.Focus();
        }

        private double ConvertirReaumur(double temperatura)
        {
            return temperatura * 0.8;
        }

        private double ConvertirFahrenheit(double temperatura)
        {
            return temperatura * 1.8 + 32;
        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            errorProvider1.Clear();
            if (!double.TryParse(TemperaturaTextBox.Text, out double temp))
            {
                esValido = false;
                errorProvider1.SetError(TemperaturaTextBox, "Temperatura no válida");
            }
            else if (temp < -10 || temp > 50)
            {
                esValido = false;
                errorProvider1.SetError(TemperaturaTextBox, "Temperatura fuera del rango permitido [-10,50]");
            }
            return esValido;
        }


        private void MostrarButton_Click(object sender, EventArgs e)
        {
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void MostrarEstadisticasButton_Click(object sender, EventArgs e)
        {
            var promedio = HallarPromedio();
            var maxTemperatura = HallarMayorTemperatura();
            var minTemperatura = HallarMenorTemperatura();
            MostrarDatosEstadisticos(promedio, maxTemperatura, minTemperatura);
            MarcarSuperioresAlPromedio(promedio);
        }

        private void MostrarDatosEstadisticos(double promedio, double maxTemperatura, double minTemperatura)
        {
            PromedioLabel.Text = promedio.ToString("#0.0");
            MayorLabel.Text = maxTemperatura.ToString();
            MenorLabel.Text = minTemperatura.ToString();
        }

        private double HallarMenorTemperatura()
        {
            var minima = 51d;
            foreach (var temperatura in temperaturas)
            {
                if (temperatura < minima)
                {
                    minima = temperatura;
                }
            }
            return minima;
        }

        private double HallarMayorTemperatura()
        {
            var maxima = -11d;
            foreach (var temperatura in temperaturas)
            {
                if (temperatura > maxima)
                {
                    maxima = temperatura;
                }
            }

            return maxima;
        }

        private double HallarPromedio()
        {
            var promedio = 0d;
            foreach (var temperatura in temperaturas)
            {
                promedio += temperatura;
            }

            return promedio / temperaturas.Length;

        }

        private void MarcarSuperioresAlPromedio(double promedio)
        {
            foreach (DataGridViewRow r in DatosDataGridView.Rows)
            {
                double temperatura = (double)r.Tag;
                if (temperatura > promedio)
                {
                    //r.Cells[colMayorPromedio.Index].Value = "*";
                    r.DefaultCellStyle.BackColor = Color.BurlyWood;
                }
                else
                {
                    r.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private int indexSeleccionado = -1;
        private void DatosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            indexSeleccionado = e.RowIndex;//obtengo el nro. de fila seleccionado
            if (e.ColumnIndex == 3)
            {
                esEdicion = true;
                r = DatosDataGridView.Rows[indexSeleccionado];//Obtengo la fila seleccionada
                var temperatura = (double)r.Tag;

                TemperaturaTextBox.Text = temperatura.ToString();
                TemperaturaTextBox.Enabled = true;
                OKButton.Enabled = true;
                CancelarButton.Enabled = true;

                TemperaturaTextBox.Focus();
            }

            if (e.ColumnIndex == 4)
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?", "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    //Borrar una fila
                    BorrarElemento(indexSeleccionado);//Corre los contenidos
                    DataGridViewRow r = DatosDataGridView.Rows[indexSeleccionado];//Obtengo la fila seleccionada
                    DatosDataGridView.Rows.Remove(r);//Borra de la grilla
                    index--;//decremento el contador de elementos ingresados del vector
                    if (index < 6)
                    {
                        TemperaturaTextBox.Enabled = true;
                        OKButton.Enabled = true;
                        CancelarButton.Enabled = true;
                    }
                    else
                    {
                        TemperaturaTextBox.Enabled = false;
                        OKButton.Enabled = false;
                        CancelarButton.Enabled = false;
                    }


                    MessageBox.Show("Registro Borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void BorrarElemento(int indiceElementoBorrar)
        {
            if (indiceElementoBorrar == temperaturas.Length - 1)
            {
                temperaturas[indiceElementoBorrar] = 0;
            }
            else
            {
                for (int i = indiceElementoBorrar; i < temperaturas.Length - 1; i++)
                {
                    temperaturas[i] = temperaturas[i + 1];
                }
                temperaturas[temperaturas.Length - 1] = 0;
            }
        }

        private void GuardarDatosButton_Click(object sender, EventArgs e)
        {
            //Guardar la info en archivo secuencial
            StreamWriter escritor = new StreamWriter(_archivo);//defino un objeto para escribir en el arch
            for (int i = 0; i <= index; i++)
            {
                var linea = temperaturas[i].ToString();//creo la linea a guardar
                escritor.WriteLine(linea);//guardo en el archivo
            }
            escritor.Close(); //cierro el archivo
            MessageBox.Show("Registos guardados en archivo");
        }

        private void FrmTemperaturas_Load(object sender, EventArgs e)
        {
            if (!File.Exists(_archivo))
            {
                MessageBox.Show("No hay datos para leer");
                return;
            }

            CargarDatosDelArchivo();
            MostrarDatosEnGrilla();
            if (index < 6)
            {
                TemperaturaTextBox.Enabled = true;
                OKButton.Enabled = true;
                CancelarButton.Enabled = true;
            }
            else
            {
                TemperaturaTextBox.Enabled = false;
                OKButton.Enabled = false;
                CancelarButton.Enabled = false;
            }

        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var temperatura in temperaturas)
            {
                DataGridViewRow r = new DataGridViewRow();//crea una fila en blanco
                r.CreateCells(DatosDataGridView);//crea las celdas en la fila

                SetearFila(r, temperatura);

                AgregarFila(r);

            }

        }

        private void CargarDatosDelArchivo()
        {
            StreamReader lector = new StreamReader(_archivo);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                double temperatura = double.Parse(linea);
                index++;
                temperaturas[index] = temperatura;
            }
        }
    }
}
