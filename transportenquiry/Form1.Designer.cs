using System;

namespace VBATES
{
    partial class Form1
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
            EnquiryTextBox = new TextBox();
            EnquiryButton = new Button();
            ResponseLabel = new Label();
            label1 = new Label();
            start_btn = new Button();
            stop_btn = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // EnquiryTextBox
            // 
            EnquiryTextBox.Location = new Point(245, 165);
            EnquiryTextBox.Margin = new Padding(3, 4, 3, 4);
            EnquiryTextBox.Name = "EnquiryTextBox";
            EnquiryTextBox.Size = new Size(263, 27);
            EnquiryTextBox.TabIndex = 0;
            // 
            // EnquiryButton
            // 
            EnquiryButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            EnquiryButton.Location = new Point(290, 241);
            EnquiryButton.Margin = new Padding(3, 4, 3, 4);
            EnquiryButton.Name = "EnquiryButton";
            EnquiryButton.Size = new Size(159, 41);
            EnquiryButton.TabIndex = 1;
            EnquiryButton.Text = "EnquiryButton";
            EnquiryButton.UseVisualStyleBackColor = true;
            EnquiryButton.Click += EnquiryButton_Click_1;
            // 
            // ResponseLabel
            // 
            ResponseLabel.AutoSize = true;
            ResponseLabel.Location = new Point(310, 319);
            ResponseLabel.Name = "ResponseLabel";
            ResponseLabel.Size = new Size(108, 20);
            ResponseLabel.TabIndex = 2;
            ResponseLabel.Text = "ResponseLabel";
            ResponseLabel.Click += ResponseLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(187, 68);
            label1.Name = "label1";
            label1.Size = new Size(390, 25);
            label1.TabIndex = 3;
            label1.Text = "Voice Based Transport Enquiry System";
            label1.Click += label1_Click;
            // 
            // start_btn
            // 
            start_btn.Location = new Point(579, 272);
            start_btn.Name = "start_btn";
            start_btn.Size = new Size(94, 29);
            start_btn.TabIndex = 4;
            start_btn.Text = "start";
            start_btn.UseVisualStyleBackColor = true;
            start_btn.Click += start_btn_Click;
            // 
            // stop_btn
            // 
            stop_btn.Location = new Point(585, 233);
            stop_btn.Name = "stop_btn";
            stop_btn.Size = new Size(94, 29);
            stop_btn.TabIndex = 5;
            stop_btn.Text = "stop";
            stop_btn.UseVisualStyleBackColor = true;
            stop_btn.Click += stop_btn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(205, 398);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(502, 465);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 249);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 297);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(stop_btn);
            Controls.Add(start_btn);
            Controls.Add(label1);
            Controls.Add(ResponseLabel);
            Controls.Add(EnquiryButton);
            Controls.Add(EnquiryTextBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EnquiryTextBox;
        private Button EnquiryButton;
        private Label label1;
        private Label ResponseLabel;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Button start_btn;
        private Button stop_btn;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
    }
}

