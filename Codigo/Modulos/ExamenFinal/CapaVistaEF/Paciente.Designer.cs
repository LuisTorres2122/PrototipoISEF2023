
namespace CapaVistaEF
{
    partial class Paciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navegador1 = new NavegadorVista.Navegador();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtgenero = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtreferencia = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(147, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(93, 183);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 1;
            this.txtid.Tag = "pk_idPaciente";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(312, 183);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.Tag = "nombrePaci";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(759, 183);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 3;
            this.txtfecha.Tag = "FechaNacimiento";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(534, 183);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 4;
            this.txtapellido.Tag = "apellidoPaci";
            // 
            // txtgenero
            // 
            this.txtgenero.Location = new System.Drawing.Point(93, 279);
            this.txtgenero.Name = "txtgenero";
            this.txtgenero.Size = new System.Drawing.Size(100, 20);
            this.txtgenero.TabIndex = 5;
            this.txtgenero.Tag = "Genero";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(312, 276);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(100, 20);
            this.txtdireccion.TabIndex = 6;
            this.txtdireccion.Tag = "direccionPAci";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(759, 279);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(100, 20);
            this.txtestado.TabIndex = 7;
            this.txtestado.Tag = "estadoPaci";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(534, 279);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 8;
            this.txttelefono.Tag = "Telefono";
            // 
            // txtreferencia
            // 
            this.txtreferencia.Location = new System.Drawing.Point(93, 365);
            this.txtreferencia.Name = "txtreferencia";
            this.txtreferencia.Size = new System.Drawing.Size(100, 20);
            this.txtreferencia.TabIndex = 9;
            this.txtreferencia.Tag = "fk_idReferencia";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 418);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 219);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Tag = "tbl_paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Genero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Direccion ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(699, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Referencia";
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 696);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtreferencia);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtgenero);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.navegador1);
            this.Name = "Paciente";
            this.Text = "Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtgenero;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtreferencia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}