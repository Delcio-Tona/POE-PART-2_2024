namespace POE_of_Prog
{
    partial class Lecturer_DashBoard
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Claim = new Button();
            viewClaim = new Button();
            panel2 = new Panel();
            label1 = new Label();
            Logout = new Button();
            TrackingStatus = new Button();
            panel3 = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Claim
            // 
            Claim.BackColor = SystemColors.ButtonShadow;
            Claim.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Claim.ForeColor = SystemColors.ControlLight;
            Claim.Location = new Point(-1, 88);
            Claim.Name = "Claim";
            Claim.Size = new Size(127, 50);
            Claim.TabIndex = 0;
            Claim.Text = "Claim";
            Claim.UseVisualStyleBackColor = false;
            Claim.Click += Claim_Click;
            // 
            // viewClaim
            // 
            viewClaim.BackColor = SystemColors.ButtonShadow;
            viewClaim.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewClaim.ForeColor = SystemColors.ButtonHighlight;
            viewClaim.Location = new Point(-1, 157);
            viewClaim.Name = "viewClaim";
            viewClaim.Size = new Size(127, 51);
            viewClaim.TabIndex = 1;
            viewClaim.Text = "View Claims";
            viewClaim.UseVisualStyleBackColor = false;
            viewClaim.Click += viewClaim_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Logout);
            panel2.Controls.Add(TrackingStatus);
            panel2.Controls.Add(Claim);
            panel2.Controls.Add(viewClaim);
            panel2.ForeColor = SystemColors.ControlLight;
            panel2.Location = new Point(674, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(157, 416);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 4;
            // 
            // Logout
            // 
            Logout.BackColor = SystemColors.ButtonShadow;
            Logout.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout.ForeColor = SystemColors.ButtonHighlight;
            Logout.Location = new Point(-1, 299);
            Logout.Name = "Logout";
            Logout.Size = new Size(124, 42);
            Logout.TabIndex = 3;
            Logout.Text = "Log Out";
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // TrackingStatus
            // 
            TrackingStatus.BackColor = SystemColors.ButtonShadow;
            TrackingStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TrackingStatus.ForeColor = SystemColors.ButtonHighlight;
            TrackingStatus.Location = new Point(-1, 233);
            TrackingStatus.Name = "TrackingStatus";
            TrackingStatus.Size = new Size(124, 45);
            TrackingStatus.TabIndex = 2;
            TrackingStatus.Text = "TrackingStatus";
            TrackingStatus.UseVisualStyleBackColor = false;
            TrackingStatus.Click += TrackingStatus_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Menu;
            panel3.Controls.Add(label2);
            panel3.ForeColor = SystemColors.InfoText;
            panel3.Location = new Point(7, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(844, 35);
            panel3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 21);
            label2.TabIndex = 0;
            label2.Text = "Lecturer Dashboard";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Location = new Point(7, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Size = new Size(651, 374);
            dataGridView1.TabIndex = 6;
            // 
            // Lecturer_DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(833, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Lecturer_DashBoard";
            Text = "Lecturer Dashboard";
            Load += Lecturer_DashBoard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Claim;
        private Button viewClaim;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Button Logout;
        private Button TrackingStatus;
        private DataGridView dataGridView1;
    }
}