using System.Diagnostics.Eventing.Reader;

namespace Catapult2
{
    public partial class frmCatapult : Form
    {
        public frmCatapult()
        {
            InitializeComponent(); //initializes all components (had to manually set)

        }
        //Event handler for test button
        private void btnTest_Click(object sender, EventArgs e)
        {
            //get user input and store as a string
            string inputStr = txtInput.Text;
            int inputNumber; //stores as an integer

            //validate input is the intended range of numbers
            {
                if (int.TryParse(inputStr, out inputNumber) && ValidateInput(inputNumber))
                    lblResults.Text = DisplayMessage(inputNumber); //displays appropriate message based on the user's input

                else
                    //message for invalid input
                    lblResults.Text = "Invalid Input.";
            }
        }
        
        //function that validates input is 1-10
        private bool ValidateInput(int number)
        {
            return number >= 1 && number <= 10;
        }
        //function to display messages based on number entered
        private string DisplayMessage(int number)
        {
            if (number >= 1 && number <= 3)
                return "Not Far Enough!"; //indicates that 1, 2, and 3 didn't launch the catapult far enough
            else if (number >= 4 && number <= 6)
                return "Perfect!"; //indicates that 4, 5, and 6 are the intended launch distance
            else if (number >= 7 && number <= 10)
                return "Too Far!"; //indicates that 7, 8, 9, and 10 are too far for the catapult to be launched
            else
                return "Please Enter a Valid Number."; //not needed if validate works properly, but ensures that the user cannot enter anything other than intended whole numbers
        }
        //Reset button event handling
        private void btnReset_Click_1(object sender, EventArgs e)
        {
                //clears user input and the output to give user multiple chances
                txtInput.Clear(); //clears textbox
                lblResults.Text = ""; //results no longer say anything until new input is added
        }
    }
}
