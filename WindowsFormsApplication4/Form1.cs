using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        class ogrenci

    {

        public string isim;
        public int no;
        public string sınıf;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ogrenci ogr = new ogrenci();
            ogr.isim = "yiğit şamlı";
            ogr.no = 123;
            ogr.sınıf = "10/a";
        }
    }
}
