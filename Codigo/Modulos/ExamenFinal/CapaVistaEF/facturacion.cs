using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorEF;

namespace CapaVistaEF
{
    public partial class facturacion : Form
    {
        TControlador controlador = new TControlador();
        public facturacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtidex, txtnombre, txtprecio, txtcantidad };
            controlador.addRow(textBoxes, dataGridView1,txttotal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtdoc, txtpaciente ,txttotal,txtpago};
            controlador.transaccion(dataGridView1, textBoxes);

            TextBox[] textBoxe2s = { txtdoc, txtidex, txtpaciente, txtpago, txtcantidad, txtprecio, txtnombre, txttotal };
            controlador.menu(textBoxe2s, dataGridView1);
        }

        private void txtidex_TextChanged(object sender, EventArgs e)
        {
            TextBox[] campos = { txtnombre, txtprecio };
            if (txtidex.TextLength != 0)
            {

                controlador.llenardatostextbox(campos, txtidex.Text);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void facturacion_Load(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { txtdoc, txtidex,txtpaciente,txtpago,txtcantidad,txtprecio,txtnombre,txttotal};
            controlador.menu(textBoxes,dataGridView1);
        }
    }
}
