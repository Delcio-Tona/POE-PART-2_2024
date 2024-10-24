namespace POE_of_Prog
{
    partial class Registration
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Firstname = new TextBox();
            Lastname = new TextBox();
            Address = new TextBox();
            Email = new TextBox();
            Phone = new TextBox();
            Username = new TextBox();
            Password = new TextBox();
            Submit = new Button();
            cancel = new Button();
            Back = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 98);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Firstname:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 135);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 165);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Address:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 194);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 232);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 4;
            label5.Text = "Phone Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 273);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 5;
            label6.Text = "Username:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 311);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 6;
            label7.Text = "Password:";
            // 
            // Firstname
            // 
            Firstname.Location = new Point(180, 95);
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(142, 23);
            Firstname.TabIndex = 7;
            // 
            // Lastname
            // 
            Lastname.Location = new Point(180, 129);
            Lastname.Name = "Lastname";
            Lastname.Size = new Size(142, 23);
            Lastname.TabIndex = 8;
            // 
            // Address
            // 
            Address.Location = new Point(180, 162);
            Address.Name = "Address";
            Address.Size = new Size(142, 23);
            Address.TabIndex = 9;
            Address.TextChanged += textBox3_TextChanged;
            // 
            // Email
            // 
            Email.Location = new Point(180, 194);
            Email.Name = "Email";
            Email.Size = new Size(142, 23);
            Email.TabIndex = 10;
            // 
            // Phone
            // 
            Phone.Location = new Point(180, 229);
            Phone.Name = "Phone";
            Phone.Size = new Size(142, 23);
            Phone.TabIndex = 11;
            // 
            // Username
            // 
            Username.Location = new Point(180, 268);
            Username.Name = "Username";
            Username.Size = new Size(142, 23);
            Username.TabIndex = 12;
            Username.TextChanged += Username_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(180, 308);
            Password.Name = "Password";
            Password.Size = new Size(142, 23);
            Password.TabIndex = 13;
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.ButtonShadow;
            Submit.Location = new Point(180, 374);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 29);
            Submit.TabIndex = 17;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // cancel
            // 
            cancel.BackColor = SystemColors.ButtonShadow;
            cancel.Location = new Point(283, 374);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 29);
            cancel.TabIndex = 18;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click;
            // 
            // Back
            // 
            Back.BackColor = SystemColors.ButtonShadow;
            Back.Location = new Point(37, 440);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 19;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(260, 47);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 20;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(585, 475);
            Controls.Add(label8);
            Controls.Add(Back);
            Controls.Add(cancel);
            Controls.Add(Submit);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(Phone);
            Controls.Add(Email);
            Controls.Add(Address);
            Controls.Add(Lastname);
            Controls.Add(Firstname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLight;
            Name = "Registration";
            Text = "User Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox Firstname;
        private TextBox Lastname;
        private TextBox Address;
        private TextBox Email;
        private TextBox Phone;
        private TextBox Username;
        private TextBox Password;
        private Button Submit;
        private Button cancel;
        private Button Back;
        private Label label8;
    }
}