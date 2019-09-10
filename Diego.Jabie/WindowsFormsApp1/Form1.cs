using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();

            this.IsMdiContainer = true; // para que el formulario pueda contener otros forms

            this.WindowState = FormWindowState.Maximized; 
        }

        private void administraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void temperasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTempera frm= new frmTempera();//formulario de temperas

            //frm.MdiParent = this;

            frm.ShowDialog();
            frm.Show();

            this.miTempera = frm.miTempera;
            this.listBox1.Items.Add(this.miTempera);
       }

        private void crearPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.groupBox1.Visible = false;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
