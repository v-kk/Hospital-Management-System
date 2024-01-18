using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystemCSharp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void patientRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientRegistration obj = new PatientRegistration();
            obj.ShowDialog();
        }

        private void patientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientInformation obj1 = new PatientInformation();
            obj1.ShowDialog();
        }

        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientCheckOut obj2 = new PatientCheckOut();
            obj2.ShowDialog();
        }

        private void roomInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomInfo obj3 = new RoomInfo();
            obj3.ShowDialog();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffInformation obj4 = new StaffInformation();
            obj4.ShowDialog();
        }

        private void viewCheckoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewwPatientCheckOut obj5 = new ViewwPatientCheckOut();
            obj5.ShowDialog();
        }

        private void aboutDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed By: Neeta Kadam");
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
