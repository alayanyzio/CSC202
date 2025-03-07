namespace ErrorLog
{
    public partial class FrmErrorLog : Form
    {
        public FrmErrorLog()
        {
            InitializeComponent();
        }
        //manually set up event handler so when button is clicked the input is submitted and errors are logged
        private void btnSubmit_Click(object sender, EventArgs e)
        {
           //store user input as a string
            string inputText = txtAge.Text;

            //after parsing it will the age will be stored as an integer
            int age; 

            //parsing input to be stored as an integer 
            if (!int.TryParse(inputText, out age)) //if this fails the input was invalid
            {
                LogError("FormatException: Invalid input format. Please enter a valid number."); //logging the error in the error log
                return; //ends early as the input is invalid
            }
            //loop to add log entries
            int counter = 0; //counter to track the number of times iterated
            while (counter <3) //loop iterates 3 times as I set up 3 possible exceptions (2 simulated, 1 not if user makes an error)
            {
                try
                {
                    int result = age / 0; //DivideByZeroException simulated
                }
                catch (DivideByZeroException ex) //catches the exception when it happens to avoid crashing
                {
                    LogError($"DivideByZeroException: {ex.Message}"); //logs the error in the listbox
                }
                counter++; //adds to the counter each time
            }
            //simulating a FormatException
            try
            {
                //parsing an invalid string
                int invalidConversion = int.Parse("InvalidString"); //format exception caused by an invalid string
            }
            catch (FormatException ex) //parsing will fail and this line catches the exception to avoid a crash
            {
                LogError($"FormatException: {ex.Message}"); //logs error in list box
            }
        }
        //another manually created event
        private void LogError(string errorMessage) //logs the errors in the listbox
        {
            string logEntry = $"{DateTime.Now}: {errorMessage}"; //messages will be formatted with current date and time
            lstErrorLog.Items.Add(logEntry); //adds each error and message to the listbox
        }
    }
}
