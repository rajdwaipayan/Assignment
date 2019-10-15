using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehical
{
    public partial class VehicleAppPractice2 : Form
    {
        Vehical vehical =new Vehical();
        List<double> speeds=new List<double>();
        public VehicleAppPractice2()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            vehical.Name = nameTextBox.Text;
            vehical.RegistrationNo = regNoTextBox.Text;

            nameTextBox.Clear();
            regNoTextBox.Clear();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            speeds.Add(Convert.ToDouble(speedTextBox.Text));
            speedTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = vehical.Name;
            regNoTextBox.Text = vehical.RegistrationNo;
            minSpeedTextBox.Text = speeds.Min().ToString();
            maxSpeedTextBox.Text = speeds.Max().ToString();
            avgSpeedTextBox.Text = speeds.Average().ToString();
        }
    }
}
