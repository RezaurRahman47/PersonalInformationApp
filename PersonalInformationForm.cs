using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationApp
{
    public partial class PersonalInformationForm : Form
    {
        public PersonalInformationForm()
        {
            InitializeComponent();
        }

        private string firstName, lastName, fatherName, motherName, address;
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Please enter your first name!!!");
            }
            else if (lastNameTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Please enter your last name!!!");
            }

            else if (fatherNameTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Please enter your father's name!!!");
            }

            else if (motherNameTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Please enter your mother's name!!!");
            }

            else if (addressTextBox.Text.ToString() == "")
            {
                MessageBox.Show("Please enter your address!!!");
            }

            else
            {
                firstName = firstNameTextBox.Text;
                lastName = lastNameTextBox.Text;
                fatherName = fatherNameTextBox.Text;
                motherName = motherNameTextBox.Text;
                address = addressTextBox.Text;

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                fatherNameTextBox.Clear();
                motherNameTextBox.Clear();
                addressTextBox.Clear();
            }
        }

        private void showAllInformationButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            fatherNameTextBox.Text = fatherName;
            motherNameTextBox.Text = motherName;
            addressTextBox.Text = address;
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;

            fatherNameTextBox.Clear();
            motherNameTextBox.Clear();
            addressTextBox.Clear();

        }

        private void parentsNameButton_Click(object sender, EventArgs e)
        {
            fatherNameTextBox.Text = fatherName;
            motherNameTextBox.Text = motherName;

            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            addressTextBox.Clear();
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            addressTextBox.Text = address;

            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            fatherNameTextBox.Clear();
            motherNameTextBox.Clear();
        }
    }
}
