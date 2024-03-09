using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{

    public partial class parkinList : UserControl
    {
        public event EventHandler ItemRemoved;
        edit edt;
        public parkinList()
        {
            InitializeComponent();

        }

        private void parkinList_Load(object sender, EventArgs e)
        {

        }

        public void UpdateLabels(ParkingRecord parkRecord)
        {
            label1.Text = parkRecord.PlateNumber;
            label2.Text = parkRecord.Type;
            label3.Text = parkRecord.Status;
            label4.Text = parkRecord.DepartureDate ;
          
            label7.Text = parkRecord.ArrivalDate;
            label8.Text = parkRecord.ArrivalTime;
            label9.Text = parkRecord.Hours.ToString();
            label10.Text = parkRecord.Amount.ToString();
            label11.Text = parkRecord.Model;
            label12.Text = parkRecord.DepartureTime;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void parkinList_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();

            foreach (var record in allParkingRecords)
            {
                if (string.Equals(record.PlateNumber, label1.Text))
                {
                    // Remove the record from the manager
                    parkingRecordsManager.RemoveParkingRecord(record);
                    MessageBox.Show($"Record with PlateNumber {record.PlateNumber} removed.");

                    // Remove the UserControl from the flowLayoutPanel2
                    Parent.Controls.Remove(this);

                    // Notify the parent that an item is removed
                    ItemRemoved?.Invoke(this, EventArgs.Empty);

                    break;
                }
            }




        }

      
        private void EditSelectedRecord()
        {
            edt = new edit();
        
            edt.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
         
           

        }
    }
}
