using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaga
{
    public partial class informacion : Form
    {
        public informacion()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) { activeForm.Close(); }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelHijo.Controls.Add(childForm);
            panelHijo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private int puntos;

        public int Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }
        int contador = 0;

       

        private void informacion_Load(object sender, EventArgs e)
        {
            Form1 child = new Form1();
            openChildForm(child);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblPunto.Text = Puntos.ToString();
            lblTiempo.Text = contador.ToString();
            contador++;
        }
    }
}
