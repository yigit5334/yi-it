using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        class daire
        {
            private int r;
             public daire(int r)  {this.r=r;}
            public int alanhesaplama()   {return 3*r*r;}
            public int cevrehesalama()    {return 2*3*r;}

        }   
             
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            daire d1=new daire(5);
            MessageBox.Show(d1.alanhesaplama().ToString());
            MessageBox.Show(d1.cevrehesalama().ToString());
        }
    }
}
