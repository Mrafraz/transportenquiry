namespace transportenquiry
{
    partial class admin_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_login));
            label1 = new Label();
            login = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            back_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(317, 9);
            label1.Name = "label1";
            label1.Size = new Size(463, 39);
            label1.TabIndex = 0;
            label1.Text = "welcome to enquiry system";
            label1.Click += label1_Click;
            // 
            // login
            // 
            login.BackColor = SystemColors.Control;
            login.Font = new Font("Segoe Script", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            login.ForeColor = Color.Black;
            login.Location = new Point(557, 339);
            login.Name = "login";
            login.Size = new Size(138, 50);
            login.TabIndex = 1;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(476, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 27);
            textBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 448);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(476, 268);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 27);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(328, 192);
            label2.Name = "label2";
            label2.Size = new Size(130, 31);
            label2.TabIndex = 6;
            label2.Text = "Admin ID ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(328, 268);
            label3.Name = "label3";
            label3.Size = new Size(123, 31);
            label3.TabIndex = 7;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(354, 92);
            label4.Name = "label4";
            label4.Size = new Size(364, 52);
            label4.TabIndex = 8;
            label4.Text = "Login To System";
            // 
            // back_btn
            // 
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.Font = new Font("Segoe Script", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            back_btn.Location = new Point(386, 339);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(94, 50);
            back_btn.TabIndex = 9;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // admin_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(back_btn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(login);
            Controls.Add(label1);
            Name = "admin_login";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button login;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button back_btn;
    }
}