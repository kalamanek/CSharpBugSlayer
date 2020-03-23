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

            new List< dynamic >()
            {
                new {
                    first = new Question("2 + 2 is", new List<string>{ "4" , "5"}) ,
                    second = "4" },
                new {
                    first = new Question("2 * 2 is", new List<string>{ "4" , "5" , "6"}) ,
                    second = "4" },
                new {
                    first = new Question("2 + 3 is", new List<string>{ "4" , "5" , "6" , "7" }) ,
                    second = "5" },
                new {
                    first = new Question("2 *3 is", new List<string>{ "4" , "5" , "6" , "7" , "8" }) ,
                    second = "6" }

             }.ForEach(
                 n  => {
                     Form2 form = new Form2(n.first);
                     form.questionAnswered +=  
                        (result) => points += result.Equals(n.second) ? 1 : 0 ;

                     form.StartPosition = FormStartPosition.Manual;
                     form.Location = this.Location;
                     form.ShowDialog();
             });

            this.Show();
            this.label.Text = "points : " + points;


        }

    }
}
