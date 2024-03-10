using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class Parkout : Form
    {

        public event EventHandler ParkingRecordAdded;
        public event EventHandler Parking;
        private string palteNum;
        public Parkout()
        {
            InitializeComponent();


        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Parkout_Load(object sender, EventArgs e)
        {
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();

            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];
                if (record.Status != "Cleared")
                {
                    ParkOutList POL = new ParkOutList(flowPanelVH, this, label4, label8);
                    POL.UpdateLabels(record);
                    POL.ParkingRecordAdded += ParkOutList_ParkingRecordAdded;
                    listOfVehicle.Controls.Add(POL);
                }
            }



        }
        private void ParkOutList_ParkingRecordAdded(object sender, EventArgs e)
        {

            Parking?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
        private void parkOutList1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listOfVehicle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public void getVHparkOut(string paltenum)
        {
            palteNum = paltenum;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();

            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];
                if (record.PlateNumber == palteNum)
                {
                    if (!double.TryParse(enterAmt.Text, out double amt))
                    {

                        MessageBox.Show("Invalid input. Please enter a valid numeric amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (amt >= record.Amount && (label4.Text != "") )
                    {
                        if (record.Status != "Cleared") {
                        change.Text = (amt - record.Amount).ToString(); // Calculate change
                        record.Status = "Cleared";
                        label8.Text = "Successfully paid the amount!";
                        label8.ForeColor = Color.LightGreen;
                        Parking?.Invoke(this, EventArgs.Empty);
                        listOfVehicle.Controls.Clear();
                        }else
                            MessageBox.Show("Already paid amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    else if (label4.Text == "")
                    {
                        MessageBox.Show("Cannot procced oparation please select a Vichle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("OOPS! Insufficient amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return;
                }
            }
        }






        private void button2_Click_1(object sender, EventArgs e)
        {
            Parking?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listOfVehicle.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();
            bool foundRecord = false;
            int count = 0;
            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];
                if (record.Status != "Cleared")
                {
                    ParkOutList POL = new ParkOutList(flowPanelVH, this, label4, label8);
                    POL.UpdateLabels(record);
                    POL.ParkingRecordAdded += ParkOutList_ParkingRecordAdded;
                    listOfVehicle.Controls.Add(POL);
                    count++;
                }
            }

            if (count == 0)
            {
                Label noResultsLabel = new Label();
                noResultsLabel.Text = "No results found.";
                listOfVehicle.Controls.Add(noResultsLabel);
            }

            flowPanelVH.Controls.Clear();
            label4.Text = "";
            label8.Text = "";
            change.Text = "";
            enterAmt.Text = "";
            searchVHTxt.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listOfVehicle.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();
            bool foundRecord = false;
            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];
                if (record.Status != "Cleared") {
                    if (record.PlateNumber.Contains(searchVHTxt.Text))
                    {
                        ParkOutList POL = new ParkOutList(flowPanelVH, this, label4, label8);
                        POL.UpdateLabels(record);
                        POL.ParkingRecordAdded += ParkOutList_ParkingRecordAdded;
                        listOfVehicle.Controls.Add(POL);
                        foundRecord = true;
                    }
                }

            }
            if (!foundRecord)
            {
                Label noResultsLabel = new Label();
                noResultsLabel.Text = "No results found.";
                listOfVehicle.Controls.Add(noResultsLabel);
            }
        }

        private void seeAll_Click(object sender, EventArgs e)
        {
            listOfVehicle.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();
            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];
                if (record.Status != "Cleared")
                {
                    ParkOutList POL = new ParkOutList(flowPanelVH, this, label4, label8);
                    POL.UpdateLabels(record);
                    POL.ParkingRecordAdded += ParkOutList_ParkingRecordAdded;
                    listOfVehicle.Controls.Add(POL);  
                }
            }
        }
    }
}
