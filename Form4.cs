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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activity6DataSet1.status_mahasiswa' table. You can move, or remove it, as needed.
            this.status_mahasiswaTableAdapter.Fill(this.activity6DataSet1.status_mahasiswa);

        }
    }
}
