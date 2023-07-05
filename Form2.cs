using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environment
{
    public partial class Form2 : Form
    {
        private string stringConnection = "data source=LAPTOP-JFGCC1VG\\MSSQLSERVER01;database=activity6;User ID = sa; Password = 123";
        private SqlConecction koneksi;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activity6DataSet.Prodi' table. You can move, or remove it, as needed.
            this.prodiTableAdapter.Fill(this.activity6DataSet.Prodi);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
