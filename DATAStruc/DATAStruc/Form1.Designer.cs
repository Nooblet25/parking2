namespace DATAStruc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            waitingGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            txtlicense = new TextBox();
            Removebtn = new Button();
            Addbtn = new Button();
            parkingGridView = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            toolTip1 = new ToolTip(components);
            panel3 = new Panel();
            historyGridView = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)waitingGridView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)parkingGridView).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)historyGridView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(129, 54);
            button1.TabIndex = 0;
            button1.Text = "Park or Unpark";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 72);
            button2.Name = "button2";
            button2.Size = new Size(129, 54);
            button2.TabIndex = 1;
            button2.Text = "Waiting list";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 132);
            button3.Name = "button3";
            button3.Size = new Size(129, 54);
            button3.TabIndex = 2;
            button3.Text = "History";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(waitingGridView);
            panel1.Location = new Point(147, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 174);
            panel1.TabIndex = 3;
            // 
            // waitingGridView
            // 
            waitingGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            waitingGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            waitingGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            waitingGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            waitingGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            waitingGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            waitingGridView.Location = new Point(3, 3);
            waitingGridView.Name = "waitingGridView";
            waitingGridView.Size = new Size(450, 168);
            waitingGridView.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Position Queue";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "License Plate";
            Column2.Name = "Column2";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtlicense);
            panel2.Controls.Add(Removebtn);
            panel2.Controls.Add(Addbtn);
            panel2.Controls.Add(parkingGridView);
            panel2.Location = new Point(147, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 210);
            panel2.TabIndex = 4;
            // 
            // txtlicense
            // 
            txtlicense.Location = new Point(3, 158);
            txtlicense.Name = "txtlicense";
            txtlicense.Size = new Size(450, 23);
            txtlicense.TabIndex = 3;
            // 
            // Removebtn
            // 
            Removebtn.Location = new Point(207, 183);
            Removebtn.Name = "Removebtn";
            Removebtn.Size = new Size(92, 23);
            Removebtn.TabIndex = 2;
            Removebtn.Text = "Remove";
            Removebtn.UseVisualStyleBackColor = true;
            Removebtn.Click += Removebtn_Click;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(109, 183);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(92, 23);
            Addbtn.TabIndex = 1;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // parkingGridView
            // 
            parkingGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            parkingGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            parkingGridView.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4, Column5 });
            parkingGridView.Location = new Point(3, 3);
            parkingGridView.Name = "parkingGridView";
            parkingGridView.Size = new Size(453, 149);
            parkingGridView.TabIndex = 0;
            // 
            // Column3
            // 
            Column3.HeaderText = "Slot";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "License Plate";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Status";
            Column5.Name = "Column5";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Enter License Plate Number";
            // 
            // panel3
            // 
            panel3.Controls.Add(historyGridView);
            panel3.Location = new Point(147, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(456, 181);
            panel3.TabIndex = 5;
            // 
            // historyGridView
            // 
            historyGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            historyGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyGridView.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8 });
            historyGridView.Location = new Point(0, 0);
            historyGridView.Name = "historyGridView";
            historyGridView.Size = new Size(456, 181);
            historyGridView.TabIndex = 0;
            // 
            // Column6
            // 
            Column6.HeaderText = "Action";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "License Plate";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Time";
            Column8.Name = "Column8";
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.FB_IMG_1727598580730;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(147, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(456, 210);
            panel4.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(615, 222);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)waitingGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)parkingGridView).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)historyGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private DataGridView waitingGridView;
        private Panel panel2;
        private DataGridView parkingGridView;
        private Button Addbtn;
        private TextBox txtlicense;
        private Button Removebtn;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel3;
        private DataGridView historyGridView;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Panel panel4;
    }
}
