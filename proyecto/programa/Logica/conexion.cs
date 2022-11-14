using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace access_windows_form.Logica
{
    public  class conexion
    {
        private String Provider;
        private String Basedatos;
        private static conexion Con = null;


        private conexion ()
        {
            this.Provider = "Microsoft.ACE.OLEDB.12.0";
            this.Basedatos = "C:\\Users\\mjagu\\Documents\\access\\test1.accdb";
        }
        
        public OleDbConnection crearcon()
        {
            OleDbConnection cadena = new OleDbConnection();

            try
            {
                cadena.ConnectionString = "Provider=" + this.Provider + ";Data Source="
                    + this.Basedatos + ";Persist Security Info=False;";
            }
            catch (Exception ex)
            {
                cadena = null; 

                throw ex;
            }
            return cadena;
        }
        public static conexion getInstancia()
        {
            if(Con == null)
            {
                Con = new conexion();
            }
            return Con;
        }



    }
}
