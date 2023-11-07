namespace transportenquiry
{
    partial class u_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(u_main));
            pnlContainer = new Panel();
            btnstop = new Button();
            btnstart = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            incoming1 = new incoming();
            dataGridView1 = new DataGridView();
            Train_ID = new DataGridViewTextBoxColumn();
            Train_Name = new DataGridViewTextBoxColumn();
            Train_Source = new DataGridViewTextBoxColumn();
            Train_Destination = new DataGridViewTextBoxColumn();
            Arrival_Date = new DataGridViewTextBoxColumn();
            Arrival_Time = new DataGridViewTextBoxColumn();
            Departure_Date = new DataGridViewTextBoxColumn();
            Departure_Time = new DataGridViewTextBoxColumn();
            Fare = new DataGridViewTextBoxColumn();
            ongoing1 = new ongoing();
            pnlContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(btnstop);
            pnlContainer.Controls.Add(btnstart);
            pnlContainer.Controls.Add(textBox1);
            pnlContainer.Dock = DockStyle.Bottom;
            pnlContainer.Location = new Point(0, 731);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1852, 97);
            pnlContainer.TabIndex = 0;
            // 
            // btnstop
            // 
            btnstop.Font = new Font("Segoe Script", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnstop.Location = new Point(1137, 39);
            btnstop.Name = "btnstop";
            btnstop.Size = new Size(86, 46);
            btnstop.TabIndex = 2;
            btnstop.Text = "stop";
            btnstop.UseVisualStyleBackColor = true;
            // 
            // btnstart
            // 
            btnstart.Font = new Font("Segoe Script", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnstart.Location = new Point(1137, 0);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(86, 42);
            btnstart.TabIndex = 1;
            btnstart.Text = "start";
            btnstart.UseVisualStyleBackColor = true;
            btnstart.Click += btnstart_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(0, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1131, 94);
            textBox1.TabIndex = 0;
            textBox1.Text = "to start click start button and give input after input press stop";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1852, 92);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(54, 18);
            label1.Name = "label1";
            label1.Size = new Size(529, 53);
            label1.TabIndex = 0;
            label1.Text = "Transport Enqiury System";
            // 
            // incoming1
            // 
            incoming1.Avatar = (Image)resources.GetObject("incoming1.Avatar");
            incoming1.BackColor = Color.Transparent;
            incoming1.Location = new Point(0, 268);
            incoming1.Message = "";
            incoming1.Name = "incoming1";
            incoming1.Size = new Size(666, 198);
            incoming1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Train_ID, Train_Name, Train_Source, Train_Destination, Arrival_Date, Arrival_Time, Departure_Date, Departure_Time, Fare });
            dataGridView1.Location = new Point(0, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1223, 164);
            dataGridView1.TabIndex = 3;
            // 
            // Train_ID
            // 
            Train_ID.HeaderText = "Tain ID";
            Train_ID.MinimumWidth = 6;
            Train_ID.Name = "Train_ID";
            Train_ID.Width = 125;
            // 
            // Train_Name
            // 
            Train_Name.HeaderText = "Train Name";
            Train_Name.MinimumWidth = 6;
            Train_Name.Name = "Train_Name";
            Train_Name.Width = 125;
            // 
            // Train_Source
            // 
            Train_Source.HeaderText = "Train_Source";
            Train_Source.MinimumWidth = 6;
            Train_Source.Name = "Train_Source";
            Train_Source.Width = 125;
            // 
            // Train_Destination
            // 
            Train_Destination.HeaderText = "Train_Destination";
            Train_Destination.MinimumWidth = 6;
            Train_Destination.Name = "Train_Destination";
            Train_Destination.Width = 125;
            // 
            // Arrival_Date
            // 
            Arrival_Date.HeaderText = "Arrival_Date";
            Arrival_Date.MinimumWidth = 6;
            Arrival_Date.Name = "Arrival_Date";
            Arrival_Date.Width = 125;
            // 
            // Arrival_Time
            // 
            Arrival_Time.HeaderText = "Arrival_Time";
            Arrival_Time.MinimumWidth = 6;
            Arrival_Time.Name = "Arrival_Time";
            Arrival_Time.Width = 125;
            // 
            // Departure_Date
            // 
            Departure_Date.HeaderText = "Departure_Date";
            Departure_Date.MinimumWidth = 6;
            Departure_Date.Name = "Departure_Date";
            Departure_Date.Width = 125;
            // 
            // Departure_Time
            // 
            Departure_Time.HeaderText = "Departure_Time";
            Departure_Time.MinimumWidth = 6;
            Departure_Time.Name = "Departure_Time";
            Departure_Time.Width = 125;
            // 
            // Fare
            // 
            Fare.HeaderText = "Fare";
            Fare.MinimumWidth = 6;
            Fare.Name = "Fare";
            Fare.Width = 125;
            // 
            // ongoing1
            // 
            ongoing1.Avatar = (Image)resources.GetObject("ongoing1.Avatar");
            ongoing1.Location = new Point(791, 447);
            ongoing1.Message = "";
            ongoing1.Name = "ongoing1";
            ongoing1.Size = new Size(432, 124);
            ongoing1.TabIndex = 4;
            // 
            // u_main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1852, 828);
            Controls.Add(ongoing1);
            Controls.Add(dataGridView1);
            Controls.Add(incoming1);
            Controls.Add(panel1);
            Controls.Add(pnlContainer);
            Name = "u_main";
            Text = "u_main";
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Button btnstop;
        private Button btnstart;
        private incoming incoming1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Train_ID;
        private DataGridViewTextBoxColumn Train_Name;
        private DataGridViewTextBoxColumn Train_Source;
        private DataGridViewTextBoxColumn Train_Destination;
        private DataGridViewTextBoxColumn Arrival_Date;
        private DataGridViewTextBoxColumn Arrival_Time;
        private DataGridViewTextBoxColumn Departure_Date;
        private DataGridViewTextBoxColumn Departure_Time;
        private DataGridViewTextBoxColumn Fare;
        private ongoing ongoing1;
    }
}