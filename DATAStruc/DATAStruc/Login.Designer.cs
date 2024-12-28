namespace DATAStruc
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            UserNameTxtBx = new TextBox();
            PasswordTxtBx = new TextBox();
            label1 = new Label();
            label2 = new Label();
            EnterBtn = new Button();
            linkLabel1 = new LinkLabel();
            Username = new ToolTip(components);
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            CreateAccLinkLbl = new LinkLabel();
            SuspendLayout();
            // 
            // UserNameTxtBx
            // 
            UserNameTxtBx.Location = new Point(147, 85);
            UserNameTxtBx.Name = "UserNameTxtBx";
            UserNameTxtBx.Size = new Size(293, 23);
            UserNameTxtBx.TabIndex = 8;
            UserNameTxtBx.TextChanged += UserNameTxtBx_TextChanged;
            // 
            // PasswordTxtBx
            // 
            PasswordTxtBx.Location = new Point(147, 132);
            PasswordTxtBx.Name = "PasswordTxtBx";
            PasswordTxtBx.Size = new Size(293, 23);
            PasswordTxtBx.TabIndex = 7;
            PasswordTxtBx.TextChanged += PasswordTxtBx_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.ImageKey = "(none)";
            label1.Location = new Point(147, 60);
            label1.Name = "label1";
            label1.Size = new Size(101, 18);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.ImageKey = "(none)";
            label2.Location = new Point(147, 111);
            label2.Name = "label2";
            label2.Size = new Size(105, 18);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // EnterBtn
            // 
            EnterBtn.BackColor = Color.DimGray;
            EnterBtn.Location = new Point(233, 188);
            EnterBtn.Name = "EnterBtn";
            EnterBtn.Size = new Size(130, 27);
            EnterBtn.TabIndex = 5;
            EnterBtn.Text = "Enter";
            EnterBtn.UseVisualStyleBackColor = false;
            EnterBtn.Click += EnterBtn_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Location = new Point(252, 248);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot password?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Username
            // 
            Username.ToolTipTitle = "Enter Your username";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Enter password";
            // 
            // toolTip2
            // 
            toolTip2.ToolTipTitle = "Enter";
            // 
            // toolTip3
            // 
            toolTip3.ToolTipTitle = "bobo mo nakalimutan mo?";
            // 
            // CreateAccLinkLbl
            // 
            CreateAccLinkLbl.AutoSize = true;
            CreateAccLinkLbl.Location = new Point(252, 158);
            CreateAccLinkLbl.Name = "CreateAccLinkLbl";
            CreateAccLinkLbl.Size = new Size(89, 15);
            CreateAccLinkLbl.TabIndex = 9;
            CreateAccLinkLbl.TabStop = true;
            CreateAccLinkLbl.Text = "Create Account";
            CreateAccLinkLbl.LinkClicked += CreateAccLinkLbl_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(594, 272);
            Controls.Add(CreateAccLinkLbl);
            Controls.Add(linkLabel1);
            Controls.Add(EnterBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTxtBx);
            Controls.Add(UserNameTxtBx);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserNameTxtBx;
        private TextBox PasswordTxtBx;
        private Label label1;
        private Label label2;
        private Button EnterBtn;
        private LinkLabel linkLabel1;
        private ToolTip Username;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private LinkLabel CreateAccLinkLbl;
    }
}