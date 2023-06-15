using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaModeloEF
{
    public class TSentencia
    {
        Conexion con = new Conexion();

        

        public void actualizartransaccion(string encabezado, string[] detalle)
        {
            
                OdbcCommand command = new OdbcCommand();
                OdbcTransaction transaction = null;
                OdbcConnection conn = con.connection;
                command.Connection = conn;
                try
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    command.Connection = conn;
                    command.Transaction = transaction;

                             
                    command.CommandText = encabezado;
                    command.ExecuteNonQuery();

                for(int x = 0; x < detalle.Length-1; x++)
                {
                    Console.WriteLine("Detalle: " + detalle.Length);
                    Console.WriteLine(detalle[x]);
                 command.CommandText = detalle[x];
                 command.ExecuteNonQuery();
                }
               

                transaction.Commit();
                    Console.WriteLine("guardado en base de datos");
                    conn.Close();
            }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    try
                    {
                     transaction.Rollback();
                    }
                    catch
                    {

                    }
                    finally
                    {
                       conn.Close();
                    }
                }
            

        }

        public string buscarid(string tabla, string tipo)
        {
            string dato = " ";
            try
            {

                string sql = "select " + tipo + " from " + tabla + " Order by " + tipo + " Desc Limit 1";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader lr = cmd.ExecuteReader();
                while (lr.Read())
                {
                    dato = lr.GetString(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }


            return dato;
        }

        public int estadotabla(string tabla)
        {
            int dato = 0;
            string sql = "select count(*) as total from " + tabla;
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {

                dato = lr.GetInt32(0);


            }
            return dato;
        }

        public string[] campostextbox(string id)
        {

            string[] datos = new string[2];
            string sql = "select nombreExam, precio from tbl_examen  where  pk_idExamen = '" + id + "'";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {

                datos[0] = lr.GetString(0);
                datos[1] = lr.GetString(1);
             

            }



            return datos;
        }
    }
}
