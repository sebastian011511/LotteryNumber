using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
{
    public partial class Form1 : Form
    {
        Form1 form1;
        const int LIMIT = 6;
        int[] lotNums = new int[LIMIT];
        
        Random randomNum = new Random();

        public Form1()
        {
            InitializeComponent();
            buttonShowNum.Focus();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.DialogResult result;
            result = MessageBox.Show("Are you sure  you want to exit?", "Exiting",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
                this.Close();
            else
                this.buttonShowNum.Focus();
        }

        private void buttonShowNum_Click(object sender, EventArgs e)
        {
            toStringNums();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toStringNums();

            form1 = new Form1();
            form1.KeyDown += new KeyEventHandler(form_KeyDown);
        }

        private void ramdomGen()
        {
            List<int> numbers = new List<int>(); //temp holder

            int temp;
            for (int value = 0; value < lotNums.Length; value++) //creates ram numbers
            {
                do //creates the #s
                {
                    temp = randomNum.Next(1, 49);
                } while (numbers.Contains(temp)); //if number already exist, create another ram numb
                numbers.Add(temp); //add number to array
            }

            for (int index = 0; index < lotNums.Length; index++) //copies array list to int array 
            {
                lotNums[index] = numbers[index];
            }
            
        }
        
        private void form_KeyDown(object sender,KeyEventArgs e) //ALT+S
        {
            if (e.Alt && e.KeyCode==Keys.S)
            {
                toStringNums();

                e.SuppressKeyPress = true;
            }
        }

        private void toStringNums() //to display results
        {
            string displayNum = null;
            ramdomGen();

            Array.Sort(lotNums);
            for (int index = 0; index < lotNums.Length; index++)
                displayNum += lotNums[index] + "   ";

            textBoxNumbersDisplay.Text = displayNum;
        }
    }
}