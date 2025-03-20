namespace AdditionCalc
{
    public partial class frmAddCalc : Form
    {
        //one dimensional array that stores operation history (addition)
        private string[] operationHistory = new string[10];

        //two dimensional array from DQ stores the calculations
        private double[,] calculations = new double[10,3];

        //tracks where to store the calculations
        private int calculationIndex = 0;
        public frmAddCalc()
        {
            InitializeComponent();
        }

        private void bttnCalculate_Click(object sender, EventArgs e)
        {
            //get the user input from both text boxes
            string input1 = txtInput1.Text;
            string input2 = txtInput2.Text;

            //converts input to doubles to perform calculations on them
            double num1 = Convert.ToDouble(input1);
            double num2 = Convert.ToDouble(input2);

            //changed the int to doubles so all data types match in the array
            double result = num1 + num2; //addition

            //displays the results in the label
            lblOutput.Text = "Sum: " + result.ToString();

            //stores in 2d array if theres enough space
            if (calculationIndex < 10)
            {
                operationHistory[calculationIndex] = "Addition"; //stores that addition was done
                calculations[calculationIndex, 0] = num1; //store first input
                calculations[calculationIndex, 1] = num2;//store second input
                calculations[calculationIndex, 2] = result; //store sum

                //adds both arrays together
                lstCalculations.Items.Add($"{operationHistory[calculationIndex]}: {calculations[calculationIndex, 0]} + {calculations[calculationIndex, 1]} + {calculations[calculationIndex, 2]}");
                 //adds to the next slot
                 calculationIndex++;
            } 
            //displays message if thers no more slots
            else
            {
                MessageBox.Show("Calculation history full!");
            }
        }
    }
}
