namespace TrainReservationSystem
{
    partial class Trains
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        ///
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
            label14 = new Label();
            label15 = new Label();
            destinationBox = new TextBox();
            label13 = new Label();
            sourceBox = new TextBox();
            label11 = new Label();
            trainNameBox = new TextBox();
            label8 = new Label();
            exitButton = new Button();
            backButton = new Button();
            updateButton = new Button();
            addButton = new Button();
            trainIdBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            fareBox = new TextBox();
            label5 = new Label();
            deleteButton = new Button();
            dataGridView1 = new DataGridView();
            Train_ID = new DataGridViewTextBoxColumn();
            Train_Name = new DataGridViewTextBoxColumn();
            Train_Source = new DataGridViewTextBoxColumn();
            Train_Destination = new DataGridViewTextBoxColumn();
            arrivalDate = new DataGridViewTextBoxColumn();
            arrivalTime = new DataGridViewTextBoxColumn();
            departureDate = new DataGridViewTextBoxColumn();
            departure_Time = new DataGridViewTextBoxColumn();
            fare = new DataGridViewTextBoxColumn();
            searchBox = new TextBox();
            label10 = new Label();
            searchButton = new Button();
            menuStrip1 = new MenuStrip();
            trainsToolStripMenuItem = new ToolStripMenuItem();
            addTrainToolStripMenuItem = new ToolStripMenuItem();
            updateTrainToolStripMenuItem = new ToolStripMenuItem();
            removeTrainToolStripMenuItem = new ToolStripMenuItem();
            passengersToolStripMenuItem = new ToolStripMenuItem();
            addNewPassengerToolStripMenuItem = new ToolStripMenuItem();
            updateExistingToolStripMenuItem = new ToolStripMenuItem();
            unBookSeatToolStripMenuItem = new ToolStripMenuItem();
            arrivalTimePicker = new DateTimePicker();
            departureTimePicker = new DateTimePicker();
            lblarrdate = new Label();
            label4 = new Label();
            ArrivalDatepicker = new DateTimePicker();
            DeparturedatePicker = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Tai Le", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(384, 368);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(156, 26);
            label14.TabIndex = 71;
            label14.Text = "Departure Time";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(8, 362);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(140, 30);
            label15.TabIndex = 70;
            label15.Text = "Arrival Time";
            // 
            // destinationBox
            // 
            destinationBox.Location = new Point(555, 257);
            destinationBox.Margin = new Padding(4, 5, 4, 5);
            destinationBox.Name = "destinationBox";
            destinationBox.Size = new Size(196, 27);
            destinationBox.TabIndex = 3;
            destinationBox.KeyUp += destinationBox_KeyUp;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(405, 257);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(135, 30);
            label13.TabIndex = 66;
            label13.Text = "Destination";
            // 
            // sourceBox
            // 
            sourceBox.Location = new Point(161, 257);
            sourceBox.Margin = new Padding(4, 5, 4, 5);
            sourceBox.Name = "sourceBox";
            sourceBox.Size = new Size(191, 27);
            sourceBox.TabIndex = 2;
            sourceBox.KeyUp += sourceBox_KeyUp;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(36, 252);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(86, 30);
            label11.TabIndex = 60;
            label11.Text = "Source";
            // 
            // trainNameBox
            // 
            trainNameBox.Location = new Point(555, 198);
            trainNameBox.Margin = new Padding(4, 5, 4, 5);
            trainNameBox.Name = "trainNameBox";
            trainNameBox.Size = new Size(196, 27);
            trainNameBox.TabIndex = 1;
            trainNameBox.KeyUp += trainNameBox_KeyUp;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(403, 195);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(137, 30);
            label8.TabIndex = 55;
            label8.Text = "Train Name";
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Transparent;
            exitButton.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.ForeColor = Color.Red;
            exitButton.Location = new Point(1213, 612);
            exitButton.Margin = new Padding(4, 5, 4, 5);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(139, 65);
            exitButton.TabIndex = 16;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Transparent;
            backButton.Font = new Font("Segoe Script", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.Location = new Point(1056, 612);
            backButton.Margin = new Padding(4, 5, 4, 5);
            backButton.Name = "backButton";
            backButton.Size = new Size(149, 65);
            backButton.TabIndex = 15;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.Transparent;
            updateButton.Font = new Font("Segoe Script", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            updateButton.Location = new Point(363, 518);
            updateButton.Margin = new Padding(4, 5, 4, 5);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(165, 65);
            updateButton.TabIndex = 11;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Transparent;
            addButton.Font = new Font("Segoe Script", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.Location = new Point(161, 518);
            addButton.Margin = new Padding(4, 5, 4, 5);
            addButton.Name = "addButton";
            addButton.Size = new Size(157, 65);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // trainIdBox
            // 
            trainIdBox.Location = new Point(161, 194);
            trainIdBox.Margin = new Padding(4, 5, 4, 5);
            trainIdBox.MaxLength = 5;
            trainIdBox.Name = "trainIdBox";
            trainIdBox.Size = new Size(191, 27);
            trainIdBox.TabIndex = 0;
            trainIdBox.KeyPress += trainIdBox_KeyPress;
            trainIdBox.KeyUp += trainIdBox_KeyUp;
            trainIdBox.Validating += trainIdBox_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(564, 66);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 52);
            label2.TabIndex = 45;
            label2.Text = "Trains";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 189);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 30);
            label1.TabIndex = 44;
            label1.Text = "Train ID";
            // 
            // fareBox
            // 
            fareBox.Location = new Point(161, 442);
            fareBox.Margin = new Padding(4, 5, 4, 5);
            fareBox.Name = "fareBox";
            fareBox.Size = new Size(196, 27);
            fareBox.TabIndex = 9;
            fareBox.KeyUp += fareBox_KeyUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Tai Le", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(71, 443);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 26);
            label5.TabIndex = 79;
            label5.Text = "Fare";
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Transparent;
            deleteButton.Font = new Font("Segoe Script", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.Location = new Point(573, 518);
            deleteButton.Margin = new Padding(4, 5, 4, 5);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(179, 65);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.CursorChanged += deleteButton_Click;
            deleteButton.Click += deleteButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Train_ID, Train_Name, Train_Source, Train_Destination, arrivalDate, arrivalTime, departureDate, departure_Time, fare });
            dataGridView1.Location = new Point(787, 198);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(599, 385);
            dataGridView1.TabIndex = 83;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Train_ID
            // 
            Train_ID.HeaderText = "Train ID";
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
            Train_Source.HeaderText = "Train Source";
            Train_Source.MinimumWidth = 6;
            Train_Source.Name = "Train_Source";
            Train_Source.Width = 125;
            // 
            // Train_Destination
            // 
            Train_Destination.HeaderText = "Train Destination";
            Train_Destination.MinimumWidth = 6;
            Train_Destination.Name = "Train_Destination";
            Train_Destination.Width = 125;
            // 
            // arrivalDate
            // 
            arrivalDate.HeaderText = "Arrival Date";
            arrivalDate.MinimumWidth = 6;
            arrivalDate.Name = "arrivalDate";
            arrivalDate.Width = 125;
            // 
            // arrivalTime
            // 
            arrivalTime.HeaderText = "Arrival Time";
            arrivalTime.MinimumWidth = 6;
            arrivalTime.Name = "arrivalTime";
            arrivalTime.Width = 125;
            // 
            // departureDate
            // 
            departureDate.HeaderText = "Departure Date";
            departureDate.MinimumWidth = 6;
            departureDate.Name = "departureDate";
            departureDate.Width = 125;
            // 
            // departure_Time
            // 
            departure_Time.HeaderText = "Departure Time";
            departure_Time.MinimumWidth = 6;
            departure_Time.Name = "departure_Time";
            departure_Time.Width = 125;
            // 
            // fare
            // 
            fare.HeaderText = "Fare";
            fare.MinimumWidth = 6;
            fare.Name = "fare";
            fare.Width = 125;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(871, 160);
            searchBox.Margin = new Padding(4, 5, 4, 5);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(383, 27);
            searchBox.TabIndex = 13;
            searchBox.TextChanged += searchBox_TextChanged;
            searchBox.KeyUp += searchBox_KeyUp;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Tai Le", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(781, 157);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(74, 26);
            label10.TabIndex = 128;
            label10.Text = "Search";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(1263, 157);
            searchButton.Margin = new Padding(4, 5, 4, 5);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(123, 35);
            searchButton.TabIndex = 14;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDark;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { trainsToolStripMenuItem, passengersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1396, 33);
            menuStrip1.TabIndex = 144;
            menuStrip1.Text = "menuStrip1";
            // 
            // trainsToolStripMenuItem
            // 
            trainsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addTrainToolStripMenuItem, updateTrainToolStripMenuItem, removeTrainToolStripMenuItem });
            trainsToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            trainsToolStripMenuItem.Name = "trainsToolStripMenuItem";
            trainsToolStripMenuItem.Size = new Size(71, 27);
            trainsToolStripMenuItem.Text = "Trains";
            trainsToolStripMenuItem.Click += trainsToolStripMenuItem_Click;
            // 
            // addTrainToolStripMenuItem
            // 
            addTrainToolStripMenuItem.Name = "addTrainToolStripMenuItem";
            addTrainToolStripMenuItem.Size = new Size(203, 28);
            addTrainToolStripMenuItem.Text = "Add Train";
            addTrainToolStripMenuItem.Click += addTrainToolStripMenuItem_Click;
            // 
            // updateTrainToolStripMenuItem
            // 
            updateTrainToolStripMenuItem.Name = "updateTrainToolStripMenuItem";
            updateTrainToolStripMenuItem.Size = new Size(203, 28);
            updateTrainToolStripMenuItem.Text = "Update Train";
            updateTrainToolStripMenuItem.Click += updateTrainToolStripMenuItem_Click;
            // 
            // removeTrainToolStripMenuItem
            // 
            removeTrainToolStripMenuItem.Name = "removeTrainToolStripMenuItem";
            removeTrainToolStripMenuItem.Size = new Size(203, 28);
            removeTrainToolStripMenuItem.Text = "Remove Train";
            removeTrainToolStripMenuItem.Click += removeTrainToolStripMenuItem_Click;
            // 
            // passengersToolStripMenuItem
            // 
            passengersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewPassengerToolStripMenuItem, updateExistingToolStripMenuItem, unBookSeatToolStripMenuItem });
            passengersToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            passengersToolStripMenuItem.Name = "passengersToolStripMenuItem";
            passengersToolStripMenuItem.Size = new Size(110, 27);
            passengersToolStripMenuItem.Text = "Passengers";
            // 
            // addNewPassengerToolStripMenuItem
            // 
            addNewPassengerToolStripMenuItem.Name = "addNewPassengerToolStripMenuItem";
            addNewPassengerToolStripMenuItem.Size = new Size(204, 28);
            addNewPassengerToolStripMenuItem.Text = "Book Seat";
            addNewPassengerToolStripMenuItem.Click += addNewPassengerToolStripMenuItem_Click;
            // 
            // updateExistingToolStripMenuItem
            // 
            updateExistingToolStripMenuItem.Name = "updateExistingToolStripMenuItem";
            updateExistingToolStripMenuItem.Size = new Size(204, 28);
            updateExistingToolStripMenuItem.Text = "Re-Book Seat";
            updateExistingToolStripMenuItem.Click += updateExistingToolStripMenuItem_Click;
            // 
            // unBookSeatToolStripMenuItem
            // 
            unBookSeatToolStripMenuItem.Name = "unBookSeatToolStripMenuItem";
            unBookSeatToolStripMenuItem.Size = new Size(204, 28);
            unBookSeatToolStripMenuItem.Text = "Un-Book Seat";
            unBookSeatToolStripMenuItem.Click += unBookSeatToolStripMenuItem_Click;
            // 
            // arrivalTimePicker
            // 
            arrivalTimePicker.Format = DateTimePickerFormat.Time;
            arrivalTimePicker.Location = new Point(156, 365);
            arrivalTimePicker.Margin = new Padding(4, 5, 4, 5);
            arrivalTimePicker.Name = "arrivalTimePicker";
            arrivalTimePicker.ShowUpDown = true;
            arrivalTimePicker.Size = new Size(191, 27);
            arrivalTimePicker.TabIndex = 145;
            arrivalTimePicker.Value = new DateTime(2023, 10, 24, 19, 1, 0, 0);
            arrivalTimePicker.ValueChanged += arrivalTimePicker_ValueChanged;
            // 
            // departureTimePicker
            // 
            departureTimePicker.Format = DateTimePickerFormat.Time;
            departureTimePicker.Location = new Point(555, 365);
            departureTimePicker.Margin = new Padding(4, 5, 4, 5);
            departureTimePicker.Name = "departureTimePicker";
            departureTimePicker.ShowUpDown = true;
            departureTimePicker.Size = new Size(196, 27);
            departureTimePicker.TabIndex = 146;
            departureTimePicker.Value = new DateTime(2020, 9, 2, 3, 46, 1, 0);
            departureTimePicker.ValueChanged += departureTimePicker_ValueChanged;
            // 
            // lblarrdate
            // 
            lblarrdate.AutoSize = true;
            lblarrdate.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblarrdate.Location = new Point(8, 310);
            lblarrdate.Margin = new Padding(4, 0, 4, 0);
            lblarrdate.Name = "lblarrdate";
            lblarrdate.Size = new Size(137, 30);
            lblarrdate.TabIndex = 148;
            lblarrdate.Text = "Arrival Date";
            lblarrdate.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(363, 309);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(177, 30);
            label4.TabIndex = 149;
            label4.Text = "Departure Date";
            // 
            // ArrivalDatepicker
            // 
            ArrivalDatepicker.Format = DateTimePickerFormat.Short;
            ArrivalDatepicker.Location = new Point(161, 310);
            ArrivalDatepicker.Margin = new Padding(4, 5, 4, 5);
            ArrivalDatepicker.Name = "ArrivalDatepicker";
            ArrivalDatepicker.ShowUpDown = true;
            ArrivalDatepicker.Size = new Size(191, 27);
            ArrivalDatepicker.TabIndex = 150;
            ArrivalDatepicker.Value = new DateTime(2023, 10, 24, 0, 0, 0, 0);
            ArrivalDatepicker.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // DeparturedatePicker
            // 
            DeparturedatePicker.Format = DateTimePickerFormat.Short;
            DeparturedatePicker.Location = new Point(555, 309);
            DeparturedatePicker.Margin = new Padding(4, 5, 4, 5);
            DeparturedatePicker.Name = "DeparturedatePicker";
            DeparturedatePicker.ShowUpDown = true;
            DeparturedatePicker.Size = new Size(191, 27);
            DeparturedatePicker.TabIndex = 145;
            DeparturedatePicker.Value = new DateTime(2023, 10, 24, 0, 0, 0, 0);
            DeparturedatePicker.ValueChanged += arrivalTimePicker_ValueChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Trains
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1396, 695);
            Controls.Add(ArrivalDatepicker);
            Controls.Add(label4);
            Controls.Add(lblarrdate);
            Controls.Add(departureTimePicker);
            Controls.Add(DeparturedatePicker);
            Controls.Add(arrivalTimePicker);
            Controls.Add(fareBox);
            Controls.Add(menuStrip1);
            Controls.Add(searchButton);
            Controls.Add(searchBox);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(deleteButton);
            Controls.Add(label5);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(destinationBox);
            Controls.Add(label13);
            Controls.Add(sourceBox);
            Controls.Add(label11);
            Controls.Add(trainNameBox);
            Controls.Add(label8);
            Controls.Add(exitButton);
            Controls.Add(backButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(trainIdBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Trains";
            Text = "Trains";
            Load += Trains_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label14;
        private Label label15;
        private TextBox destinationBox;
        private Label label13;
        private TextBox sourceBox;
        private Label label11;
        private TextBox trainNameBox;
        private Label label8;
        private Button exitButton;
        private Button backButton;
        private Button updateButton;
        private Button addButton;
        private TextBox trainIdBox;
        private Label label2;
        private Label label1;
        private TextBox fareBox;
        private Label label5;
        private Button deleteButton;
        private DataGridView dataGridView1;
        private TextBox searchBox;
        private Label label10;
        private Button searchButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem trainsToolStripMenuItem;
        private ToolStripMenuItem addTrainToolStripMenuItem;
        private ToolStripMenuItem updateTrainToolStripMenuItem;
        private ToolStripMenuItem removeTrainToolStripMenuItem;
        private ToolStripMenuItem passengersToolStripMenuItem;
        private ToolStripMenuItem addNewPassengerToolStripMenuItem;
        private ToolStripMenuItem updateExistingToolStripMenuItem;
        private ToolStripMenuItem unBookSeatToolStripMenuItem;
        private DateTimePicker arrivalTimePicker;
        private DateTimePicker departureTimePicker;
        private DataGridViewTextBoxColumn Train_ID;
        private DataGridViewTextBoxColumn Train_Name;
        private DataGridViewTextBoxColumn Train_Source;
        private DataGridViewTextBoxColumn Train_Destination;
        private DataGridViewTextBoxColumn arrivalDate;
        private DataGridViewTextBoxColumn arrivalTime;
        private DataGridViewTextBoxColumn departureDate;
        private DataGridViewTextBoxColumn departure_Time;
        private DataGridViewTextBoxColumn fare;
        private Label lblarrdate;
        private Label label4;
        private DateTimePicker ArrivalDatepicker;
        private DateTimePicker DeparturedatePicker;
        private ErrorProvider errorProvider1;
    }
}
