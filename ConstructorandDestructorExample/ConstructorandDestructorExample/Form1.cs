using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructorandDestructorExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Constructor");
        }
        ~Form1()
        {
            MessageBox.Show("Desctructor");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            Form1 obj1 = new Form1();
            Form1 obj2 = new Form1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
