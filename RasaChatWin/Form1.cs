using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RasaChatWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userbox_TextChanged(object sender, EventArgs e)
        {

        }
 
        private void dynamicLabels(string labeltype, string responsetype, string message)
        {
            Console.WriteLine(labeltype);
            Console.WriteLine(responsetype);
            Console.WriteLine(message);
            int x = (flowLayoutPanel1.Size.Width) ;
            Console.WriteLine("size  {0}", x);
            if (labeltype == "link")
            {
                LinkLabel Label1 = new LinkLabel();
                Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                Label1.BackColor = System.Drawing.Color.White;
                Label1.Text = message;
                Label1.AutoSize = true;
                Label1.MinimumSize = new System.Drawing.Size(x-25, 0);
                Label1.Size = new System.Drawing.Size((x-25), 10);
                if (responsetype == "user")
                {
                    Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
                }
                else
                {
                    Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                }
                
                Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                flowLayoutPanel1.Controls.Add(Label1);
                

            }
            if (labeltype == "regular")
            {
                Label Label2 = new Label();
                Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
                Label2.BackColor = System.Drawing.Color.White;
                Label2.Text = message;
                Label2.ForeColor = System.Drawing.Color.Navy;
                Label2.AutoSize = true;
                Label2.MinimumSize = new System.Drawing.Size(x - 25, 0);
                Label2.Size = new System.Drawing.Size((x - 25), 10);
                if (responsetype == "user")
                {
                    Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
                }
                else
                {
                    Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                }

                Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                flowLayoutPanel1.Controls.Add(Label2);
            }
        }

        private void userbutton_Click(object sender, EventArgs e)
        {
          
            var query = userbox.Text;
            Console.WriteLine(query);
            dynamicLabels("link", "user", query);
            dynamicLabels("link", "server", query);
            dynamicLabels("regular", "user", query);
            dynamicLabels("regular", "server", query);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
