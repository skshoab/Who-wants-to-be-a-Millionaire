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
    public class DataAccess
    {
        MillionaireLinqDataContext cntx = new MillionaireLinqDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Fahad\Desktop\New folder\ASDF\BeAMillionaire\StartingForm\MillionaireDB.mdf;Integrated Security=True;Connect Timeout=30");
        
        
        public DataAccess()
        {
            
        }
        Form2 f2 = new Form2();
        public void  QuestionInsert(RichTextBox r1, int r)
        {
            var str = from a in cntx.Questions
                      where a.QNo == r
                      select a;
            Question q = str.First();
            r1.Text = q.QLine;

        }
        public void A1Insert(Button r1, int r)
        {
            var str = from a in cntx.A1s
                      where a.A1No == r
                      select a;
            A1 q = str.First();
            r1.Text = q.A;
        }
        public void A2Insert(Button r1, int r)
        {
            var str = from a in cntx.A2s
                      where a.A2No == r
                      select a;
            A2 q = str.First();
            r1.Text = q.A;
        }
        public void A3Insert(Button r1, int r)
        {
            var str = from a in cntx.A3s
                      where a.A3No == r
                      select a;
            A3 q = str.First();
            r1.Text = q.A;
        }
        public void A4Insert(Button r1, int r)
        {
            var str = from a in cntx.A4s
                      where a.A4No == r
                      select a;
            A4 q = str.First();
            r1.Text = q.A;
        }
        public void QNoInsert(RichTextBox r1, int r)
        {

              var str = from a in cntx.Questions
                        where a.QNo == r
                        select a;
              Question q = str.First();
              r1.Text = Convert.ToString(q.QNo);
        }
        public string RightAnswerCheck(int r)
        {
            string str1 = (from a1 in cntx.RAs
                           where a1.ANo == r
                           select a1.RA1).First().ToString();
            return str1;
        }
        

    }
}
