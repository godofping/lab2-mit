using System;
using System.Windows.Forms;

namespace lab2_anualSalary
{
    public partial class Form1 : Form
    {

        int iID;
        String strlastName;
        String strFirstName;
        String strMiddleInitial;
        String strAddress;
        int iContactNumber;

        double dblRatePerHour;
        double dblTotalNumberOfHour;
        double dblOverTime;
        double dblTotalSalaryPay;

        double dblNumberofHourForRatePerHour;
        double dblNumberofHourForOverTimePerHour;



        double dblSSS;
        double dblPagIbig;
        double dblPhilHealth;
        double dblGsid;
        double dblOthers;
        double dblSavings;

        double dblTotalNetSalary;




        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            iID = Convert.ToInt32(txtEmployeeID.Text);
            strlastName = txtLastName.Text;
            strFirstName = txtFirstName.Text;
            strMiddleInitial = txtMiddleInitial.Text;
            strAddress = txtAddress.Text;
            iContactNumber = Convert.ToInt32(txtContactNumber.Text);


            dblOverTime = Convert.ToDouble(txtOverTime.Text);
            dblTotalSalaryPay = Convert.ToDouble(txtTotalSalaryPay.Text);
            dblTotalNumberOfHour = Convert.ToDouble(txtTotalNumOfHour.Text);
            dblSSS = Convert.ToDouble(txtSSS.Text);
            dblPagIbig = Convert.ToDouble(txtPhilHealth.Text);
            dblPhilHealth = Convert.ToDouble(txtPhilHealth.Text);
            dblGsid = Convert.ToDouble(txtGSIS.Text);
            dblOthers = Convert.ToDouble(txtOthers.Text);
            dblSavings = Convert.ToDouble(txtSavings.Text);

            //dblTotalNetSalary;








        }

        private void TxtNumHrR_TextChanged(object sender, EventArgs e)
        {
            double dblTotalrR;
            dblRatePerHour = Convert.ToDouble(txtRatePerHour.Text);
            dblNumberofHourForRatePerHour = Convert.ToDouble(txtNumHrR.Text);

            if (txtNumHrR.Text.Equals(""))
            { txtNumHrR.Text = "0"; }
            if (txtRatePerHour.Text.Equals(""))
            { txtNumHrR.Text = "0"; }
            dblTotalrR = dblRatePerHour * dblNumberofHourForRatePerHour;

            txtTotalrR.Text = dblTotalrR.ToString("0.00");

        }
    }
}
