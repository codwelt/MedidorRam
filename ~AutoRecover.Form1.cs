using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
namespace ram
{
    public partial class Form1 : Form
    {
        ComputerInfo ObjInfoPC;
        public Form1()
        {
            InitializeComponent();
            ObjInfoPC = new ComputerInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tm1_tick(object sender, EventArgs e)
        {
            pbram.Maximum = Convert.ToInt32(ObjInfoPC.TotalPhysicalMemory);
        }
    }
}
