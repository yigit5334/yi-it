using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        class Daire
        {

            public float Alan(float ycap)
            {
                return Convert.ToSingle(Math.PI * ycap * ycap);
            }

            public float Cevre(float ycap)
            {
                return Convert.ToSingle(2 * Math.PI * ycap);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        
            static void Main(string[] args)
            {
float yaricap;
Daire daire = new Daire();
 
Console.Write("Çemberin Yarı Çapını Giriniz :");
yaricap = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Çemberin Alanı :{3:F2}",daire.Alan(yaricap));
Console.WriteLine("Çemberin Çevresi :{5:F2}", daire.Cevre(yaricap));
 
Console.ReadLine();
}
        }
    }

