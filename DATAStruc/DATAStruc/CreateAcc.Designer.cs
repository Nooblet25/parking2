namespace DATAStruc
{
    partial class CreateAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAcc));
            textBox1 = new TextBox();
            EnterPasstxtBx = new TextBox();
            ConfirmPassTxtBx = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            CreateBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // EnterPasstxtBx
            // 
            EnterPasstxtBx.Location = new Point(24, 81);
            EnterPasstxtBx.Name = "EnterPasstxtBx";
            EnterPasstxtBx.Size = new Size(298, 23);
            EnterPasstxtBx.TabIndex = 1;
            // 
            // ConfirmPassTxtBx
            // 
            ConfirmPassTxtBx.Location = new Point(24, 127);
            ConfirmPassTxtBx.Name = "ConfirmPassTxtBx";
            ConfirmPassTxtBx.Size = new Size(298, 23);
            ConfirmPassTxtBx.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 16);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 65);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 4;
            label2.Text = "Enter password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 109);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 5;
            label3.Text = "Confirm Password";
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(130, 165);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(75, 23);
            CreateBtn.TabIndex = 6;
            CreateBtn.Text = "Create Account";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(299, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 29);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // CreateAcc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(339, 210);
            Controls.Add(pictureBox1);
            Controls.Add(CreateBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ConfirmPassTxtBx);
            Controls.Add(EnterPasstxtBx);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateAcc";
            Text = "CreateAcc";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox EnterPasstxtBx;
        private TextBox ConfirmPassTxtBx;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button CreateBtn;
        private PictureBox pictureBox1;
    }
}