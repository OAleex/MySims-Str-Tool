namespace MySims_Str_Tool
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
            button1 = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 26);
            button1.Name = "button1";
            button1.Size = new Size(139, 53);
            button1.TabIndex = 0;
            button1.Text = "Extract";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 102);
            button2.Name = "button2";
            button2.Size = new Size(139, 53);
            button2.TabIndex = 1;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F);
            linkLabel1.Location = new Point(428, 193);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(121, 19);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Alex \"OAleex\" Félix";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(15, 175);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(40, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "PC";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(61, 175);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(95, 19);
            radioButton2.TabIndex = 4;
            radioButton2.Text = "Nintendo Wii";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(380, 193);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 5;
            label1.Text = "Tool by";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(302, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 129);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 237);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(666, 276);
            MinimumSize = new Size(666, 276);
            Name = "Form1";
            ShowIcon = false;
            Text = "MySims Str Tool";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private LinkLabel linkLabel1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
