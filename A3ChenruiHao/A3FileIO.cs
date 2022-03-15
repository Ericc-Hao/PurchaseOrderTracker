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

namespace A3ChenruiHao
{
    public partial class A3FileIO : Form
    {
        StreamWriter writer;
        StreamReader reader;
        Boolean displayedOrNot = false;
        string inputPath = "";
        string path = @"C:\history\", file = "ChenruiHaoOrders.txt", pathAndFile;
        

        //Method for display the table
        //first add the title bar for the table and format as string
        //read file from path
        //add data raws from file and display table
        public void ShowOrders(string pathShow)
        {
            try
            {
                using (reader = new StreamReader(pathShow))
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Number", typeof(string));
                    table.Columns.Add("Date", typeof(string));
                    table.Columns.Add("Purchased From", typeof(string));
                    table.Columns.Add("Ship To", typeof(string));
                    table.Columns.Add("Ordered", typeof(string));
                    table.Columns.Add("Unit", typeof(string));
                    table.Columns.Add("Unit Price", typeof(string));
                    table.Columns.Add("Amount", typeof(string));
                    table.Columns.Add("Total Amount", typeof(string));
                    while (!reader.EndOfStream)
                    {
                        //read file store at record
                        //split record by " " into orders array
                        string record = reader.ReadLine();
                        string[] orders = record.Split('\t');
                        
                        string number = orders[0];
                        DateTime date = Convert.ToDateTime(orders[1]);
                        string purchasedFrom = orders[2];
                        string shipTo = orders[3];
                        string ordered = orders[4];
                        string unit = orders[5];
                        string unitPrice = orders[6];
                        string amount = orders[7];
                        string totalAmount = orders[8];
                        table.Rows.Add(number, date.ToString("dd MMM yyyy"), purchasedFrom, shipTo, ordered, unit, unitPrice, amount, totalAmount);
                    }
                    dgvDisplay.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                rtbMessages.Text = $"error reading file : {ex.Message}";
            }
        }

        //Method for check file exits or not if not create new file
        //check the path is null or empty
        //split path string by \ and the last index will be file name
        //make string folders to get directory
        //then check directory exists or not, if not create directory and file
        //if directory exists check file exists or not
        //if file not exists create file again
        //if both exits return true
        //then else errors occus return false
        public bool ExitsFileChecker(string path)
        {
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    string[] directory = path.Split(Path.DirectorySeparatorChar);
                    string folders = "";
                    for (int i = 0; i < directory.Length - 1; i++)
                    {
                        folders += directory[i] + Path.DirectorySeparatorChar;
                    }

                    if (!Directory.Exists(folders))
                    {
                        Directory.CreateDirectory(folders);
                        using (writer = new StreamWriter(path, true))
                        {

                        }
                        rtbMessages.Text += "File Not Exits, Creates New File\n";
                        return true;
                    }
                    else if (Directory.Exists(folders))
                    {
                        if (!File.Exists(path))
                        {
                            using(writer = new StreamWriter(path, true))
                            {

                            }
                            rtbMessages.Text += "File Not Exits, Creates New File\n";
                            return true;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                rtbMessages.Text += $"Error Finding File: {ex.Message}\n";
                return false;
            }
            
        }

        //Method for display button
        //Trim input path first
        //reset comments area
        //use ExitsFileChecker to check file exits or not
        //if file exits equals true
        //use display method to display table
        //and bool displayedOrNot equals true
        //next time press button will hide the table
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            inputPath = txtPath.Text;
            inputPath = inputPath.Trim();
            rtbMessages.Text = "Exceptions/Comments Area\n";
            if(ExitsFileChecker(inputPath) == true)
            {
                if(displayedOrNot == false)
                {
                    ShowOrders(inputPath);
                    displayedOrNot = true;
                }
                else
                {
                    displayedOrNot = false;
                    dgvDisplay.DataSource = "";
                }
            }

            
        }


        //Create or Open button
        //use method ExistsFileChecker
        //this method will create file if dont have
        //show table after create files
        private void btnCreateOrOpen_Click(object sender, EventArgs e)
        {
            inputPath = txtPath.Text;
            rtbMessages.Text = "Exceptions/Comments Area\n";
            if (rabOpen.Checked)
            {
                ExitsFileChecker(inputPath);
                rtbMessages.Text += "File Opened\n";
                ShowOrders(inputPath);
            }
            else if (rabCreate.Checked)
            {
                ExitsFileChecker(inputPath);
                rtbMessages.Text += "File Creates And Opened\n";
                ShowOrders(inputPath);
            }
        }

        //Empty File button
        //delete file if the file exits
        //and then ues exitsFilechecker to create a new file
        private void btnEmptyFile_Click(object sender, EventArgs e)
        {
            inputPath = txtPath.Text;
            rtbMessages.Text = "Exceptions/Comments Area\n";
            if (ExitsFileChecker(inputPath) == true)
            {
                File.Delete(inputPath);
                rtbMessages.Text += "File Emptys";
            }
            else
            {
                rtbMessages.Text += "Error Occurs\n";
            }
        }

        //Insert Method save the records to file
        //if no errors passed by insertValidation method
        //Convert to string format now
        //its easier when i needs to read this file
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string errors;
            rtbMessages.Text = "Exceptions/Comments Area\n";
            inputPath = txtPath.Text.Trim();
            double inputOrder;
            double inputPrice;
            double amount;
            double totalAmount;
            errors = InsertValidation();
            if(errors == "")
            {
                inputOrder = Convert.ToDouble(txtOrdered.Text.Trim());
                inputPrice = Convert.ToDouble(txtUnitPrice.Text.Trim());
                amount = inputOrder * inputPrice;
                totalAmount = amount * 1.13;
                string record = txtNumber.Text + "\t" +
                    dtpDate.Text + "\t" +
                    txtPurchsedFrom.Text + "\t" +
                    txtShip.Text + "\t" +
                    rtbDescription.Text + "\t" +
                    inputOrder.ToString() + "\t" +
                    cbbUnits.Text + "\t" +
                    inputPrice.ToString("c2") + "\t" +
                    amount.ToString("c2") + "\t" +
                    totalAmount.ToString("c2") + "\t";
                try
                {
                    ExitsFileChecker(inputPath);
                    using (writer = new StreamWriter(inputPath, true))
                    {
                        writer.WriteLine(record);
                        rtbMessages.Text = "record added";
                    }
                    ShowOrders(inputPath);
                }
                catch (Exception ex)
                {
                    rtbMessages.Text = $"Error Occurs: {ex.Message}";
                }
            }
            else
            {
                rtbMessages.Text += errors;
            }
        }

        //Close the form
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        // on load, see if the file and/or directory exists
        //if not exits, create one
        //and input path area shows default path
        private void A3FileIO_Load(object sender, EventArgs e)
        {
            pathAndFile = path + file;
            if (!string.IsNullOrEmpty(path))
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    using(writer = new StreamWriter(pathAndFile, true))
                    {

                    }
                }
            }
            txtPath.Text = pathAndFile;
        }

        //Delete Button
        //First storage the file
        //Rewrite the file, if find the delete item skip it
        //and write others into file
        private void btnDelete_Click(object sender, EventArgs e)
        {
            rtbMessages.Text = "Exceptions/Comments Area\n";
            inputPath = txtPath.Text.Trim();
            List<string> records = new List<string>();
            try
            {
                using (reader = new StreamReader(inputPath))
                {
                    while (!reader.EndOfStream)
                    {
                        records.Add(reader.ReadLine());
                    }
                }
                records.Sort();
            }
            catch (Exception ex)
            {
                rtbMessages.Text = $"exception reading file into archive: {ex.Message}";
                return;
            }

            Boolean foundDelete = false;
            try
            {
                using (writer = new StreamWriter(inputPath, false))
                {
                    foreach (var item in records)
                    {
                        if (item.StartsWith(txtDeleteNumber.Text + "\t"))
                            foundDelete = true;
                        else
                            writer.WriteLine(item);
                    }
                }
            }
            catch (Exception ex)
            {
                rtbMessages.Text = $"exception writing file back: {ex.Message}";
            }
            if (foundDelete == false) rtbMessages.Text += "Order Number not found";
            if (foundDelete == true) rtbMessages.Text += "Order Delete";
            ShowOrders(inputPath);
        }

        public A3FileIO()
        {
            InitializeComponent();
        }

        //Method for Insert Validations
        //Try convert order number to int, if faild alert error, focus on feild
        //If successed, check if greater or equal to zero, if not focus on feild alert error
        //if yes, check file contains item or not, if contains focus on feild alert error
        //Check datetime is not greater than today datetime
        //Check input text area is not null or empty if yes focus on first error feild and alert errors
        //check order number is not less or equal to zero and must be a number
        //check unit price is a double number
        //cause unit i only have unit 'hours', so unit must be hours
        //check unit is hours or not
        public string  InsertValidation()
        {

            inputPath = txtPath.Text.Trim();
            string errors = "";
            int inputNumber;
            int inputOrder;
            double inputUnitPrices;
            DateTime inputTime;

            if (Int32.TryParse(txtNumber.Text.Trim(), out inputNumber))
            {
                if (inputNumber <= 0)
                {
                    if(errors == "")
                    {
                        txtNumber.Focus();
                    }
                    errors += "Order Number needs greater than zero\n";
                }
                else
                {
                    List<string> record = new List<string>();
                    try
                    {
                        using(reader = new StreamReader(inputPath))
                        {
                            while (!reader.EndOfStream)
                            {
                                record.Add(reader.ReadLine());
                            }
                            record.Sort();
                            
                            foreach(var items in record)
                            {
                                if (items.StartsWith(txtNumber.Text + "\t"))
                                {
                                    if(errors == "")
                                    {
                                        txtNumber.Focus();
                                    }
                                    errors += "Order Number must be unique, re-enter number\n";
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        errors += $"Error Occurs:{ex.Message}";
                    }
                }
            }
            else
            {
                if (errors == "") txtNumber.Focus();
                errors += "Order Number must be Integers\n";
            }
            
            if(DateTime.TryParse(dtpDate.Text.Trim(), out inputTime))
            {
                if(inputTime > DateTime.Now)
                {
                    if(errors == "")
                    {
                        dtpDate.Focus();
                    }
                    errors += "Order Date cant in future dates\n";
                }
            }
            if (string.IsNullOrEmpty(txtPurchsedFrom.Text.Trim()))
            {
                if (errors == "")
                {
                    txtPurchsedFrom.Focus();
                }
                errors += "Enter Order Purchsed From\n";
            }
            if (string.IsNullOrEmpty(txtShip.Text.Trim()))
            {
                if (errors == "")
                {
                    txtShip.Focus();
                }
                errors += "Enter where order ship to\n";
            }
            if (string.IsNullOrEmpty(rtbDescription.Text.Trim()))
            {
                if (errors == "")
                {
                    rtbDescription.Focus();
                }
                errors += "Description is required\n";
            }
            else
            {
                
            }


            if (Int32.TryParse(txtOrdered.Text.Trim(), out inputOrder))
            {
                if(inputOrder <= 0)
                {
                    if(errors == "")
                    {
                        txtOrdered.Focus();
                    }
                    errors += "Order Number is required and be integer greater than zero\n";
                }
            }
            else
            {
                if (errors == "")
                {
                    txtOrdered.Focus();
                }
                errors += "Order Number is required and be integer\n";
            }

            if(cbbUnits.Text != "Hours")
            {
                errors += "Unit is required";
            }
            else
            {

            }

            if (Double.TryParse(txtUnitPrice.Text.Trim(), out inputUnitPrices))
            {
                if (inputUnitPrices <= 0)
                {
                    if (errors == "")
                    {
                        txtUnitPrice.Focus();
                    }
                    errors += "unit price is required and be integer greater than zero\n";
                }
            }
            else
            {
                if (errors == "")
                {
                    txtUnitPrice.Focus();
                }
                errors += "Unit price is required and be integer\n";
            }


            return errors;
        }
    }
}

