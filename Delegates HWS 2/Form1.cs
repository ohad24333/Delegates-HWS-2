using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MechlalaDll;

namespace Delegates_HWS_7._10
{
    public partial class Form1 : Form
    {

        delegate void MyFirstDelegate();
        delegate void Greet(string name);
        delegate int MathTowNumbers(int a, int b);
        public Form1()
        {
            InitializeComponent();

            gridStudents.DataSource = StudentManager.GetStudentList();
        }

        #region Methods

        #region Print
    
        public static void Shalom()
        {
            MessageBox.Show("Shalom");
        }

        public static void Shalom2()
        {
            MessageBox.Show("Another Method Calls With Same Tipe Of Delegate");
        }

        public static void ShalomTo(string name)
        {
            MessageBox.Show("Shalom To " + name);
        }

        public static void WelcomeTo(string name)
        {
            MessageBox.Show("Welcome To " + name);
        }

        #endregion

        #region Math

        public static int Add(int num1,int num2)
        {
            return num1 + num2;
        }

        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }


        #endregion

        #endregion



        private void btnAdd_Click(object sender, EventArgs e)
        {
            MathTowNumbers mathAddDel = Add; 
            txtResult.Text = mathAddDel(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text)).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            MathTowNumbers mathSubDel = Sub;
            txtResult.Text = (mathSubDel(int.Parse(txtNum1.Text), int.Parse(txtNum2.Text))).ToString();
        }

        private void btnGradeUnder50Filter_Click(object sender, EventArgs e)
        {
            bool messege = StudentManager.Contain(Filters.FilterGradeUnder50);
            MessageBox.Show(messege.ToString());
        }

        private void btnFIrstLast_Click(object sender, EventArgs e)
        {
            bool messege = StudentManager.Contain(Filters.FirstNameAndLastNameAreSame);
            MessageBox.Show(messege.ToString());
        }

        private void btnSumDebts_Click(object sender, EventArgs e)
        {         
            MessageBox.Show((StudentManager.Sum(Filters.FilterDebt)).ToString());
        }

        private void btnSumPaid_Click(object sender, EventArgs e)
        {
            MessageBox.Show((StudentManager.Sum(Filters.FilterPaid)).ToString());
        }

        private void btnAgeAverage_Click(object sender, EventArgs e)
        {
            MessageBox.Show((StudentManager.Average(Filters.FilterAge)).ToString());

        }

        private void btnGradeAverage_Click(object sender, EventArgs e)
        {
            MessageBox.Show((StudentManager.Average(Filters.FilterGrade)).ToString());

        }
    }
}
