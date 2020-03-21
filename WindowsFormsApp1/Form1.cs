using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            int points = 0;
            
            new List<Question>(){
                 new Question("2 + 2", new string[]{ "4" , "5"}, 0),
                 new Question("2 + 2", new string[]{ "4" , "5"}, 0),
                 new Question("2 + 2", new string[]{ "4" , "5"}, 0),
                 new Question("2 + 2", new string[]{ "4" , "5"}, 0)
             }.ForEach(n => points += n.getPoints());

            Console.WriteLine(points);
            
        }

    }
}
