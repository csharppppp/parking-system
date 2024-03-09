﻿    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Parking
    {
    public partial class Parkin : UserControl
    {


        ParkingEntry pe1;
        Parkout pOut;
        public Parkin()
        {
            InitializeComponent();
            //  display();
            filterDisplay("PARKED");
            numV.Text = countVehicle() + "";
        }




        private void Parkin_Load(object sender, EventArgs e)
        {

        }



        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;

                if (sidebar.Width <= 68)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                }
            }
            else
            {
                sidebar.Width += 10;

                if (sidebar.Width >= 200)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();


                }
            }
        }
        bool menuExpand = true;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 280)
                {
                    menuTransition.Stop();
                    menuExpand = true;

                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 65)
                {
                    menuTransition.Stop();
                    menuExpand = false;

                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void humBtn_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pe1 = new ParkingEntry(flowLayoutPanel2);
            pe1.ParkingRecordAdded += ParkingRecordAddedHandler;
            pe1.ShowDialog();
        }

        private void ParkingRecordAddedHandler(object sender, EventArgs e)
        {
            display(); // Update the display when a new parking record is added
            numV.Text = countVehicle()+"";
        }



        private void parkout_Click(object sender, EventArgs e)
        {

            pOut = new Parkout();
            pOut.Parking += ParkingRecordAddedHandler;
            pOut.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Click(object sender, EventArgs e)
        {
        }

        public void display()
        {
            flowLayoutPanel2.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();

            foreach (var record in allParkingRecords)
            {

                parkinList pL = new parkinList();
                pL.UpdateLabels(record);
                flowLayoutPanel2.Controls.Add(pL);

            }
        }
        public void filterDisplay(string category)
        {
            flowLayoutPanel2.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();

            foreach (var record in allParkingRecords)
            {
                if (record.Status == category)
                {
                    parkinList pL = new parkinList();
                    pL.UpdateLabels(record);
                    flowLayoutPanel2.Controls.Add(pL);
                }
                else if (category == "ALL")
                {
                    parkinList pL = new parkinList();
                    pL.UpdateLabels(record);
                    flowLayoutPanel2.Controls.Add(pL);
                }
            }
        }

        private void btnCleared_Click(object sender, EventArgs e)
        {
            filterDisplay("Cleared");
        }

        private void btnParked_Click(object sender, EventArgs e)
        {
            filterDisplay("PARKED");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            filterDisplay("ALL");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();
            bool foundRecord = false;
            foreach (var record in allParkingRecords)
            {
                if (record.PlateNumber.Contains(searchVH.Text))
                {
                    parkinList pL = new parkinList();
                    pL.UpdateLabels(record);
                    flowLayoutPanel2.Controls.Add(pL);
                    foundRecord = true;
                }
            }
            if (!foundRecord)
            {
                Label noResultsLabel = new Label();
                noResultsLabel.Text = "No results found.";
                noResultsLabel.ForeColor = Color.White;
                flowLayoutPanel2.Controls.Add(noResultsLabel);
            }
        }

        private int countVehicle() {
           
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            return parkingRecordsManager.GetAllParkingRecords().Count;
           
        }



        private void numV_Click(object sender, EventArgs e)
        {

        }
    }
}
