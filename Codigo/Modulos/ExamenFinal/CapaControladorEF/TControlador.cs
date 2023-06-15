using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaModeloEF;
using System.Data;

namespace CapaControladorEF
{
    public class TControlador
    {
        TSentencia sn = new TSentencia();
     //  Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();
// cnseg.setBtitacora("5102", "Balance general proveedores");

        double sumaColumna(DataGridView tabla)
        {
            double suma = 0;
            foreach (DataGridViewRow row in tabla.Rows)
            {
                suma += Convert.ToDouble(row.Cells["Column5"].Value);
                
            }
            return suma;
        }

        void insertarDataGrid(DataGridView tabla, TextBox[] datos, TextBox txttotal) {

            double total = Convert.ToDouble(datos[2].Text) * Convert.ToDouble(datos[3].Text);
            tabla.Rows.Add(datos[0].Text, datos[1].Text, datos[2].Text, datos[3].Text, total);
            limpiar(datos);
            txttotal.Text =  sumaColumna(tabla).ToString();
            
        }

        void limpiar(TextBox[] textBoxes)
        {
            for(int x= 0; x< textBoxes.Length; x++)
            {
                textBoxes[x].Clear();
            }
        }
        public void addRow(TextBox[] textBoxes, DataGridView tabla, TextBox total)
        {
            
            insertarDataGrid(tabla, textBoxes, total);


        }

         string GenerarCadenaAleatoria()
        {
            string caracteres = "sadjfhsdlkfjhsdlfiujsdlfkjheoifosdnclkgfwer";
            int longitud = 10;
            Random random = new Random();
            char[] buffer = new char[longitud];

            for (int i = 0; i < longitud; i++)
            {
                int indiceAleatorio = random.Next(caracteres.Length);
                buffer[i] = caracteres[indiceAleatorio];
            }

            return new string(buffer);
        }
         
        string generarEncabezado(TextBox[] textBoxes)
        {
            Random random = new Random();
            string serie=GenerarCadenaAleatoria();
            int numf = random.Next(); ;

             string sql = "insert into tbl_encabezadofactura (pk_idEncabezado, serieFactura, numFactura, fk_idPaciente, fechaOrden, total, fk_idTipoPago)" +
                "values ('" + textBoxes[0].Text + "', '" + serie + "', " + numf + ", " + textBoxes[1].Text + ", '" + DateTime.Now.Date.ToString("yyyyMMdd") + "', " + textBoxes[2].Text + ", " + textBoxes[3].Text + " );";
            return sql;
        }

        string[] generarDetalle(DataGridView tabla, string idencabezado)
        {
            string[] datos = new string[tabla.Rows.Count];
            string sql;
            int nuevoid;
            if (tabla.Rows.Count > 1)
            {
                string iddetalle = crearidwo("tbl_detallefactura", "pk_idDetallefac");
                nuevoid = Convert.ToInt32(iddetalle);
                for (int x = 0; x < tabla.Rows.Count - 1; x++)
                {
                    nuevoid += 1;
                    string idexamen = tabla.Rows[x].Cells[0].Value.ToString();
                    string total = tabla.Rows[x].Cells[4].Value.ToString();
                    sql = "insert into tbl_detallefactura (pk_idDetallefac, fk_idEncabezado, fk_idExamen,subtotal ) values ("+ nuevoid +", "+ idencabezado+", " +idexamen+ ", "+ total + ");";
                    datos[x] = sql;
                   
                }
            }

                return datos;
        }


        public void transaccion(DataGridView data, TextBox[] textBoxes)
        {
            string encabezado = generarEncabezado(textBoxes);
            string[] detalle = generarDetalle(data,textBoxes[0].Text);

            sn.actualizartransaccion(encabezado, detalle);
        }


        public string crearidwo(string tabla, string campo)//Crea el id siguiente a ingresar
        {
            string textbox = "";
            try
            {
                int incremento = 0;

                int permiso = comprobacionvacio(tabla);
                if (permiso != 0)
                {
                    string resultado = sn.buscarid(tabla, campo);
                    incremento = Convert.ToInt32(resultado) + 1;
                    textbox = incremento.ToString();
                }
                else
                {
                    incremento = 1;
                    textbox = incremento.ToString();
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            return textbox;
        }

        public int comprobacionvacio(string tabla)
        {
            int resultado = 0;
            resultado = sn.estadotabla(tabla);

            return resultado;
        }

        public void llenardatostextbox(TextBox[] textbox, string id)
        {
            try
            {


                string[] datos = sn.campostextbox(id);
                for (int x = 0; x < 2; x++)
                {
                    textbox[x].Text = datos[x];
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);

            }

        }


        public void menu(TextBox[] textBoxes, DataGridView datagrdiView)
        {
            limpiar(textBoxes);
            datagrdiView.Rows.Clear();
            crearid(textBoxes[0], "tbl_encabezadofactura", " ", "pk_idEncabezado");

        }
        public void crearid(TextBox textbox, string tabla, string codigo, string campo)//Crea el id siguiente a ingresar
        {

            try
            {
                int incremento = 0;

                int permiso = comprobacionvacio(tabla);
                if (permiso != 0)
                {
                    string resultado = sn.buscarid(tabla, campo);
                    incremento = Convert.ToInt32(resultado) + 1;
                    textbox.Text = incremento.ToString();
                }
                else
                {
                    incremento = 1;
                    textbox.Text = incremento.ToString();
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

        }

    }
}
