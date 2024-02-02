namespace WindowApp_tm
{
    public partial class Form1 : Form
    {
        int FirstNumber;
        int SecondNumber;
        int Total;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void myMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New app on Desktop");
        }
        
        //private void btnSum_Click(object sender, EventArgs e)
        //{
        //    int a, b;
        //    a = Convert.ToInt32(txtFirstInput.Text);
        //    b = Convert.ToInt32(txtSecondInput.Text);
        //    txtDisplay.Text = (a + b).ToString();
        //}

        private void btn1_Click(object sender, EventArgs e)
        {
            //if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            //{
            //    txtDisplay.Text = "1";
            //}
            //else
            //{
            //    txtDisplay.Text = txtDisplay.Text + "1";

            //}
            txtDisplay.Text = txtDisplay.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            //{
            //    txtDisplay.Text = "2";
            //}
            //else
            //{
            //    txtDisplay.Text = txtDisplay.Text + "2";
            //}
            txtDisplay.Text = txtDisplay.Text + "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            //{
            //    txtDisplay.Text = "3";
            //}
            //else
            //{
            //    txtDisplay.Text = txtDisplay.Text + "3";
            //}
            txtDisplay.Text = txtDisplay.Text + "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            //{
            //    txtDisplay.Text = "4";
            //}
            //else
            //{
            //    txtDisplay.Text = txtDisplay.Text + "4";
            //}
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
           
                txtDisplay.Text = txtDisplay.Text + "0";
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + ".";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            //FirstNumber = Convert.ToDouble(txtDisplay.Text);
            SecondNumber = Convert.ToInt32(txtDisplay.Text);
            if (Operation=="+") 
            {
                
                Total = FirstNumber + SecondNumber;
              
            }
            

            
            if (Operation == "-")
            {
                Total = FirstNumber - SecondNumber;
            }

           // txtDisplay.Text = Total.ToString();

            if (Operation== "*")
            {
                Total = FirstNumber * SecondNumber;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    txtDisplay.Text = "Can not divide by zero";
                }
                else
                {
                    Total = FirstNumber/SecondNumber;
                }
            }
            txtDisplay.Text = Total.ToString();




        }

        

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Operation="+";
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Operation = "-";
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Operation = "*";
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Operation = "/";
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
        }

       
    }
}
