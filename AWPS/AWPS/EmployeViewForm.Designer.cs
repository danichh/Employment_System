
namespace AWPS
{
    partial class EmployeViewForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.employeesViewListBox = new System.Windows.Forms.ListBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.moreDetailBtn = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeesViewListBox
            // 
            this.employeesViewListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesViewListBox.FormattingEnabled = true;
            this.employeesViewListBox.ItemHeight = 19;
            this.employeesViewListBox.Location = new System.Drawing.Point(80, 128);
            this.employeesViewListBox.Name = "employeesViewListBox";
            this.employeesViewListBox.ScrollAlwaysVisible = true;
            this.employeesViewListBox.Size = new System.Drawing.Size(301, 270);
            this.employeesViewListBox.TabIndex = 4;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(423, 116);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(121, 25);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Remove Employee";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // moreDetailBtn
            // 
            this.moreDetailBtn.BackColor = System.Drawing.Color.DarkGray;
            this.moreDetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreDetailBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreDetailBtn.ForeColor = System.Drawing.Color.White;
            this.moreDetailBtn.Location = new System.Drawing.Point(423, 164);
            this.moreDetailBtn.Name = "moreDetailBtn";
            this.moreDetailBtn.Size = new System.Drawing.Size(121, 23);
            this.moreDetailBtn.TabIndex = 7;
            this.moreDetailBtn.Text = "More Detail";
            this.moreDetailBtn.UseVisualStyleBackColor = false;
            this.moreDetailBtn.Click += new System.EventHandler(this.moreDetailBtn_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.BackColor = System.Drawing.Color.White;
            this.firstNameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(263, 92);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(73, 33);
            this.firstNameLabel.TabIndex = 10;
            this.firstNameLabel.Text = "Name ";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmployeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 417);
            this.Controls.Add(this.employeesViewListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.moreDetailBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeViewForm";
            this.Text = "EmployeeView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox employeesViewListBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button moreDetailBtn;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label label2;
    }
}