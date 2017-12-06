using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProcessingAnArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //the average method accepts an int array argument 
        //and returns the average of the value in the array 
        private double Average(int[] iArray)
        {
            int total = 0;      //accumulator, initalized to 0 
            double average;     //to hold the average 

            //step through the array, adding each element to the accumulator 
            for (int index = 0; index < iArray.Length; index++)
            {
                total += iArray[index];
            }

            //calculate the average 
            average = (double)total / iArray.Length;

            //return the average 
            return average;
        }

        //The Highest method accepts an int array argument 
        // and returns the highest value in that array
        private int Highest(int[] iArray)
        {
            //declare a variable to hold the highest value, and 
            //initiate it with the first value in the array 
            int highest = iArray[0];

            //step through the rest of the array, beginning at
            //element 1, When a value greater than the highest is found
            //assign that value to the highest.
            for (int index =1; index < iArray.Length; index++)
            {
                if (iArray[index] > highest)
                {
                    highest = iArray[index];
                }
            }

            //return the highest value 
            return highest;
        }

        //lowest method accepts an int array argument 
        //and returns the lowest value in that array 
        private int lowest(int[] iArray)
        {
            //declare a variable to hold the owest value 
            //and initiates it with the first value in the array
            int lowest = iArray[0];

            //step through the rest of the array, beginning at 
            //element 1. When a value less than lowest is found,
            //assign that value to lowest
            for (int index = 1; index < iArray.Length; index++)
            {
                if (iArray[index] < lowest)
                {
                    lowest = iArray[index];
                }
            }
            //return the lowest value 
            return lowest;
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            try
            {
                //local variables 
                const int SIZE = 5;
                int[] scores = new int[SIZE]; //array of test scores 
                int index = 0;                //loop counter
                int highestScore;             //To hold the highest score 
                int lowestScore;              //to hold the lowest score 
                double averageScore;          //to hold the average
                Random rand = new Random();
                
                //fill the array with the random numbers 
                //from 65 - 100
                for (index = 0; index < scores.Length; index++)
                {
                    scores[index] = rand.Next(100);
                }

                //display the test scores
                foreach (int value in scores)
                {
                    testScoresListBox.Items.Add(value);
                }

                //get the highest lowest and average scores
                highestScore = Highest(scores);
                lowestScore = lowest(scores);
                averageScore = Average(scores);

                //display the values 
                highestScoreLabel.Text = highestScore.ToString();
                lowestScoreLabel.Text = lowestScore.ToString();
                averageScoreLabel.Text = averageScore.ToString();
            }
            catch (Exception ex)
            {
                //display an error message 
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form 
            this.Close();
        }
    }
}
