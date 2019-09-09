using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine(ReturnAnExampleString("hello world"));
        }

        //Voorbeeld functie. Probeer deze programmeerstyle aan te houden:
        public string ReturnAnExampleString(string returnString)
        {
            return returnString;
        }
    }
}
