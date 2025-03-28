using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjFish
{
    public partial class CjFish: Form
    {
        public CjFish()
        {
            InitializeComponent();
        }
        //event handling an logic relating to conversions 
        private void btnCjConvert_Click(object sender, EventArgs e)
        {
            if(decimal.TryParse(txtNCInput.Text, out decimal ncTotal)) //confirms a number is entered
            {
                decimal cjTotal = ncTotal * 1.5m; //increases the Nook's Cranny total by 150% because CJ always buys the fish for 150% more.
                lblCjTotal.Text = $"Cj's Total: {cjTotal}Bells"; //outputs the total converted
                lstCjEntries.Items.Add($"Nook's Cranny: {ncTotal} -> Cj: {cjTotal} Bells"); //adds the conversion to the listbox so the user can see the history
            }
            else
            {
                MessageBox.Show("Please enter a valid number!"); //if something other than a number is entered, this message comes up
            }
        }
        //difference calculation portion of form logic and events
        private void btnCjCalculate_Click(object sender, EventArgs e)
        {
            if(decimal.TryParse(txtNCInput.Text, out decimal ncTotal) && decimal.TryParse(txtCjInput.Text, out decimal cjTotal)) //checks if valid number is entered
            {
                decimal profit = cjTotal - ncTotal; //profit is calculated by subtracting cj's total and nooks total
                lblProfitOutput.Text = $"Profit Difference: {profit} Bells"; //displays the profit in the label as...ex Profit Difference: 1200 Bells
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in BOTH text boxes!"); //if the text boxes were not filled out with numbers, the message will show up.
            }
        }
        //event handling an logic to return to the Nook's Cranny form
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides cj form
            NooksCrannyFish ncForm = new NooksCrannyFish();
            ncForm.Show(); //displays the Nook's Cranny form again
        }
    }
}
