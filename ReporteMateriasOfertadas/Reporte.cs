using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteMateriasOfertadas
{
    public partial class Reporte : Form
    {
        private DataTable datosReporte;

        // Constructor original (sin parámetros)
        public Reporte()
        {
            InitializeComponent();
        }

        // Constructor que recibe los datos del reporte
        public Reporte(DataTable datos)
        {
            InitializeComponent();
            this.datosReporte = datos;
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // Si hay datos, cargar el reporte
            if (datosReporte != null && datosReporte.Rows.Count > 0)
            {
                // Debug: Mostrar información de los datos
                MessageBox.Show($"Datos recibidos: {datosReporte.Rows.Count} filas, {datosReporte.Columns.Count} columnas",
                               "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarReporte();
            }
            else
            {
                MessageBox.Show("No se recibieron datos para el reporte", "Sin datos",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.reportViewer1.RefreshReport();
            }
        }

        private void CargarReporte()
        {
            try
            {
                // Limpiar fuentes de datos previas
                reportViewer1.LocalReport.DataSources.Clear();

                // Intentar con diferentes nombres de DataSet comunes
                string[] nombresDataSet = {
                    "DataSetMateriasOfertadas",
                    "DataSet1",
                    "dsMateriasOfertadas",
                    "ReporteMateriasOfertadasDataSet",
                    "DataSetReporte"
                };

                bool dataSourceAdded = false;

                foreach (string nombreDS in nombresDataSet)
                {
                    try
                    {
                        var rds = new ReportDataSource(nombreDS, datosReporte);
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        dataSourceAdded = true;
                        break; // Si no hay error, salir del bucle
                    }
                    catch
                    {
                        // Continuar con el siguiente nombre
                        reportViewer1.LocalReport.DataSources.Clear();
                    }
                }

                if (!dataSourceAdded)
                {
                    // Si ningún nombre funcionó, usar el primero y mostrar el error
                    var rds = new ReportDataSource("DataSetMateriasOfertadas", datosReporte);
                    reportViewer1.LocalReport.DataSources.Add(rds);
                }

                // IMPORTANTE: Especifica la ruta de tu archivo .rdlc
                // reportViewer1.LocalReport.ReportPath = "Reports\\ReporteMateriasOfertadas.rdlc";

                // Refrescar el reporte
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el reporte: {ex.Message}\n\nAsegúrate de que:\n1. El archivo .rdlc esté en la ruta correcta\n2. El nombre del DataSet coincida\n3. Los datos no estén vacíos", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // Este evento puede quedarse vacío
        }
    }
}
