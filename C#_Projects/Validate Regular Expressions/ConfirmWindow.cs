using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validate_regular_expressions
{
    public partial class ConfirmWindow : Form
    {
        //7 data
        public string lastName;
        public string firstName;
        public string address;
        public string city;
        public string state;
        public string zipCode;
        public string phoneNumber;

        //---- method to set the info of the person 
        public void SetPerson(string Last, string First, string Address, string City, string State, string Zip, string Phone)
        {
            lastName = Last;
            firstName = First;
            address = Address;
            city = City;
            state = State;
            zipCode = Zip;
            phoneNumber = Phone;
        }

        public ConfirmWindow()
        {
            InitializeComponent();
        }

        private void ConfirmWindow_Load(object sender, EventArgs e)
        {
            nameLabel.Text = nameLabel.Text + " " + lastName + ", " + firstName  ;
            addressLabel.Text = addressLabel.Text + " " + address + ", " + city + ", " + state + " " + zipCode;
            phoneLabel.Text = phoneLabel.Text + " " + phoneNumber;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
