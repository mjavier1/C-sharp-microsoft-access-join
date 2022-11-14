using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using access_windows_form.Modelo;
using System.Windows.Forms;
using access_windows_form.Logica;
using Microsoft.Reporting.WinForms;

namespace access_windows_form
{
    public partial class Reportes1 : Form
    {
        public Reportes1()
        {
            InitializeComponent();
        }

        #region
        public void Listado_ar()
        { // #tb_categorias
            OleDbDataReader Resultado;
            DataTable tabla = new DataTable();
            OleDbConnection SqlCon = new OleDbConnection();
            try
            {

                SqlCon = conexion.getInstancia().crearcon();

                //string sqltarea = "SELECT * from tb_articulo";








                string Sqltarea = "SELECT tb_articulo.codigo_ar, tb_articulo.desc_ar, tb_articulo.marca_ar, tb_medidas.desc_me, tb_categorias.desc_ca " +
                              "FROM ((tb_articulo INNER JOIN " +
                              "tb_categorias ON tb_articulo.codigo_ca = tb_categorias.codigo_ca) INNER JOIN " +
                              "tb_medidas ON tb_articulo.codigo_me = tb_medidas.codigo_me) ";





              



                OleDbDataAdapter da = new OleDbDataAdapter(Sqltarea, SqlCon);
                SqlCon.Open();
                DataSet ds = new DataSet();
                da.Fill(ds);
                ReportDataSource ff = new ReportDataSource("DataSet1", ds.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ff);
                reportViewer1.LocalReport.ReportEmbeddedResource = "access_windows_form.Reportes.Report1.rdlc";
                reportViewer1.LocalReport.Refresh();
                reportViewer1.Refresh();
                reportViewer1.RefreshReport();






                /* string sqltarea = "SELECT a.codigo_ar, a.desc_ar,a.marca_ar, b.desc_me,c.desc_ca,a.codigo_me,a.codigo_ ca FROM tb_articulo a"+ "inner join tb_medidas b on a.codigo_me=b.codigo_me"

  + "inner join tb_categorias c on a.codigo_ca=c.codigo_ca"+ "where a.desc_ar like";  
                */


                //OleDbDataReader reader = cmd.ExecuteReader();



            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }
        #endregion
        private void Reportes1_Load(object sender, EventArgs e)
        {

            //      this.reportViewer1.RefreshReport();

            this.Listado_ar();
        }
    }
}
