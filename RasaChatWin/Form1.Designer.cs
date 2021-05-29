
namespace RasaChatWin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userbox = new System.Windows.Forms.TextBox();
            this.userbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statuspanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 66);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(385, 295);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // userbox
            // 
            this.userbox.Location = new System.Drawing.Point(25, 370);
            this.userbox.MaxLength = 500;
            this.userbox.Multiline = true;
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(300, 20);
            this.userbox.TabIndex = 1;
            this.userbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userbox.UseWaitCursor = true;
            this.userbox.TextChanged += new System.EventHandler(this.userbox_TextChanged);
            this.userbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userbox_KeyDown);
            // 
            // userbutton
            // 
            this.userbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userbutton.ForeColor = System.Drawing.Color.Snow;
            this.userbutton.Location = new System.Drawing.Point(342, 367);
            this.userbutton.Name = "userbutton";
            this.userbutton.Size = new System.Drawing.Size(48, 24);
            this.userbutton.TabIndex = 2;
            this.userbutton.Text = "Enter";
            this.userbutton.UseVisualStyleBackColor = true;
            this.userbutton.Click += new System.EventHandler(this.userbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 57);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "RASA CHAT APPLICATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.exitbutton.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.Red;
            this.exitbutton.Location = new System.Drawing.Point(365, 14);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(22, 23);
            this.exitbutton.TabIndex = 5;
            this.exitbutton.Text = "X";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // statuspanel
            // 
            this.statuspanel.Location = new System.Drawing.Point(157, 42);
            this.statuspanel.Name = "statuspanel";
            this.statuspanel.Size = new System.Drawing.Size(65, 18);
            this.statuspanel.TabIndex = 7;
            this.statuspanel.Paint += new System.Windows.Forms.PaintEventHandler(this.statuspanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(399, 403);
            this.Controls.Add(this.statuspanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userbutton);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox userbox;
        private System.Windows.Forms.Button userbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel statuspanel;
    }
}

