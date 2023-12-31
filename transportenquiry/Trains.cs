﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using transportenquiry;
namespace TrainReservationSystem
{
    public partial class Trains : Form
    {

        // sql connection string .... change it according to your system sql server string
        SqlConnection sql = new SqlConnection("Server=HONOR\\SQLEXPRESS01;Database=db;Trusted_Connection=True");


        public Trains()
        {
            InitializeComponent();
            // Populate the data into data grid
            populateData();
            trainIdBox.Focus();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Open the new admin module form
            admin_login ad_lg = new admin_login();
            ad_lg.Show();
            this.Hide();
        }

        // populate the data in data grid view from text boxes 
        private void populateData()
        {
            // Open sql connection
            sql.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from trains", sql);       // retrieve the records from trains database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string trainID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string trainName = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    string trainSource = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    string destination = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    DateTime arrivalTime = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[4].ToString());
                    DateTime departureTime = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[5].ToString());
                    string fare = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                    String arrivalDate = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                    String departureDate = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                    DataGridViewRow row1 = new DataGridViewRow();
                    row1.CreateCells(dataGridView1);
                    row1.Cells[0].Value = trainID;
                    row1.Cells[1].Value = trainName;
                    row1.Cells[2].Value = trainSource;
                    row1.Cells[3].Value = destination;
                    row1.Cells[4].Value = arrivalDate;
                    row1.Cells[5].Value = arrivalTime.TimeOfDay;
                    row1.Cells[6].Value = departureDate;
                    row1.Cells[7].Value = departureTime.Date;
                    row1.Cells[8].Value = fare;


                    dataGridView1.Rows.Add(row1);
                }
                // Close sql connection
                sql.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);            // show the exception message in message box
            }

        }

        // update function for updating the data in database
        private void update()
        {
            string trainID = trainIdBox.Text;
            string trainName = trainNameBox.Text;
            string source = sourceBox.Text;
            string destination = destinationBox.Text;
            DateTime arrivalTime = arrivalTimePicker.Value;
            DateTime departureTime = departureTimePicker.Value;
            DateTime arrivalDate = ArrivalDatepicker.Value;
            DateTime departureDate = DeparturedatePicker.Value;
            string fare = fareBox.Text;

            try
            {
                // open the sql connection
                sql.Open();
                SqlCommand updateTrain = new SqlCommand("update Trains set trainNo=@trainID,trainName=@trainName,trainSource=@trainsource,destination=@destination,arrivalTime=@arrivalTime,departureTime=@departureTime,fare=@fare,arrivalDate=@arrivalDate,departureDate=@departureDate where trainNo=@trainID", sql);

                updateTrain.Parameters.AddWithValue("@trainID", trainID);
                updateTrain.Parameters.AddWithValue("@trainName", trainName);
                updateTrain.Parameters.AddWithValue("@trainSource", source);
                updateTrain.Parameters.AddWithValue("@destination", destination);
                updateTrain.Parameters.AddWithValue("@arrivalTime", arrivalTime);
                updateTrain.Parameters.AddWithValue("@departureTime", departureTime);
                updateTrain.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                updateTrain.Parameters.AddWithValue("@departureDate", departureDate);
                updateTrain.Parameters.AddWithValue("@fare", fare);
                updateTrain.ExecuteNonQuery();

                MessageBox.Show("Train Data Updated Successfully :)");
                sql.Close();        // close the sql connection
                populateData();     // populate the data grid with database records
            }
            // catch the exception if occur and show in message box
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();         // exit from application
        }

        // save function for saving the data in database
        void save()
        {
            string trainID = trainIdBox.Text;
            string trainName = trainNameBox.Text;
            string source = sourceBox.Text;
            string destination = destinationBox.Text;
            DateTime arrivalTime = arrivalTimePicker.Value;
            DateTime departureTime = departureTimePicker.Value;
            DateTime arrivalDate = ArrivalDatepicker.Value;
            DateTime departureDate = DeparturedatePicker.Value;

            string fare = fareBox.Text;
            sql.Open();
            try
            {
                int stationNo = RandomNumber(1, 1000);
                SqlCommand insertTrain = new SqlCommand("insert into trains(trainNo,trainName,trainSource,destination,arrivalTime,departureTime,fare,arrivalDate,departureDate) values(@trainID,@trainName,@trainSource,@destination,@arrivaltime,@departureTime,@fare,@arrivalDate,@departureDate)", sql);
                //SqlCommand insertStation = new SqlCommand("insert into Stations(stationNo,stationName,trainNo) Values(@sNo,@sName,@tNo)", sql);

                insertTrain.Parameters.AddWithValue("@trainID", trainID);
                insertTrain.Parameters.AddWithValue("@trainName", trainName);
                insertTrain.Parameters.AddWithValue("@trainSource", source);
                insertTrain.Parameters.AddWithValue("@destination", destination);
                insertTrain.Parameters.AddWithValue("@arrivalTime", arrivalTime);
                insertTrain.Parameters.AddWithValue("@departureTime", departureTime);
                insertTrain.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                insertTrain.Parameters.AddWithValue("@departuredate", departureDate);
                insertTrain.Parameters.AddWithValue("@fare", fare);
                insertTrain.ExecuteNonQuery();

                /* for(int i=0;i<2;++i)
                 {
                     stationNo = RandomNumber(1, 1000);
                     insertStation.Parameters.AddWithValue("@sNo", stationNo);
                     insertStation.Parameters.AddWithValue("@sName", source);
                     insertStation.Parameters.AddWithValue("@tNo", trainID);
                     insertStation.ExecuteNonQuery();
                 }*/


                MessageBox.Show("Train Added Successfully :");
                trainIdBox.Text = "";
                trainNameBox.Text = "";
                sourceBox.Text = "";
                destinationBox.Text = "";
                arrivalTimePicker.Text = "";
                departureTimePicker.Text = "";
                ArrivalDatepicker.Text = "";
                DeparturedatePicker.Text = "";
                fareBox.Text = "";
                trainIdBox.Focus();
            }
            // Catch the exception in message box
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sql.Close();
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // call of save function for updating the data in database
            save();
            // populate the saved data in data grid view
            populateData();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            update();
        }
        private void delete()
        {
            try
            {
                sql.Open();
                string name = trainIdBox.Text;
                SqlCommand cmd = new SqlCommand("delete from Trains where trainNo=@a", sql);
                cmd.Parameters.AddWithValue("@a", name);
                cmd.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Data Deleted Successfully ):");
                populateData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void search()
        {

            try
            {
                sql.Open();
                string data = searchBox.Text;
                SqlCommand cmd = new SqlCommand("select * from trains where trainNo like @a+'%'or trainName like @a+'%' or trainSource like @a+'%' or destination like @a+'%' or departureTime like @a+'%' or fare like @a+'%', ", sql);
                cmd.Parameters.AddWithValue("@a", data);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.Rows.Clear();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    /*  string trainID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                      string trainName = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                      string trainSource = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                      string destination = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                      string arrivalTime = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                      string departureTime = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                      string fare = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                      DataGridViewRow row1 = new DataGridViewRow();
                      row1.CreateCells(dataGridView1);
                      row1.Cells[0].Value = trainID;
                      row1.Cells[1].Value = trainName;
                      row1.Cells[2].Value = trainSource;
                      row1.Cells[3].Value = destination;
                      row1.Cells[4].Value = arrivalTime;
                      row1.Cells[5].Value = departureTime;
                      row1.Cells[6].Value = fare;
                      dataGridView1.Rows.Add(row1);*/
                    string trainID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string trainName = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    string trainSource = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    string destination = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    DateTime arrivalTime = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[4].ToString());
                    DateTime departureTime = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[5].ToString());
                    string fare = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                    DateTime arrivalDate = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[7].ToString());
                    DateTime departureDate = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[8].ToString());
                    DataGridViewRow row1 = new DataGridViewRow();
                    row1.CreateCells(dataGridView1);
                    row1.Cells[0].Value = trainID;
                    row1.Cells[1].Value = trainName;
                    row1.Cells[2].Value = trainSource;
                    row1.Cells[3].Value = destination;
                    row1.Cells[4].Value = arrivalDate.TimeOfDay;
                    row1.Cells[5].Value = arrivalTime.TimeOfDay;
                    row1.Cells[6].Value = departureDate.TimeOfDay;
                    row1.Cells[7].Value = departureTime.TimeOfDay;
                    row1.Cells[8].Value = fare;


                    dataGridView1.Rows.Add(row1);
                }
                sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Search function
            search();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            trainIdBox.Text = row.Cells[0].Value.ToString();
            trainNameBox.Text = row.Cells[1].Value.ToString();
            sourceBox.Text = row.Cells[2].Value.ToString();
            destinationBox.Text = row.Cells[3].Value.ToString();
            ArrivalDatepicker.Text = row.Cells[4].Value.ToString();
            arrivalTimePicker.Text = row.Cells[5].Value.ToString();
            DeparturedatePicker.Text = row.Cells[6].Value.ToString();
            departureTimePicker.Text = row.Cells[7].Value.ToString();
            fareBox.Text = row.Cells[8].Value.ToString();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text == null)
            {
                //if (e.KeyCode == Keys.Enter)
                // search();
                // search();
                populateData();         // populate the data in data grid view 
            }
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                // populateData();
                search();   // search function call
            //search();
        }

        private void trainNameBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                sourceBox.Focus();
        }


        private void trainIdBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                trainNameBox.Focus();
        }

        private void sourceBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                destinationBox.Focus();
        }

        private void destinationBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                arrivalTimePicker.Focus();
        }

        private void arrivalTimeBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                departureTimePicker.Focus();
        }

        private void departureTimeBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fareBox.Focus();
        }


        private void fareBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addButton.Focus();
        }

        private void trainIdBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
            }
        }

        private void trainsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trains train = new Trains();
            train.Show();
            this.Hide();
        }

        private void updateTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trains train = new Trains();
            train.Show();
            this.Hide();
        }

        private void removeTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trains train = new Trains();
            train.Show();
            this.Hide();
        }

        private void addNewPassengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Passenger p = new Passenger();
            p.Show();
            this.Hide();*/
        }

        private void updateExistingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*   Passenger p = new Passenger();
               p.Show();
               this.Hide();*/
        }

        private void unBookSeatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Passenger p = new Passenger();
             p.Show();
             this.Hide();*/
        }

        private void departureTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void arrivalTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Trains_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trainIdBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void trainIdBox_Validating(object sender, CancelEventArgs e)
        {
            if (trainIdBox.Text.Length != 5)
            {
                errorProvider1.SetError(trainIdBox, "Please enter a 5-digit number.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(trainIdBox, "");
            }
        }
    }
}
