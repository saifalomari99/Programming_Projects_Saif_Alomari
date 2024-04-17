using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;



namespace Validate_regular_expressions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //when you click the validate button: 
        private void button1_Click(object sender, EventArgs e)
        {
            int clickCount = 0;
            clickCount++;

            //--------------------------- (Last Name) -----------------------------------
            Regex lastNameExpressions = new Regex(@"[A-Z][A-Za-z]+");
            bool IsLastName;
            //check if it matches:
            if (lastNameExpressions.IsMatch(LastNameTextBox.Text))
            {
                IsLastName = true;
            }
            else
            {
                IsLastName = false;
            }

            //show error message if it does not match:
            if (IsLastName == false)
            {
                MessageBox.Show("Invalid Last Name, Please re-enter the last name\nand Validate again", "Error detected", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            //--------------------------- (First Name) -----------------------------------
            Regex firstNameExpressions = new Regex(@"[A-Z][A-Za-z]+");
            bool IsFirstName;
            //check if it matches:
            if (firstNameExpressions.IsMatch(FirstNameTextBox.Text))
            {
                IsFirstName= true;
            }
            else
            {
                IsFirstName = false;
            }
            //show error message if it does not match:
            if (IsFirstName == false)
            {
                MessageBox.Show("Invalid First Name, Please re-enter the first name\nand Validate again", "Error detected", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       

            //--------------------------- (Address) -----------------------------------
            Regex addressExpressions = new Regex(@"[0-9]+ [A-Za-z]+");
            bool IsValidAddress;
            //check if it matches:
            if (addressExpressions.IsMatch(AddressTextBox.Text))
            {
                IsValidAddress = true;
            }
            else
            {
                IsValidAddress = false;
            }
            //show error message if it does not match:
            if (IsValidAddress == false)
            {
                MessageBox.Show("Invalid Address, Please re-enter the address\nand Validate again", "Error detected", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //------------------------------ (City) -----------------------------------
            Regex cityExpressions = new Regex(@"[A-Z][A-Za-z]+");
            bool IsCity;
            //check if it matches:
            if (cityExpressions.IsMatch(CityTextBox.Text))
            {
                IsCity = true;
            }
            else
            {
                IsCity= false;
            }
            //show error message if it does not match
            if (IsCity == false)
            {
                MessageBox.Show("Invalid city entery, Please re-enter the city\nand Validate again", "Error detected", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //------------------------------ (State) -------------------------------------
            Regex stateExpressions = new Regex(@"[A-Z][A-Za-z]+");
            bool isValidState;
            if (stateExpressions.IsMatch(StateTextBox.Text))
            {
                isValidState = true;
            }
            else
            {
                isValidState = false;
            }
            if (isValidState == false)
            {
                MessageBox.Show("Invalid State entery, Please re-enter the state\nand Validate again", "Error detected", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //------------------------------ (Zip Code) ----------------------------------
            Regex zipCodeExpressions = new Regex(@"[0-9]{5}|[0-9]{5}-*[0-9]{4}");
            bool IsValidZipCode;
            if (zipCodeExpressions.IsMatch(ZipCodeTextBox.Text))
            {
                IsValidZipCode = true;
            }
            else
            {
                IsValidZipCode = false;
            }
            if (IsValidZipCode == false)
            {
                MessageBox.Show("Invalid Zip Code, Please re-enter the zip code\nand Validate again", "Error detected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //------------------------------ (Phone Number) ------------------------------
            Regex PhoneExpressions = new Regex(@"[0-9]{3}-*[0-9]{3}-*[0-9]{4}");
            bool IsPhone;
            if (PhoneExpressions.IsMatch(PhoneTextBox.Text))
            {
                IsPhone = true;
            }
            else
            {
                IsPhone = false;
            }
            if (IsPhone == false)
            {
                MessageBox.Show("Invalid Phone number, Please re-enter the phone number\nand Validate again", "Error detected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //If everything is valid, then show the thank you message to the user:
            if (IsLastName && IsFirstName && IsValidAddress && IsCity && isValidState && IsValidZipCode && IsPhone)
            {
                //get the data
                string theLastName = LastNameTextBox.Text;
                string theFirstName = FirstNameTextBox.Text;
                string theAddress = AddressTextBox.Text;
                string theCity = CityTextBox.Text;
                string theState = StateTextBox.Text;
                string theZipCode = ZipCodeTextBox.Text;
                string thePhoneNumber = PhoneTextBox.Text;


                /*int theZipCode = Convert.ToInt64(ZipCodeTextBox.Text);
                //take off the dash (-) if the phone number has it
                string Phonestr = PhoneTextBox.Text;
                Phonestr= Regex.Replace(Phonestr, "-","");
                int thePhoneNumber = Convert.ToInt32(Phonestr);*/

                //transfer the data to the next form:
                ConfirmWindow newForm = new ConfirmWindow();        
                newForm.SetPerson(theLastName, theFirstName, theAddress, theCity, theState, theZipCode, thePhoneNumber);

                newForm.Show();               
            }



        }//end clicking event
    }//end class
}
