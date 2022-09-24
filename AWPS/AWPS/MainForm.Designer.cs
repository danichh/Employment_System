
namespace AWPS
{
    partial class MainForm
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
            this.panelside = new System.Windows.Forms.Panel();
            this.viewEmpbtn = new System.Windows.Forms.Button();
            this.addEmpbtn = new System.Windows.Forms.Button();
            this.panelheader = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelside.SuspendLayout();
            this.panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.DarkGray;
            this.panelside.Controls.Add(this.pictureBox1);
            this.panelside.Controls.Add(this.viewEmpbtn);
            this.panelside.Controls.Add(this.addEmpbtn);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 35);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(186, 415);
            this.panelside.TabIndex = 0;
            // 
            // viewEmpbtn
            // 
            this.viewEmpbtn.BackColor = System.Drawing.Color.DarkGray;
            this.viewEmpbtn.FlatAppearance.BorderSize = 0;
            this.viewEmpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewEmpbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEmpbtn.ForeColor = System.Drawing.Color.White;
            this.viewEmpbtn.Image = global::AWPS.Properties.Resources.report_card_24px;
            this.viewEmpbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewEmpbtn.Location = new System.Drawing.Point(3, 153);
            this.viewEmpbtn.Name = "viewEmpbtn";
            this.viewEmpbtn.Size = new System.Drawing.Size(177, 23);
            this.viewEmpbtn.TabIndex = 1;
            this.viewEmpbtn.Text = "View Employes";
            this.viewEmpbtn.UseVisualStyleBackColor = false;
            this.viewEmpbtn.Click += new System.EventHandler(this.viewEmpbtn_Click);
            // 
            // addEmpbtn
            // 
            this.addEmpbtn.BackColor = System.Drawing.Color.DarkGray;
            this.addEmpbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addEmpbtn.FlatAppearance.BorderSize = 0;
            this.addEmpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmpbtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpbtn.ForeColor = System.Drawing.Color.White;
            this.addEmpbtn.Image = global::AWPS.Properties.Resources.user_24px;
            this.addEmpbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmpbtn.Location = new System.Drawing.Point(3, 124);
            this.addEmpbtn.Name = "addEmpbtn";
            this.addEmpbtn.Size = new System.Drawing.Size(177, 23);
            this.addEmpbtn.TabIndex = 0;
            this.addEmpbtn.Text = "Add Employe";
            this.addEmpbtn.UseVisualStyleBackColor = false;
            this.addEmpbtn.Click += new System.EventHandler(this.addEmpbtn_Click);
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.DarkGray;
            this.panelheader.Controls.Add(this.exitBtn);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(800, 35);
            this.panelheader.TabIndex = 1;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.DarkGray;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(739, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.exitBtn.Size = new System.Drawing.Size(49, 29);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(186, 35);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(614, 415);
            this.mainpanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AWPS.Properties.Resources.staff_96px;
            this.pictureBox1.Location = new System.Drawing.Point(33, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelside.ResumeLayout(false);
            this.panelheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Button viewEmpbtn;
        private System.Windows.Forms.Button addEmpbtn;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button exitBtn;
        public System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

