//Sabrina Turney
//C# I
//Assignment 9-3: Slot Machine Simulation
//Last edited: 09/28/2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_Machine
{
    public partial class slotMachine : Form
    {
        public slotMachine()
        {
            InitializeComponent();
        }

        //First we declare all our variables
        //We have to get the numerical bet entered,
        //as well as compound wins if there are any.
        //Our spins must also be random or the user
        //would win every round!
        decimal amtEntered;
        Random rand = new Random();
        decimal total;
        decimal firstWin;
        decimal secondWin;
        decimal totalWins;

        //Here is our function to actually spin the "slot machine".
        private void slotSpin()
        {
            //We start out with a try block, just in case there are issues.
            try
            {
                //Find the amount in the betting box:
                amountTextBox.Focus();
                int index1 = rand.Next(fruitList.Images.Count);
                //Set our fruits to whatever index value they hold in the image list.
                int index2 = new int();
                index2 = rand.Next(fruitList.Images.Count);
                //This way, we know if the images match.
                int index3 = new int();
                index3 = rand.Next(fruitList.Images.Count);

                //Here is where each index is set to the actual viewing box for the viewer.
                firstPictureBox.Image = fruitList.Images[index1];
                secondPictureBox.Image = fruitList.Images[index2];
                thirdPictureBox.Image = fruitList.Images[index3];

                //Take the bet and make it a reasonable "dollar" readable amount.
                amtEntered = decimal.Parse(amountTextBox.Text.Trim());
                total += amtEntered;

                //If the user wins by two slots or three slots, we compound their winnings.
                firstWin = amtEntered * 2;
                secondWin = amtEntered * 3;

                //But obviously, we have to start their wins off at zero.
                totalWins = 0;


                //If statement here: If two of the slots are correct (index values must be equal)!
                if (index1 == index2 || index1 == index3 || index2 == index3)
                {
                    //We congratulate the user on their win, and let them know how much they got!
                    MessageBox.Show("Congratulations! Two slots! You have won: " + firstWin.ToString("c") + " !");
                }
                //Or if they get all three values correct, they get even more money!
                else if (index1 == index2 && index1 == index3 && index2 == index3)
                {
                    MessageBox.Show("Amazing! Three slots! Congratulations! You have won: " + secondWin.ToString("c") + " !");
                }
                else
                //Yikes, no win here. We have to give some hard news to our gamblers.
                {
                    MessageBox.Show("No luck this time! Try again!");
                }
            }
            catch (Exception ex)
            {
                //Obligatory catch if something doesn't work, so we can see what the issue is.
                MessageBox.Show(ex.Message);
            }
        }
        //Close the program - Easy!
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Here is the actual button click for the program
        //in turn, it runs the giant function up above :)
        private void SpinButton_Click(object sender, EventArgs e)
        {
            slotSpin();
        }
    }
}
