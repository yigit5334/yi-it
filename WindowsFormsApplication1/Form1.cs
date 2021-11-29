using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
       public class Ucgen {
 int a;
 int b;
 int c;
 public int A
 {
 get { return a; }
 set
 { if (value <= 0) Console.WriteLine("Hatalı bilgi"); else a = value; } }
 public int B
 {
 get { return b; }
 set
 { if (value <= 0) Console.WriteLine("Hatalı bilgi"); else b = value; }
 }
 public int C {
 get { return c; }
 set
 { if (value <= 0) Console.WriteLine("Hatalı bilgi"); else c = value; }
 }
}

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
