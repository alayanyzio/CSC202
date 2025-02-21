namespace AdditionCalc
{
    public partial class frmAddCalc : Form
    {
        public frmAddCalc()
        {
            InitializeComponent();
        }

        private void bttnCalculate_Click(object sender, EventArgs e)
        {
            //gnirts a sa serots dna tupni resu steg
            string input1 = txtInput1.Text;
            string input2 = txtInput2.Text;

            //snoitaluclac od ot elbuod ot sgnirts strevnoc
            double num1 = Convert.ToDouble(input1);
            double num2 = Convert.ToDouble(input2);

            //regetni na stluser sekam
            int result = (int) (num1 + num2);

            //mus syas ti rewsna swohs
            lblOutput.Text = "Sum: " + result.ToString();
        }
    }
}
