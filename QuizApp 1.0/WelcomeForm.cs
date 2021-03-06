﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp_1._0
{
    public partial class WelcomeForm : Form
    {
        public static int NumberOFQ = 0;
        int Number=0;
        private string filename = "Q.xml";
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btnQuiz_Click(object sender, EventArgs e) {

            try
            {
                Number = XmlMethods.getNumberOfElement(filename);
                NumberOFQ = Number;
            }
            catch(FormatException)
            {
                Number = 18;
                NumberOFQ = Number;
            }


            Console.WriteLine(Number);
            
            QuizForm quizForm = new QuizForm();
            quizForm.Show();
            
          
        }

        private void btnEnterData_Click(object sender, EventArgs e)
        {
            EntryForm entryForm = new EntryForm();
            entryForm.Show();
        }
    }
}
