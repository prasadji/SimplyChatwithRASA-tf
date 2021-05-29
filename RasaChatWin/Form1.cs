using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RasaChatWin.DataHandler;

namespace RasaChatWin
{

    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     
            int nTopRect,      
            int nRightRect,    
            int nBottomRect,  
            int nWidthEllipse, 
            int nHeightEllipse 
        );
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //userbutton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, userbutton.Width, userbutton.Height, 20, 20));
            connectionTest();
            
        }

        private void userbox_TextChanged(object sender, EventArgs e)
        {

        }
 
        private void dynamicLabels(string labeltype, string responsetype, string message)
        {

            int x = (flowLayoutPanel1.Size.Width) ;
            Console.WriteLine("size  {0}", x);
            if (labeltype == "link")
            {
                LinkLabel Label1 = new LinkLabel();
                Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                
                Label1.Text = message;
                Label1.MaximumSize = new System.Drawing.Size(x - 35, 500);
                Label1.MinimumSize = new System.Drawing.Size(x - 35, 30);
                Label1.Size = new System.Drawing.Size((x - 35), 500);
                Label1.AutoSize = true;
                if (responsetype == "user")
                {
                    Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    Label1.BackColor = Color.Snow;
                    Label1.LinkColor = System.Drawing.SystemColors.Highlight;
                }
                else
                {
                    Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    Label1.BackColor = System.Drawing.SystemColors.Highlight;
                    Label1.LinkColor = Color.Snow;
                }

                Label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Label1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Label1.Width, Label1.Height, 20, 20));
                flowLayoutPanel1.Controls.Add(Label1);
                

            }
            if (labeltype == "regular")
            {
                Label Label2 = new Label();
                Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
                
                Label2.Text = message;
                Label2.MaximumSize = new System.Drawing.Size(x - 35, 500);
                Label2.MinimumSize = new System.Drawing.Size(x - 35, 30);
                Label2.Size = new System.Drawing.Size((x - 35), 500);
                Label2.AutoSize = true;
 
                if (responsetype == "user")
                {
                    Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    Label2.BackColor = System.Drawing.Color.Snow;
                    Label2.ForeColor = System.Drawing.SystemColors.Highlight;
                }
                else
                {
                    Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    Label2.BackColor = System.Drawing.SystemColors.Highlight;
                    Label2.ForeColor = System.Drawing.Color.Snow;
                }

                Label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Label2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Label2.Width, Label2.Height, 20, 20));

                flowLayoutPanel1.Controls.Add(Label2);
            }
        }

        private async void  eventmanager(string user_input)
        {
            var responses = await server.PostResponse(user_input);
            if (responses == "[]")
            {
                string message = "Sorry! No response from the server";
                dynamicLabels("regular", "server", message);
            }

            else
            {
                List<keystrings> objList = response.ResponseProcessor(responses);
                foreach (keystrings obj in objList)
                {

                    if (obj.text != null)
                    {
                        string text = obj.text;
                        dynamicLabels("regular", "server", text);
                    }
                    if (obj.image != null)
                    {
                        string image = obj.image;
                        dynamicLabels("link", "server", image);
                    }
                }
            }
            
        }
        
        private async void connectionTest()
        {
            try
            {
                string testmsg = "Hi";
                var testresponse = await server.PostResponse(testmsg);
                if (testresponse != null)
                {
                    Console.WriteLine(testresponse);
                    Label testlabel = new Label();
                    testlabel.AutoSize = true;
                    Console.WriteLine(testlabel.Size);
                    testlabel.Size = new System.Drawing.Size(4, 1);
                    testlabel.TabIndex = 6;
                    testlabel.Text = "Connected";
                    testlabel.ForeColor = System.Drawing.Color.Snow;
                    int x = (statuspanel.Size.Width - statuspanel.Size.Width) / 2;
                    testlabel.Location = new Point(x, testlabel.Location.Y);

                    statuspanel.Controls.Add(testlabel);
                    Console.WriteLine(testresponse);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Make sure connected to http://127.0.0.1:5005");
                Application.Exit();
            }

        }
        private  void  userbutton_Click(object sender, EventArgs e)
        {
          
            string user_input = userbox.Text;
            if (string.IsNullOrEmpty(user_input))
            {
                MessageBox.Show("please  enter text");
            }
            else
            {
                Console.WriteLine(user_input);
                dynamicLabels("regular", "user", user_input);
                userbox.Text = string.Empty;
                eventmanager((user_input));
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RasaLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                userbutton.PerformClick();
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void statuspanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
