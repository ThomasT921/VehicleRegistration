using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TT_Final_Project
{
    public partial class mainForm : Form
    {
        // creating a list for the the inherited class objects to be stored
        List<Vehicle> vehicleList = new List<Vehicle>();
        public mainForm()
        {
            InitializeComponent();
        }
        //exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            // writing to a file to delete the contents
            StreamWriter rewrite = new StreamWriter("vehicles.txt");
            rewrite.Close();
            //goes through the vehicle list
            for (int i = 0; i<vehicleList.Count; i++)
            {
                //indexing the selected vehicle
                var selectedVehicle = vehicleList[i];
                //if the type is a Truck
                if(selectedVehicle.vehicleType == "Truck")
                {
                    //pushes the selected vehicle to the truck class.
                    var truck = vehicleList[i] as Truck;

                    // listing the properties of the object
                    string[] truckLines = {truck.vehicleVin, truck.truckMake, truck.truckModel, truck.vehicleYear,
                    truck.vehicleMilage, truck.vehicleColor, truck.vehicleTrans, truck.truckEngine, truck.truckDrive, truck.truckStyle, truck.truckSize,truck.vehicleType};

                    // appending the file to add the selected vehicle
                    using (StreamWriter file = new StreamWriter("vehicles.txt", append: true))
                    {
                        // going through the properties
                        for (int x = 0; x < truckLines.Length; x++)
                        {
                            //writing each property of the truck
                            file.WriteLine(truckLines[x]);
                        }
                        file.WriteLine("\n");
                    }
                }
                //if the type is a Car
                if (selectedVehicle.vehicleType == "Car")
                {
                    //pushes the selected vehicle to the Car class.
                    var car = vehicleList[i] as Car;
                   
                    // listing the properties of the object
                    string[] carLines = {car.vehicleVin, car.carMake, car.carModel, car.vehicleYear,
                    car.vehicleMilage, car.vehicleColor, car.vehicleTrans, car.carEngine, car.carDrive, car.carStyle, car.vehicleType};
                    
                    // appending the file to add the selected vehicle
                    using (StreamWriter file = new StreamWriter("vehicles.txt", append: true))
                    {
                        // going through the properties
                        for (int x = 0; x < carLines.Length; x++)
                        {
                            //writing each property of the Car
                            file.WriteLine(carLines[x]);
                        }
                        file.WriteLine("\n");
                    }
                }
                //if the type is a Suv
                if (selectedVehicle.vehicleType == "Suv")
                {
                    //pushes the selected vehicle to the Suv class.
                    var suv = vehicleList[i] as Suv;

                    // listing the properties of the object
                    string[] suvLines = {suv.vehicleVin, suv.suvMake, suv.suvModel, suv.vehicleYear,
                    suv.vehicleMilage, suv.vehicleColor, suv.vehicleTrans, suv.suvEngine, suv.suvDrive, suv.suvStyle, suv.suvSeats, suv.vehicleType};

                    // appending the file to add the selected vehicle
                    using (StreamWriter file = new StreamWriter("vehicles.txt", append: true))
                    {
                        // going through the properties
                        for (int x = 0; x < suvLines.Length; x++)
                        {
                            //writing each property of the Suv
                            file.WriteLine(suvLines[x]);
                        }
                        file.WriteLine("\n");
                    }
                }
            }
            // closing the file
            this.Close();
        }
        //clear button - clears inputs
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVin.Text = "";
            txtTrans.Text = "";
            txtMilage.Text = "";
            txtColor.Text = "";
            txtYear.Text = "";
            rbCar.Checked = false;
            rbSuv.Checked = false;
            rbTruck.Checked = false;
        }
        //add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Validating all of the text inputs to make sure they enter atleast one character. 
            if (txtVin.Text.Length < 1)
            {
                MessageBox.Show("Please enter a vin number.");
            }
            if (txtTrans.Text.Length < 1)
            {
                MessageBox.Show("Please enter what transmission the vehicle has.");
            }
            if (txtMilage.Text.Length < 1)
            {
                MessageBox.Show("Please enter the milage of the vehicle.");
            }
            if (txtColor.Text.Length < 1)
            {
                MessageBox.Show("Please enter the color of the vehicle.");
            }
            if (txtYear.Text.Length < 1)
            {
                MessageBox.Show("Please enter the year of the vehicle.");
            }
            ///////////////////////////////////////////////////////////////////////////////////
            // Checks to see which radio button is checked and open the form for that class
            if (rbCar.Checked)
            {
                carForm cF = new carForm();
                Car newCar = new Car();
                cF.ShowDialog();
                newCar.carMake = cF.txtCarMake.Text;
                newCar.carModel = cF.txtCarModel.Text;
                newCar.carEngine = cF.txtCarEngine.Text;
                newCar.carDrive = cF.txtCarDrive.Text;
                newCar.carStyle = cF.txtCarStyle.Text;
                newCar.vehicleColor = txtColor.Text;
                newCar.vehicleMilage = txtMilage.Text;
                newCar.vehicleTrans = txtTrans.Text;
                newCar.vehicleVin = txtVin.Text;
                newCar.vehicleYear = txtYear.Text;
                newCar.vehicleType = "Car";
                vehicleList.Add(newCar);
                listBVehicles.Items.Add(newCar.vehicleVin);
                newCar = new Car();
            }
            else if (rbSuv.Checked)
            {
                SuvForm sF = new SuvForm();
                Suv newSuv = new Suv();
                sF.ShowDialog();
                newSuv.suvMake = sF.txtSuvMake.Text;
                newSuv.suvModel = sF.txtSuvModel.Text;
                newSuv.suvEngine = sF.txtSuvEngine.Text;
                newSuv.suvDrive = sF.txtSuvDrive.Text;
                newSuv.suvSeats = sF.txtSuvSeats.Text;
                newSuv.suvStyle = sF.txtSuvStyle.Text;
                newSuv.vehicleColor = txtColor.Text;
                newSuv.vehicleMilage = txtMilage.Text;
                newSuv.vehicleTrans = txtTrans.Text;
                newSuv.vehicleVin = txtVin.Text;
                newSuv.vehicleYear = txtYear.Text;
                newSuv.vehicleType = "Suv";
                vehicleList.Add(newSuv);
                listBVehicles.Items.Add(newSuv.vehicleVin);
                newSuv = new Suv();
            }
            else if (rbTruck.Checked)
            {
                TruckForm tF = new TruckForm();
                Truck newTruck = new Truck();
                tF.ShowDialog();
                newTruck.truckMake = tF.txtTruckMake.Text;
                newTruck.truckModel = tF.txtTruckModel.Text;
                newTruck.truckEngine = tF.txtTruckEngine.Text;
                newTruck.truckDrive = tF.txtTruckDrive.Text;
                newTruck.truckStyle = tF.txtTruckStyle.Text;
                newTruck.truckSize = tF.txtTruckSize.Text;
                newTruck.vehicleColor = txtColor.Text;
                newTruck.vehicleMilage = txtMilage.Text;
                newTruck.vehicleTrans = txtTrans.Text;
                newTruck.vehicleVin = txtVin.Text;
                newTruck.vehicleYear = txtYear.Text;
                newTruck.vehicleType = "Truck";
                vehicleList.Add(newTruck);
                listBVehicles.Items.Add(newTruck.vehicleVin);
                newTruck = new Truck();
            }
            else
            {
                MessageBox.Show("Please selecte either Car, Truck or Suv.");
            }
            //after if reads the inputs it clears the inputs
            txtVin.Text = "";
            txtTrans.Text = "";
            txtMilage.Text = "";
            txtColor.Text = "";
            txtYear.Text = "";
            rbCar.Checked = false;
            rbSuv.Checked = false;
            rbTruck.Checked = false;
        }
        //delete button
        //Deletes the selected item out of both lists
        private void btnDel_Click(object sender, EventArgs e)
        {
            //gets selected index
            int index;
            index = listBVehicles.SelectedIndex;
            //removes from listbox
            listBVehicles.Items.Remove(listBVehicles.SelectedItem);
            //removes from object list
            vehicleList.Remove(vehicleList[index]);
        }
        //info button
        //gets the information from the objects that have been stored
        private void btnInfo_Click(object sender, EventArgs e)
        {
            //gets selection
            int index;
            index = listBVehicles.SelectedIndex;
            //opens display info
            DisplayForm dF = new DisplayForm();
            try
            {
                //if selection is a truck object it displays the truck properties
                var selectedVehicle = vehicleList[index] as Truck;
                dF.lblDisplay.Text = 
                    "Vehicle Vin: " + selectedVehicle.vehicleVin + 
                    "\n" + "Vehicle Make: " + selectedVehicle.truckMake + 
                    "\n" + "Vehicle Model: " + selectedVehicle.truckModel + 
                    "\n" +"Vehicle Year:" + selectedVehicle.vehicleYear + 
                    "\n" + "Vehicle Milage: " + selectedVehicle.vehicleMilage +
                    "\n" + "Vehicle Color: " + selectedVehicle.vehicleColor +
                    "\n" + "Vehicle Transmission: " + selectedVehicle.vehicleTrans +
                    "\n" + "Vehicle Engine: " + selectedVehicle.truckEngine +
                    "\n" + "Vehicle Drivetrain: " + selectedVehicle.truckDrive +
                    "\n" + "Vehicle Style: " + selectedVehicle.truckStyle +
                    "\n" + "Vehicle Size: " + selectedVehicle.truckSize;
            }
            catch
            {

            }
            try
            {
                //if selection is a Car object it displays the Car properties
                var selectedVehicle = vehicleList[index] as Car;
                dF.lblDisplay.Text =
                    "Vehicle Vin: " + selectedVehicle.vehicleVin +
                    "\n" + "Vehicle Make: " + selectedVehicle.carMake +
                    "\n" + "Vehicle Model: " + selectedVehicle.carModel +
                    "\n" + "Vehicle Year:" + selectedVehicle.vehicleYear +
                    "\n" + "Vehicle Milage: " + selectedVehicle.vehicleMilage +
                    "\n" + "Vehicle Color: " + selectedVehicle.vehicleColor +
                    "\n" + "Vehicle Transmission: " + selectedVehicle.vehicleTrans +
                    "\n" + "Vehicle Engine: " + selectedVehicle.carEngine +
                    "\n" + "Vehicle Drivetrain: " + selectedVehicle.carDrive +
                    "\n" + "Vehicle Style: " + selectedVehicle.carStyle;
            }
            catch
            {

            }
            try
            {
                //if selection is a SUV object it displays the SUV properties
                var selectedVehicle = vehicleList[index] as Suv;
                dF.lblDisplay.Text = 
                    "Vehicle Vin: " + selectedVehicle.vehicleVin +
                    "\n" + "Vehicle Make: " + selectedVehicle.suvMake +
                    "\n" + "Vehicle Model: " + selectedVehicle.suvModel +
                    "\n" + "Vehicle Year:" + selectedVehicle.vehicleYear +
                    "\n" + "Vehicle Milage: " + selectedVehicle.vehicleMilage +
                    "\n" + "Vehicle Color: " + selectedVehicle.vehicleColor +
                    "\n" + "Vehicle Transmission: " + selectedVehicle.vehicleTrans +
                    "\n" + "Vehicle Engine: " + selectedVehicle.suvEngine +
                    "\n" + "Vehicle Drivetrain: " + selectedVehicle.suvDrive +
                    "\n" + "Vehicle Style: " + selectedVehicle.suvStyle +
                    "\n" + "Vehicle Seats: " + selectedVehicle.suvSeats;
            }
            catch
            {

            }
            // after if finds what object it is, it opens the form
            dF.ShowDialog();
        }
        // on load
        // reads in the file to keep the data from vehicles previously added
        private void Form1_Load(object sender, EventArgs e)
        {
            //making a lsit to read the lines in the file
            List<string> lineList = new List<string>();
            //making a list for the linelist to go into
            List<List<string>> listList = new List<List<string>>();
            try
            {
                // holding the lines from the files
                string[] lines = File.ReadAllLines("vehicles.txt");
                //goes through the lines on the linelist
                foreach(string line in lines)
                {
                    // when the line isn't empty
                    if (line != "")
                    {
                        //it adds that line to the linelist
                        lineList.Add(line);
                    }
                    // if the line is the type of vehicle
                    if (line == "Car" || line == "Truck" || line == "Suv")
                    {
                        //adds the linelist to a linelist
                        listList.Add(lineList);
                        //creates a new list for more groups of lines
                        lineList = new List<string>();
                    }
                }
                //goes through each lists in the linelists
                foreach(var sublist in listList)
                {
                    //counts the amount of lists in the linelists
                    int listAmount = sublist.Count;
                    //checks the list for the line that is the vehicle type
                    if (sublist[listAmount - 1] == "Truck")
                    {
                        //puts the list items into the class as an object
                        Truck truck = new Truck();
                        truck.vehicleVin = sublist[0];
                        truck.truckMake = sublist[1];
                        truck.truckModel = sublist[2];
                        truck.vehicleYear = sublist[3];
                        truck.vehicleMilage = sublist[4];
                        truck.vehicleColor = sublist[5];
                        truck.vehicleTrans = sublist[6];
                        truck.truckEngine = sublist[7];
                        truck.truckDrive = sublist[8];
                        truck.truckStyle = sublist[9];
                        truck.truckSize = sublist[10];
                        truck.vehicleType = sublist[11];
                        //adds it to both lists to be written and selected
                        vehicleList.Add(truck);
                        listBVehicles.Items.Add(truck.vehicleVin);
                    }
                    //checks the list for the line that is the vehicle type
                    if (sublist[listAmount - 1] == "Car")
                    {
                        //puts the list items into the class as an object
                        Car car = new Car();
                        car.vehicleVin = sublist[0];
                        car.carMake = sublist[1];
                        car.carModel = sublist[2];
                        car.vehicleYear = sublist[3];
                        car.vehicleMilage = sublist[4];
                        car.vehicleColor = sublist[5];
                        car.vehicleTrans = sublist[6];
                        car.carEngine = sublist[7];
                        car.carDrive = sublist[8];
                        car.carStyle = sublist[9];
                        car.vehicleType = sublist[10];
                        //adds it to both lists to be written and selected
                        vehicleList.Add(car);
                        listBVehicles.Items.Add(car.vehicleVin);
                    }
                    //checks the list for the line that is the vehicle type
                    if (sublist[listAmount - 1] == "Suv")
                    {
                        //puts the list items into the class as an object
                        Suv suv = new Suv();
                        suv.vehicleVin = sublist[0];
                        suv.suvMake = sublist[1];
                        suv.suvModel = sublist[2];
                        suv.vehicleYear = sublist[3];
                        suv.vehicleMilage = sublist[4];
                        suv.vehicleColor = sublist[5];
                        suv.vehicleTrans = sublist[6];
                        suv.suvEngine = sublist[7];
                        suv.suvDrive = sublist[8];
                        suv.suvStyle = sublist[9];
                        suv.suvSeats = sublist[10];
                        suv.vehicleType = sublist[11];
                        //adds it to both lists to be written and selected
                        vehicleList.Add(suv);
                        listBVehicles.Items.Add(suv.vehicleVin);
                    }
                }
            }
            catch
            {

            }
        }
    }
}
