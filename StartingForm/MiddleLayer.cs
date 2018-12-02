using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.ComponentModel;

namespace StartingForm
{
    public class MiddleLayer
    {
        //public bool checker5050;
        public bool wrongChecker;
        public int it;
        //string s;
        //public RichTextBox qNo, q;
        //public Button a1, a2, a3, a4;
        //public Button b;
        public MiddleLayer()
        {
            //this.checker5050 = false;
            this.wrongChecker = false;
            this.it = 0;
        }
        /*public MiddleLayer(int i,RichTextBox qNN,RichTextBox qq,Button a11,Button a22,Button a33,Button a44)
        {
            this.it = i;
            this.qNo = qNN;
            this.q = qq;
            this.a1 = a11;
            this.a2 = a22;
            this.a3 = a33;
            this.a4 = a44;
            this.s = "\0";
        }
        public MiddleLayer(RichTextBox qNN, RichTextBox qq, Button a11, Button a22, Button a33, Button a44)
        {
            this.qNo = qNN;
            this.q = qq;
            this.a1 = a11;
            this.a2 = a22;
            this.a3 = a33;
            this.a4 = a44;
            this.s = "\0";
        }*/
        public void MiddleMethod(int i, RichTextBox qNN, RichTextBox qq, Button a11, Button a22, Button a33, Button a44, Timer t, ProgressBar p, PictureBox pL, RadioButton r1, RadioButton r2, RadioButton r3, RadioButton r4, 
                                RadioButton r5, RadioButton r6, RadioButton r7, RadioButton r8, RadioButton r9, RadioButton r10)
        {
            this.it = i;
            DataAccess d2 = new DataAccess();
            d2.QNoInsert(qNN, this.it);
            d2.QuestionInsert(qq, this.it);
            d2.A1Insert(a11, this.it);
            d2.A2Insert(a22, this.it);
            d2.A3Insert(a33, this.it);
            d2.A4Insert(a44, this.it);
            t.Enabled = true;
            t.Start();
            r1.Visible = false;
            r2.Visible = false;
            r3.Visible = false;
            r4.Visible = false;
            r5.Visible = false;
            r6.Visible = false;
            r7.Visible = false;
            r8.Visible = false; 
            r9.Visible = false;
            r10.Visible = false;
            //pL.Visible = false;

        }


        public void AnswerCheck(Button f, RichTextBox qNN, RichTextBox qq, Button a11, Button a22, Button a33, Button a44, Timer t, ProgressBar P, PictureBox pL, RadioButton r1, RadioButton r2,RadioButton r3, RadioButton r4, 
                                RadioButton r5, RadioButton r6, RadioButton r7, RadioButton r8, RadioButton r9, RadioButton r10)
        {
            //MessageBox.Show(this.s);
            DataAccess d2 = new DataAccess();
            string ss = d2.RightAnswerCheck(this.it);

            
            if (f.Text == ss && this.it<10)
            {
                t.Stop();
                switch((this.it)-1)
                {
                    case 0:
                        r1.Visible = true;
                        break;
                    case 1:
                        r1.Visible = false;
                        r2.Visible = true;
                        break;
                    case 2:
                        r1.Visible = false;
                        r2.Visible = false;
                        r3.Visible = true;
                        break;
                    case 3:
                        r1.Visible = false;
                        r2.Visible = false;
                        r3.Visible = false;
                        r4.Visible = true;
                        break;
                    case 4:
                        r1.Visible = false;
                        r2.Visible = false;
                        r3.Visible = false;
                        r4.Visible = false;
                        r5.Visible = true;
                        break;
                    case 5:
                        r1.Visible = false;
                        r2.Visible = false;
                        r3.Visible = false;
                        r4.Visible = false;
                        r5.Visible = false;
                        r6.Visible = true;
                        break;
                    case 6:
                        r1.Visible = false;
                        r2.Visible = false;
                        r3.Visible = false;
                        r4.Visible = false;
                        r5.Visible = false;
                        r6.Visible = false;
                        r7.Visible = true;
                        break;
                    case 7:
                        r1.Visible = false;
                        r2.Visible = false;
                        r3.Visible = false;
                        r4.Visible = false;
                        r5.Visible = false;
                        r6.Visible = false;
                        r7.Visible = false;
                        r8.Visible = true;
                        break;
                    case 8:
                        r1.Visible = false;
                        r2.Visible = false;
                        r3.Visible = false;
                        r4.Visible = false;
                        r5.Visible = false;
                        r6.Visible = false;
                        r7.Visible = false;
                        r8.Visible = false;
                        r9.Visible = true;
                        break;
                    case 9:
                        r1.Visible = false;
                        r2.Visible = false;
                        r3.Visible = false;
                        r4.Visible = false;
                        r5.Visible = false;
                        r6.Visible = false;
                        r7.Visible = false;
                        r8.Visible = false;
                        r9.Visible = false;
                        r10.Visible = true;
                         
                        break;


                }

                MessageBox.Show("Right Answer");
                this.it++;
                d2.QNoInsert(qNN, this.it);
                d2.QuestionInsert(qq, this.it);
                d2.A1Insert(a11, this.it);
                d2.A2Insert(a22, this.it);
                d2.A3Insert(a33, this.it);
                d2.A4Insert(a44, this.it);
                P.Value = 0;
                t.Enabled = true;
                t.Start();
            }
            else if (f.Text == ss && this.it == 10)
            {
                this.wrongChecker = true;
                MessageBox.Show("Right Answer");
                MessageBox.Show("Congratulations!!! YOU have became a Millionaire!!!!");
                t.Stop();
                
 
            }
            else
            {
                t.Stop();
                if (this.it < 4)
                {
                    this.wrongChecker = true;
                    MessageBox.Show("Wrong Answer " + "\n" + "Right Answer is: " + ss + "\n" + "Bad Luck You Have Won: 0 BDT");
                   
 
                }
                else if (this.it >= 4 && this.it < 7)
                {
                    this.wrongChecker = true;
                    MessageBox.Show("Wrong Answer " + "\n" + "Right Answer is: " + ss + "\n" + "Congratulations!! You Have Won: 10,000 BDT");
                    
                }
                else if (this.it >= 7 && this.it <= 10)
                {
                    this.wrongChecker = true;
                    MessageBox.Show("Wrong Answer " + "\n" + "Right Answer is: " + ss + "\n" + "Congratulations!! You Have Won: 100,000 BDT");
                    
                }
                


            }
        }
        
      
    }
}
