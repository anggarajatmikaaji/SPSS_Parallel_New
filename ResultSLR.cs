using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelSPSS
{
    public partial class ResultSLR : Form
    {
        public ResultSLR()
        {
            InitializeComponent();
        }

        private void ResultSLR_Load(object sender, EventArgs e)
        {
            Form1.columnChoosen = new List<string>();
            Form1.ab = new string[2];
        }
    }
}
