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
    public partial class Form2 : Form
    {
       // public Action<int> questionAnswered;
        public Action<string> questionAnswered;

        public Form2(Question question)
        {
            InitializeComponent(question);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            /*
                    if(button.Text.Equals(question.answer[question.correctAnswear]))
                        questionAnswered(1);
                    else
                        questionAnswered(0);
            */
            questionAnswered(button.Text);
            this.Close();
        }

    }
}
