using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaEF
{
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2001";
            TextBox[] Grupotextbox = { txtid, txtnombre, txtapellido, txtfecha,txtgenero,txtdireccion,txttelefono,txtestado,txtreferencia };
            TextBox[] Idtextbox = { txtid, txtnombre };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "sig");
        }
    }
}
