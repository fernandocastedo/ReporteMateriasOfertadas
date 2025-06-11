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
            int codCarrera = int.Parse(txtCodCarrera.Text);
            int codPlan = int.Parse(txtCodPlanEstudio.Text);
            int anio = int.Parse(txtAnio.Text);
            string semestre = txtSemestre.Text;

            EjecutarReporte(codCarrera, codPlan, anio, semestre);

            Reporte obj1 = new Reporte();
            obj1.ShowDialog();
        }

        private void EjecutarReporte(int codCarrera, int codPlanEstudio, int anio, string semestre)
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

            DataTable dt = datos.EjecutarConsultaConParametros(consulta, parametros);

            var rds = new ReportDataSource("DataSet1", dt);

            // Ensure 'reportViewer1' is properly declared and initialized
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        // Add the missing declaration for 'reportViewer1'
        private ReportViewer reportViewer1;
    }
}
