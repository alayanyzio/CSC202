using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FinalProjFish
{
    public partial class NooksCrannyFish : Form
    {
        //declaring arrays 
        private string[] fishNames = new string[30]; //array for fish names up to 30 fish because in the game you can catch 30 fish before the fishing rod breaks
        private int[] fishPrices = new int[30]; //array to save the prices and use for totals, follows same amount of entries as the fish names
        private int fishCount = 0; //variable to track number of fish entered so the array does not exceed 30
        public NooksCrannyFish()
        {
            InitializeComponent();
        }
        //event handler and all code involved with the user submitting a fish name
        private void btnNCInputSubmit_Click(object sender, EventArgs e)
        {
            string fishName = txtNCFishInput.Text.Trim(); //gets the user input from the textbox and removes any extra spaces at the end

            int fishPrice = 0; //will be used to define the prices of each fish

            //logic to check if the input is valid; must be the name of 1 of 10 new April fish spelled correctly
            if (fishName.Equals("killifish", StringComparison.OrdinalIgnoreCase)) //how each name will be checked, it is not case sensitive. the name just has to be spelled properly
            {
                fishPrice = 300; //the price that will be output and stored for calculations
            }
            else if (fishName.Equals("crawfish", StringComparison.OrdinalIgnoreCase))
            {
                fishPrice = 200;
            }
            else if (fishName.Equals("snapping turtle", StringComparison.OrdinalIgnoreCase))
            {
                fishPrice = 5000;
            }
            else if (fishName.Equals("guppy", StringComparison.OrdinalIgnoreCase))
            {
                fishPrice = 1300;
            }
            else if (fishName.Equals("neon tetra", StringComparison.OrdinalIgnoreCase))
            {
                fishPrice = 500;
            }
            else if (fishName.Equals("sea horse", StringComparison.OrdinalIgnoreCase))
            {
                fishPrice = 1100;
            }
            else if (fishName.Equals("clown fish", StringComparison.OrdinalIgnoreCase))
            {
                fishPrice = 650;
            }
            else if (fishName.Equals("surgeonfish", StringComparison.OrdinalIgnoreCase))
            {
                fishPrice = 1000;
            }
            else if (fishName.Equals("butterfly fish", StringComparison.OrdinalIgnoreCase))
            {
                fishPrice = 1000;
            }
            else if (fishName.Equals("zebra turkeyfish", StringComparison.OrdinalIgnoreCase))
            {
                fishPrice = 500;
            }
            //final statement. this will cover if the user spells the name wrong or enters a different type of fish. it will display the general message and allow for another chance
            else
            {
                lblNCPriceOutput.Text = "Please enter a valid fish name!";
                return;
            }
            //displays the amount of bells the fish most recently entered is worth
            lblNCPriceOutput.Text = "Price: " + fishPrice.ToString() + "Bells"; //comes out as something like...'Price: 500 Bells'

            //saves fish data to a file
            WriteFishDataToFile(fishName, fishPrice);

            //adds name and price entered to the array
            if (fishCount < 30) //will only apply if there's less than 30 fish saved already
            {
                fishNames[fishCount] = fishName; //saves the variable fishName to the array for names
                fishPrices[fishCount] = fishPrice; //saves the variable fishPrice to the array for prices
                fishCount++; //the count goes up after each entry
            }

            //adds fish name and price to the listbox for the user to keep track
            lstNCEntries.Items.Add(fishName + "-" + fishPrice.ToString() + "Bells"); //stored as ex... sea horse-1100 bells

            //clear textbox for more entries
            txtNCFishInput.Clear();
        }
        //event handling and all code involved with calculating the total
        private void btnNCTotal_Click(object sender, EventArgs e)
        {
            int totalBells = 0; //variable that stores total amount

            //loop through the fishPrices array to add up all the prices
            for (int i = 0; i < fishCount; i++)
            {
                totalBells += fishPrices[i]; //adds the prices to the total
            }

            //displays total in appropriate output label
            lblNCTotalBellsOutput.Text = "Total: " + totalBells.ToString("0") + " Bells"; // displays as ex.. 'Total: 2650 Bells'
        }

        //writing fish data to a file
        private void WriteFishDataToFile(string fishName, int fishPrice)
        {
            string filePath = "fishData.txt"; //new file and variable

            using (StreamWriter sw = new StreamWriter(filePath, true)) //ensures file works properly and closes right
            {
                //writes name and price to file
                sw.WriteLine(fishName + "-" + fishPrice.ToString() + "Bells"); //the file will be structured like the listbox
            }
        }
        //all event handling and logic connected to switching from the nooks cranny form to CJ form
        private void btnNext_Click(object sender, EventArgs e)
        {
            CjFish cjForm = new CjFish(); //connects the 2 forms
            cjForm.Show(); //displays cj form
            this.Hide(); //closes nook form
        }
    }
}
