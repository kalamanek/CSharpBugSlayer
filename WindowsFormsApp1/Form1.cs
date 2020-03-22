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
            this.Hide();

            new List< Tuple< Question, string> >()
            {
                new Tuple<Question, string>( 
                    new Question("2 + 2 is", new List<string>{ "4" , "5"}) ,
                     "4" ),

                new Tuple<Question, string>( 
                    new Question("2 * 2 is", new List<string>{ "4" , "5" , "6"}) ,
                     "4" ),

                new Tuple<Question, string>( 
                    new Question("2 + 3 is", new List<string>{ "4" , "5", "6" , "7"}) ,
                     "5" ),

                new Tuple<Question, string>( 
                    new Question("2 * 2 is", new List<string>{ "4" , "5", "6" , "7" ,"8"}) ,
                     "6" )

             }.ForEach( tuple => {
                 Form2 q = new Form2(tuple.Item1);
                 q.questionAnswered +=  
                    (result) => points += result.Equals(tuple.Item2) ? 1 : 0 ;

                 q.StartPosition = FormStartPosition.Manual;
                 q.Location = this.Location;
                 q.ShowDialog();
             });

            this.Show();
            this.label.Text = "points : " + points;


        }

    }
}
