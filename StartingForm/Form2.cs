using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace StartingForm
{
    public partial class Form2 : Form
    {
        WindowsMediaPlayer music2 = new WindowsMediaPlayer();
        public Form2()
        {
            InitializeComponent();
            music2.URL = "2RoyaltyFreeMusic.mp3";
        }

        MiddleLayer mL = new MiddleLayer();

        private void Form2_Load(object sender, EventArgs e)
        {

            //Form1 f1 = new Form1();
            //f1.Close();
            //MiddleLayer mLL = new MiddleLayer(1, qNo, question, a1, a2, a3, a4);

            mL.MiddleMethod(1, qNo, question, a1, a2, a3, a4, timer1, progressBar1, pictureBox1,radioButton1, radioButton2,
                            radioButton3,radioButton4,radioButton5,radioButton6,radioButton7,radioButton8,radioButton9,radioButton10);
            music2.controls.play();

                //mL.MiddleMethod(qNo, question, a1, a2, a3, a4, 1);
            
                //DataAccess d1 = new DataAccess();
                //int i = 1;
               // d1.QNoInsert(qNo, i);
                //d1.QuestionInsert(question, i);
                //d1.A1Insert(a1, i);
               // d1.A2Insert(a2, i);
               // d1.A3Insert(a3, i);
               // d1.A4Insert(a4, i);

        }

        //**********************TIMER************************

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 30)
            {
                progressBar1.Value += 1;
            }
            else
            {
                Form1 f1 = new Form1();
                timer1.Stop();
                MessageBox.Show("TIME-OUT");
                this.Close();
                f1.Show();

            }

        }
        
        
        /*
        public void LevelUp(PictureBox p)
        {
            mL.AnswerCheck(b, qNo, question, a1, a2, a3, a4, timer1, progressBar1, pictureBox1);
        }
        */

        //**********************BUTTONCLICK************************

        public void MyClick(Button b)
        {
            mL.AnswerCheck(b, qNo, question, a1, a2, a3, a4, timer1, progressBar1, pictureBox1,radioButton1,radioButton2,
                           radioButton3,radioButton4,radioButton5,radioButton6,radioButton7,radioButton8,radioButton9,radioButton10);
            if (mL.wrongChecker == true )
            {
                //Form2 f2 = new Form2();
                Form1 f1 = new Form1();
                this.Close();
                f1.Show();
                
            }
            
            
        }

        private void a1_Click(object sender, EventArgs e)
        {
             MyClick(a1);
            
        }

        private void a2_Click(object sender, EventArgs e)
        {
            MyClick(a2);
            
        }

        private void a3_Click(object sender, EventArgs e)
        {

            MyClick(a3);
            
        }

        private void a4_Click(object sender, EventArgs e)
        {

            MyClick(a4);
            
        }
        private void lifeline5050_Click(object sender, EventArgs e)
        {

        }

        //**********************PRIZEBUTTON************************

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }


        //**********************MOUSEHOVER************************

        /*private void a1_MouseHover(object sender, EventArgs e)
        {
            this.a1.BackColor = Color.Red;
            
        }

        private void a2_MouseHover(object sender, EventArgs e)
        {
            this.a2.BackColor = Color.Red;
        }

        private void a3_MouseHover(object sender, EventArgs e)
        {
            this.a3.BackColor = Color.Red;
                
        }

        private void a4_MouseHover(object sender, EventArgs e)
        {
            this.a4.BackColor = Color.Red;
        }

        
        private void a1_MouseLeave(object sender, EventArgs e)
        {
            //this.a1.BackColor = Color.Indigo;
        }
        

        private void a2_MouseLeave(object sender, EventArgs e)
        {

        }

       

        

        

        /*
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int x = 0, y = 190;
            SolidBrush blueBrush = new SolidBrush(Color.LightSkyBlue);
            Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen myPen = new Pen(Color.Red, 2);
            Rectangle myRectangle = new Rectangle(x, y, 190, 20);
            e.Graphics.DrawRectangle(myPen, myRectangle);
            e.Graphics.FillRectangle(blueBrush, x, y, 190, 20);
        }
        */

        

        
        /*public void Game()
        {
             MiddleLayer mL = new MiddleLayer();
             mL.MiddleMethod(this, i);
                
                 
        }*/

        
       
    }
}
