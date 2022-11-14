using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using access_windows_form.Modelo;

namespace access_windows_form.Logica
{
    public class L_articulos

    {
        public DataTable Listado_ar(String ctext)
        { // #tb_categorias
            OleDbDataReader Resultado;
            DataTable tabla = new DataTable();
            OleDbConnection SqlCon = new OleDbConnection();
            try
            {

                SqlCon = conexion.getInstancia().crearcon();
                ctext = "%" + ctext.Trim().ToUpper() + "%";
                //string sqltarea = "SELECT * from tb_articulo";
                ctext = "%" + ctext.Trim().ToUpper() + "%";
                string Sqltarea = "SELECT tb_articulo.codigo_ar, tb_articulo.desc_ar, tb_articulo.marca_ar, tb_medidas.desc_me, tb_categorias.desc_ca, tb_articulo.codigo_me, tb_articulo.codigo_ca " +
                                     "FROM((tb_articulo INNER JOIN " +
                                     "tb_categorias ON tb_articulo.codigo_ca = tb_categorias.codigo_ca) INNER JOIN " +
                                     "tb_medidas ON tb_articulo.codigo_me = tb_medidas.codigo_me) " +
                                     "where ucase(trim(tb_articulo.desc_ar)) like '" + ctext + "'";



                /* string sqltarea = "SELECT a.codigo_ar, a.desc_ar,a.marca_ar, b.desc_me,c.desc_ca,a.codigo_me,a.codigo_ ca FROM tb_articulo a"+ "inner join tb_medidas b on a.codigo_me=b.codigo_me"

  + "inner join tb_categorias c on a.codigo_ca=c.codigo_ca"+ "where a.desc_ar like";  
                */

                OleDbCommand cmd = new OleDbCommand(Sqltarea, SqlCon);
                SqlCon.Open();
                Resultado = cmd.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

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
















        public string Guardar_ar(int nOpcion, m_articulo oros)
        {
            string rtpa;
            OleDbConnection sqlcon = new OleDbConnection();

            try
            {
                sqlcon = conexion.getInstancia().crearcon();
                string sqltarea = "";
                if (nOpcion == 1)
                {
                    sqltarea = "Insert into tb_articulo(desc_ar,marca_ar,codigo_me,codigo_ca)" +
                    "Values ('" + oros.desc_ar + "','" + oros.marca_ar + "','" + oros.codigo_me + "','" + oros.codigo_ar + "')";














                    /* sqltarea = "INSERT INTO tb_articulo(desc_ar,marca_ar,codigo_me,codigo_ca)" +
                                " values('" + oros.desc_ar + "','" + oros.marca_ar + "','" + oros.codigo_me + "','" + oros.codigo_ca + "')";
                   */

                }
                else
                {




                    sqltarea = "update tb_articulo set desc_ar='" + oros.desc_ar + "'," +
                                                       " marca_ar='" + oros.marca_ar + "', " +
                                                       " codigo_me=val('" + oros.codigo_me + "'), " +
                                                       " codigo_ca=val('" + oros.codigo_ca + "') " +
                                       " where codigo_ar=val('" + oros.codigo_ar + "')";

                    ;
                    //update
                }






















                OleDbCommand cmd = new OleDbCommand(sqltarea, sqlcon);
                sqlcon.Open();
                rtpa = cmd.ExecuteNonQuery() >= 1 ? "Ok" : "No se pudo ingresar el registro";


            }
            catch (Exception ex)
            {
                rtpa = ex.Message;
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();



            }
            return rtpa;
        }

        public string liminar_ar(int nCodigo_ar)
        {
            string Rpta = "";
            OleDbConnection SqlCon = new OleDbConnection();
            try
            {
                SqlCon = conexion.getInstancia().crearcon();
                string Sql_tarea = "";
                Sql_tarea = "delete from tb_articulo where codigo_ar=val('" + nCodigo_ar + "')";
                OleDbCommand Comando = new OleDbCommand(Sql_tarea, SqlCon);
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public DataTable Listado_me()
        { // #tb_categorias
            OleDbDataReader Resultado;
            DataTable tabla = new DataTable();
            OleDbConnection SqlCon = new OleDbConnection();
            try
            {

                SqlCon = conexion.getInstancia().crearcon();

                //string sqltarea = "SELECT * from tb_articulo";

                string Sqltarea = "SELECT desc_me,codigo_me from tb_medidas";




                /* string sqltarea = "SELECT a.codigo_ar, a.desc_ar,a.marca_ar, b.desc_me,c.desc_ca,a.codigo_me,a.codigo_ ca FROM tb_articulo a"+ "inner join tb_medidas b on a.codigo_me=b.codigo_me"

  + "inner join tb_categorias c on a.codigo_ca=c.codigo_ca"+ "where a.desc_ar like";  
                */


                OleDbCommand cmd = new OleDbCommand(Sqltarea, SqlCon);
                SqlCon.Open();
                Resultado = cmd.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

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




        public DataTable Listado_ca()
        { // #tb_categorias
            OleDbDataReader Resultado;
            DataTable tabla = new DataTable();
            OleDbConnection SqlCon = new OleDbConnection();
            try
            {

                SqlCon = conexion.getInstancia().crearcon();

                //string sqltarea = "SELECT * from tb_articulo";

                string Sqltarea = "SELECT desc_ca,codigo_ca from tb_categorias";




                /* string sqltarea = "SELECT a.codigo_ar, a.desc_ar,a.marca_ar, b.desc_me,c.desc_ca,a.codigo_me,a.codigo_ ca FROM tb_articulo a"+ "inner join tb_medidas b on a.codigo_me=b.codigo_me"

  + "inner join tb_categorias c on a.codigo_ca=c.codigo_ca"+ "where a.desc_ar like";  
                */


                OleDbCommand cmd = new OleDbCommand(Sqltarea, SqlCon);
                SqlCon.Open();
                Resultado = cmd.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

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









       public DataTable buscar()
        { // #tb_categorias
            OleDbDataReader Resultado;
            DataTable tabla = new DataTable();
            OleDbConnection SqlCon = new OleDbConnection();
            try
            {

                SqlCon = conexion.getInstancia().crearcon();

                //string sqltarea = "SELECT * from tb_articulo";

                string Sqltarea = "SELECT * from tb_articulo";




                /* string sqltarea = "SELECT a.codigo_ar, a.desc_ar,a.marca_ar, b.desc_me,c.desc_ca,a.codigo_me,a.codigo_ ca FROM tb_articulo a"+ "inner join tb_medidas b on a.codigo_me=b.codigo_me"

  + "inner join tb_categorias c on a.codigo_ca=c.codigo_ca"+ "where a.desc_ar like";  
                */


                OleDbCommand cmd = new OleDbCommand(Sqltarea, SqlCon);
                SqlCon.Open();
                Resultado = cmd.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;

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
    }
}

    