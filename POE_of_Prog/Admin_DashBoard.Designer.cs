﻿namespace POE_of_Prog
{
    partial class Admin_DashBoard
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
            label1 = new Label();
            VerifyClaim = new Button();
            reject = new Button();
            button3 = new Button();
            panel2 = new Panel();
            button4 = new Button();
            Status = new Button();
            panel3 = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ADmin = new TextBox();
            Claim = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Submit = new Button();
            label5 = new Label();
            label6 = new Label();
            Approval_ID = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 286);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 0;
            label1.Text = "Claim Status";
            // 
            // VerifyClaim
            // 
            VerifyClaim.BackColor = SystemColors.ButtonShadow;
            VerifyClaim.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VerifyClaim.ForeColor = SystemColors.ButtonHighlight;
            VerifyClaim.Location = new Point(-5, 78);
            VerifyClaim.Name = "VerifyClaim";
            VerifyClaim.Size = new Size(74, 58);
            VerifyClaim.TabIndex = 1;
            VerifyClaim.Text = "Verify Claim";
            VerifyClaim.UseVisualStyleBackColor = false;
            VerifyClaim.Click += VerifyClaim_Click;
            // 
            // reject
            // 
            reject.BackColor = SystemColors.ButtonShadow;
            reject.ForeColor = SystemColors.ButtonHighlight;
            reject.Location = new Point(212, 199);
            reject.Name = "reject";
            reject.Size = new Size(85, 28);
            reject.TabIndex = 2;
            reject.Text = "Reject";
            reject.UseVisualStyleBackColor = false;
            reject.Click += reject_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonShadow;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(101, 199);
            button3.Name = "button3";
            button3.Size = new Size(82, 28);
            button3.TabIndex = 3;
            button3.Text = "Approval";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(VerifyClaim);
            panel2.Controls.Add(Status);
            panel2.Location = new Point(851, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(72, 456);
            panel2.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonShadow;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(-3, 330);
            button4.Name = "button4";
            button4.Size = new Size(72, 45);
            button4.TabIndex = 0;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Status
            // 
            Status.BackColor = SystemColors.ButtonShadow;
            Status.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Status.ForeColor = SystemColors.ButtonHighlight;
            Status.Location = new Point(-3, 214);
            Status.Name = "Status";
            Status.Size = new Size(72, 52);
            Status.TabIndex = 14;
            Status.Text = "View Status";
            Status.UseVisualStyleBackColor = false;
            Status.Click += Status_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Menu;
            panel3.Controls.Add(label2);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(-1, -4);
            panel3.Name = "panel3";
            panel3.Size = new Size(940, 42);
            panel3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 11);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 0;
            label2.Text = "ADM Dashboard";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 315);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(828, 164);
            dataGridView1.TabIndex = 7;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(321, 74);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(515, 197);
            dataGridView2.TabIndex = 8;
            // 
            // ADmin
            // 
            ADmin.Location = new Point(101, 68);
            ADmin.Name = "ADmin";
            ADmin.Size = new Size(100, 23);
            ADmin.TabIndex = 9;
            // 
            // Claim
            // 
            Claim.Location = new Point(101, 106);
            Claim.Name = "Claim";
            Claim.Size = new Size(100, 23);
            Claim.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 11;
            label3.Text = "AdminID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 110);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 12;
            label4.Text = "ClaimID";
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.ButtonShadow;
            Submit.Location = new Point(12, 195);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 32);
            Submit.TabIndex = 13;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(671, 41);
            label5.Name = "label5";
            label5.Size = new Size(162, 30);
            label5.TabIndex = 15;
            label5.Text = "Tracking Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 149);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 16;
            label6.Text = "ApprovalID";
            // 
            // Approval_ID
            // 
            Approval_ID.Location = new Point(101, 141);
            Approval_ID.Name = "Approval_ID";
            Approval_ID.Size = new Size(100, 23);
            Approval_ID.TabIndex = 17;
            // 
            // Admin_DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(935, 482);
            Controls.Add(Approval_ID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Submit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Claim);
            Controls.Add(ADmin);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(reject);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLight;
            Name = "Admin_DashBoard";
            Text = "ADM Dashboard";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button VerifyClaim;
        private Button reject;
        private Button button3;
        private Panel panel2;
        private Button button4;
        private Panel panel3;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox ADmin;
        private TextBox Claim;
        private Label label3;
        private Label label4;
        private Button Submit;
        private Button Status;
        private Label label5;
        private Label label6;
        private TextBox Approval_ID;
    }
}