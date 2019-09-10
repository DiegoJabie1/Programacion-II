using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase06_Entidades;

namespace WindowsFormsApp1
{
    public partial class frmTempera : Form
    {
        private Temperas t;

        public Temperas miTempera
        {
            get { return this.t; }
        }

        public frmTempera()
        {
            InitializeComponent();

            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.comboBox1.Items.Add(c);
            }
        }

        private void frmTempera_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedItem = ConsoleColor.Magenta;

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDown;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string marca = this.textBox1.Text;
            int cantidad = int.Parse(this.textBox2.Text);
            ConsoleColor color = (ConsoleColor)this.comboBox1.SelectedItem;
            t = new Temperas(color,marca,cantidad);

            MessageBox.Show(t);

           

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
