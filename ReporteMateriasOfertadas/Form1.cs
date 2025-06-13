using Microsoft.Reporting.WinForms;
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

namespace ReporteMateriasOfertadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtCodCarrera.Text) ||
                    string.IsNullOrWhiteSpace(txtCodPlanEstudio.Text) ||
                    string.IsNullOrWhiteSpace(txtAnio.Text) ||
                    string.IsNullOrWhiteSpace(txtSemestre.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Campos requeridos",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int codCarrera = int.Parse(txtCodCarrera.Text);
                int codPlan = int.Parse(txtCodPlanEstudio.Text);
                int anio = int.Parse(txtAnio.Text);
                string semestre = txtSemestre.Text;

                // Obtener los datos del reporte
                DataTable dt = ObtenerDatosReporte(codCarrera, codPlan, anio, semestre);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron materias para los parámetros especificados.",
                                   "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Crear y mostrar el formulario de reporte pasándole los datos
                Reporte1 formReporte = new Reporte1(dt);
                formReporte.ShowDialog();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en los campos correspondientes.",
                               "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ObtenerDatosReporte(int codCarrera, int codPlanEstudio, int anio, string semestre)
        {
            gdatos datos = new gdatos();

            string consulta = "EXEC dbo.spReporteMateriasOfertadas @CodCarrera, @CodPlanEstudio, @Anio, @Semestre";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@CodCarrera", SqlDbType.Int) { Value = codCarrera },
                new SqlParameter("@CodPlanEstudio", SqlDbType.Int) { Value = codPlanEstudio },
                new SqlParameter("@Anio", SqlDbType.Int) { Value = anio },
                new SqlParameter("@Semestre", SqlDbType.VarChar, 20) { Value = semestre }
            };

            return datos.EjecutarConsultaConParametros(consulta, parametros);
        }
    }
}
