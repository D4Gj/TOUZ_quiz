using System;
using System.Windows.Forms;

namespace QuizApp_1._0
{
    public partial class QuizForm : Form
    {
       
        public string file = "Q.xml";     //the filename \ file path
        private string question = "Qs";  // the question child tag
        private string Op_1 = "Op1";    // the question child tag
        private string Op_2 = "Op2";   // the question child tag
        private string Op_3 = "Op3";  // the question child tag
        private string Op_4 = "Op4"; // the question child tag
        private string OpVal_1 = "Ans1";
        private string OpVal_2 = "Ans2";
        private string OpVal_3 = "Ans3";
        private string OpVal_4 = "Ans4";
        private int val1;
        private int val2;
        private int val3;
        private int val4;
        private int SummaryAll=0;
        private int SummClient = 0;
        private bool isAnsShown = false; 
        public int givnAns; //the given answ by the user
        private int FinalVerdict = 0; //the current\final score
        public string[] ID;/*{ "1", "2", "3", "4","5","6","7","8","9","10","11","12","13" }; //question numbers use as ID tag*/
        int Ite = 1; //iterator for ID array
        public bool Op1, Op2, Op3, Op4; //the ans represented as true or false
        public static int p = WelcomeForm.NumberOFQ;//number of queation you want from welcome screen
        public string[] JS=new string[p];
        

        


        public QuizForm()
        {
            InitializeComponent();
            ID = generateQNoArray(JS, p);
            Move thisForm = new Move(this,panel1);
            thisForm.MakeFromDraggableViaControlOr();
          


        }
        private void QuizForm_Load(object sender, EventArgs e)
        {
            XmlMethods.LoadXDocumnet(file); //Load the document (file creating remove when catch exception).
            setValuesToControl(0); //set the first question fro file
            lblQRemaining.Text = "Question NO. : " + 1 + "/" + ID.Length; //set the first question number
            
        }



        



        /*----------------------Buttons Action-----------------------*/
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Ite > 1)
            {
                Ite--;

                setValuesToControl(Ite-1);
                lblQRemaining.Text = "Question NO. : " +
                   (Ite) + "/" + ID.Length;
                Console.WriteLine("Now I id {0}", Ite);
            }
            else
            {
                MessageBox.Show("Last One !");
            }
           

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Ite <( ID.Length) )

            {
                if (radioOption1.Checked)// check if ans is true
                {
                    SummClient += val1;
                    QuestCount.Text = Convert.ToString(FinalVerdict);
                    isAnsShown = true;

                }
                if (radioOption2.Checked)// check if ans is true
                {
                    SummClient += val2;
                    QuestCount.Text = Convert.ToString(FinalVerdict);
                    isAnsShown = true;
                }
                if (radioOption3.Checked)// check if ans is true
                {
                    SummClient += val3;
                    QuestCount.Text = Convert.ToString(FinalVerdict);
                    isAnsShown = true;
                }
                if (radioOption4.Checked)// check if ans is true
                {
                    SummClient += val4;
                    QuestCount.Text = Convert.ToString(FinalVerdict);
                    isAnsShown = true;
                }
                if (isAnsShown == true)
                {
                    setValuesToControl(Ite); //set the values and ans to the control
                                               lblQRemaining.Text = "Question NO. : " + 
                                                  (Ite+1) + "/" + ID.Length; //chnge the current question number of label
                    SummaryAll += val1 + val2 + val3 + val4;

                    Ite++;
                    CleanAll(); //clear all option box

                }
                else { MessageBox.Show("Выберите ответ!"); }
                
            }
            else
            {
                MessageBox.Show("You Have Completed!");
            }


        }

        private void btnCleanAll_Click(object sender, EventArgs e) //clear the ans and selection
        {
            CleanAll();
            
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radioOption1.Checked)// check if ans is true
            {
                SummClient += val1;
                QuestCount.Text = Convert.ToString(FinalVerdict);
                isAnsShown = true;

            }
            if (radioOption2.Checked)// check if ans is true
            {
                SummClient += val2;
                QuestCount.Text = Convert.ToString(FinalVerdict);
                isAnsShown = true;
            }
            if (radioOption3.Checked)// check if ans is true
            {
                SummClient += val3;
                QuestCount.Text = Convert.ToString(FinalVerdict);
                isAnsShown = true;
            }
            if (radioOption4.Checked)// check if ans is true
            {
                SummClient += val4;
                QuestCount.Text = Convert.ToString(FinalVerdict);
                isAnsShown = true;
            }
            if (SummClient>SummaryAll*0.65)
            MessageBox.Show(string.Format("Вам следует взять кредит!"));
            else
                MessageBox.Show(string.Format("Вам не следует брать кредит!"));
        }
        /*----------------------End Buttons Action-----------------------*/



        /*-------------------------Methods-------------------------*/

        private void setValuesToControl(int IDs)
        {
            isAnsShown = false;
            lblQuestion.Text = ID[IDs] + ".\n" + XmlMethods.getQuention(file, question, ID[IDs]);
            radioOption1.Text = XmlMethods.getQuention(file, Op_1, ID[IDs]);
            radioOption2.Text = XmlMethods.getQuention(file, Op_2, ID[IDs]);
            radioOption3.Text = XmlMethods.getQuention(file, Op_3, ID[IDs]);
            radioOption4.Text = XmlMethods.getQuention(file, Op_4, ID[IDs]);
            val1 = Convert.ToInt32(XmlMethods.getQuention(file, OpVal_1, ID[IDs]));
            val2 = Convert.ToInt32(XmlMethods.getQuention(file, OpVal_2, ID[IDs]));
            val3 = Convert.ToInt32(XmlMethods.getQuention(file, OpVal_3, ID[IDs]));
            val4 = Convert.ToInt32(XmlMethods.getQuention(file, OpVal_4, ID[IDs]));
        } //set all ans and question to their control

        private void btnExit_Click(object sender, EventArgs e)
        {

            // this.Close();
            Application.Exit();
        }

        private void CleanAll()//clear the ans and selection
        {
            radioOption1.Checked = false;
            radioOption2.Checked = false;
            radioOption3.Checked = false;
            radioOption4.Checked = false;
            givnAns = 0;

        }
        private   string[] generateQNoArray(string[] Blank, int NoOFQ)
        {           
            for(int i=0;i<NoOFQ;i++)
            {
                Blank[i] = (i+1).ToString();
               // Console.WriteLine(Blank[i]);

            }
            return Blank;

        }

        /*-------------------------Methods Ends-------------------------*/
    }
}
