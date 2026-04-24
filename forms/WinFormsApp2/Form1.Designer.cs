namespace WinFormsApp2
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
            label1 = new Label();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            checkedListBox1 = new CheckedListBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox4 = new TextBox();
            button3 = new Button();
            textBox6 = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 118);
            label1.Name = "label1";
            label1.Size = new Size(77, 38);
            label1.TabIndex = 0;
            label1.Text = "姓名";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 46);
            textBox1.TabIndex = 1;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(519, 119);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(84, 42);
            radioButton1.TabIndex = 2;
            radioButton1.Text = "男";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(609, 119);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(84, 42);
            radioButton2.TabIndex = 3;
            radioButton2.Text = "女";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(194, 220);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(500, 46);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(194, 320);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(500, 46);
            dateTimePicker2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 226);
            label2.Name = "label2";
            label2.Size = new Size(167, 38);
            label2.TabIndex = 6;
            label2.Text = "出生年月日";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 320);
            label3.Name = "label3";
            label3.Size = new Size(137, 38);
            label3.TabIndex = 7;
            label3.Text = "入職日期";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "打球", "上網", "打遊戲" });
            checkedListBox1.Location = new Point(194, 421);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(303, 219);
            checkedListBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 433);
            label4.Name = "label4";
            label4.Size = new Size(77, 38);
            label4.TabIndex = 9;
            label4.Text = "興趣";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "本國籍", "外國籍" });
            comboBox1.Location = new Point(142, 730);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 46);
            comboBox1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 730);
            label5.Name = "label5";
            label5.Size = new Size(77, 38);
            label5.TabIndex = 11;
            label5.Text = "國籍";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(979, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 46);
            textBox2.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(809, 103);
            label6.Name = "label6";
            label6.Size = new Size(137, 38);
            label6.TabIndex = 13;
            label6.Text = "通訊地址";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(809, 228);
            label7.Name = "label7";
            label7.Size = new Size(77, 38);
            label7.TabIndex = 14;
            label7.Text = "備註";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(956, 223);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(347, 143);
            textBox3.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(741, 848);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 16;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(519, 502);
            button2.Name = "button2";
            button2.Size = new Size(120, 58);
            button2.TabIndex = 17;
            button2.Text = "< <";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(665, 421);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(290, 219);
            textBox4.TabIndex = 18;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(809, 586);
            button3.Name = "button3";
            button3.Size = new Size(146, 54);
            button3.TabIndex = 19;
            button3.Text = "重設";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1194, 474);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(642, 571);
            textBox6.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1017, 477);
            label8.Name = "label8";
            label8.Size = new Size(137, 38);
            label8.TabIndex = 22;
            label8.Text = "資料呈現";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1960, 1162);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(checkedListBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label3;
        private CheckedListBox checkedListBox1;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private TextBox textBox4;
        private Button button3;
        private TextBox textBox6;
        private Label label8;
    }
}
