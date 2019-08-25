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
        double dblTotalDed;

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
            

            //dblTotalNetSalary;



        }

        

      




       
      
        private void BtnCalc_Click(object sender, EventArgs e)
        {
         
            dblRatePerHour = Convert.ToDouble(txtRatePerHour.Text);
            dblNumberofHourForRatePerHour = Convert.ToDouble(txtNumHrR.Text);
            double dblTotalrR = dblRatePerHour * dblNumberofHourForRatePerHour;

            txtTotalrR.Text = dblTotalrR.ToString();

            dblOverTime = Convert.ToDouble(txtOverTime.Text);
            dblNumberofHourForOverTimePerHour = Convert.ToDouble(txtNumHrOT.Text);
            double dblTotalrot = dblOverTime * dblNumberofHourForOverTimePerHour;

            txtTotalrOt.Text = dblTotalrot.ToString();

            dblRatePerHour = Convert.ToDouble(txtNumHrR.Text);
            dblOverTime = Convert.ToDouble(txtNumHrOT.Text);

            double dblTotalRS = dblRatePerHour + dblOverTime;
        
            txtTotalNumOfHour.Text = dblTotalRS.ToString();

            dblTotalrR = Convert.ToDouble(txtTotalrR.Text);
            dblTotalrot = Convert.ToDouble(txtTotalrOt.Text);

            double dblTotalSalaryPay = dblTotalrR + dblTotalrot;

            txtTotalSalaryPay.Text = dblTotalSalaryPay.ToString();


            EA();
        }
        private void EA()
        {
            txtSSS.Enabled = true;
            txtPhilHealth.Enabled = true;
            txtPagIbig.Enabled = true;
            txtGSIS.Enabled = true;
            txtOthers.Enabled = true;





        }

        private void BtnCalc2_Click(object sender, EventArgs e)
        {
            double dblTotalsalaryPay2;


            dblSSS = Convert.ToDouble(txtSSS.Text);
            dblPhilHealth = Convert.ToDouble(txtPhilHealth.Text);
            dblPagIbig = Convert.ToDouble(txtPagIbig.Text);
            dblGsid = Convert.ToDouble(txtGSIS.Text);
           // dblOthers = Convert.ToDouble(txtOthers.Text);
            dblTotalDed = Convert.ToDouble(txtSavings.Text);
            dblTotalsalaryPay2 = Convert.ToDouble(txtTotalSalaryPay);

            double dblTempTotalDed = dblSSS + dblPhilHealth + dblPagIbig + dblGsid + dblOthers;

            txtSavings.Text = dblTempTotalDed.ToString();

            dblTotalNetSalary = dblTotalsalaryPay2 - dblTempTotalDed;

            txtTotalNetSalary.Text = dblTotalNetSalary.ToString();
            
            

        }
    }
}
