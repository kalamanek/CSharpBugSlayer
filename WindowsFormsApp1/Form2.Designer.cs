using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Question q)
        {
            this.SuspendLayout();

            //question

            Label question = new Label();
            question.Left = 10;
            question.Top = 20;
            question.Text = q.question;
            this.Controls.Add(question);

            //buttons
            int top = 50;
            int left = 10;

            q.answer.ForEach(n =>
            {
                Button newButton = new Button();
                newButton.Left = left;
                newButton.Top = top;
                newButton.Text = n;
                newButton.Click += new System.EventHandler(this.button_Click);
                this.Controls.Add(newButton);
                left += newButton.Width + 2;
            });
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Name = "pytanka";
            this.ResumeLayout(false);

        }

        #endregion

    }
}

