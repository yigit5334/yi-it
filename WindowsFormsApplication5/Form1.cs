using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        class bilgisayar
        {
            public string cpu;
            public string ram;
            public string disk;        
            }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bilgisayar bil = new bilgisayar();
            bil.cpu = "intel i5";
            bil.ram = "16 gb";
            bil.disk = "512 gb adata";
        }
    }
}
