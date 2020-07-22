//Alexandre Hoppe
//Project
//Scan an email for spam

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpamScanner
{
    public partial class SpamScannerForm : Form
    {
        private StreamReader fileReader;

        //create 4 global variable
        int spamProbability; //percentage of word from the list, in the email
        int emailAmount; //amount of word in the email
        double wordCount; //amount of word form the list, in the email
        string textProbability; //text telling if the email is a spam of not
        
       
        public SpamScannerForm()
        {
            InitializeComponent();
        }


        private void scanEmailButton_Click(object sender, EventArgs e)
        {
            try
            {
                wordCount = 0;
                scanEmail();
            }

            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("There is no email to scan");
                return;
            }
            
        }

        public void scanEmail()
        {    
            int arrayAmount = 32;
            int wordToBeSelected = 0;
            string emailToScan = emailText.Text;
            string emailLowerCase = emailToScan.ToLower();

            

            while (wordToBeSelected != arrayAmount)
            {
                WordList spamWord = new WordList();
                spamWord.setScamWord(wordToBeSelected);
                string wordSelected = spamWord.getScamword();

                while (emailLowerCase.Contains(wordSelected))
                {
                    int pos = emailLowerCase.IndexOf(wordSelected);
                    emailLowerCase = emailLowerCase.Remove(pos, wordSelected.Length);
                    wordCount += 1;
                    
                }
                wordToBeSelected += 1;
            }

            emailWordAmount();
            spamProbabilityChecker(emailAmount);
            spamProbabilityText(spamProbability);

            

            MessageBox.Show( "This email: \n" +
                "\tcontain " + wordCount + " words from the list." + "\n" +
                "\tcontain " + emailAmount + " words in total." + "\n" +
                "\t" + "is made at " + spamProbability + "% of the word from the list." + "\n" +
                "\t" + textProbability + ".");

        }

        public double emailWordAmount()
        {
            string emailToScan = emailText.Text.Replace(Environment.NewLine, " ");
            string[] emailSplit = emailToScan.Split(' ');
            emailAmount = emailSplit.Length;
            string lastCharacter = emailSplit[emailAmount - 1];

            while (string.IsNullOrWhiteSpace(lastCharacter)) { 
                emailAmount = emailAmount - 1;
                lastCharacter = emailSplit[emailAmount - 1];
            }
            Array.Clear(emailSplit, 0, emailSplit.Length);
            
            return emailAmount;

            
        }

        public int spamProbabilityChecker(double emailAmount)
        {
            double rawSpamProbability = (wordCount / emailAmount) * 100;
            spamProbability = Convert.ToInt32(rawSpamProbability);
            return spamProbability;
        }

        public string spamProbabilityText(int spamProbability)
        {
            
            if (spamProbability == 0 && spamProbability <= 10)  
                    textProbability = "is not a spam";
            if (spamProbability > 10 && spamProbability <= 20)
                textProbability = "might be a spam";
            if (spamProbability > 20 && spamProbability <= 30)
                textProbability = "has a great chance to be a spam";
            if(spamProbability > 40 && spamProbability <= 100)
                textProbability = "is a spam";

            return textProbability;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string fileName;

            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            if (result == DialogResult.OK)
            {
                emailText.Clear();

                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    try
                    {
                        FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                        fileReader = new StreamReader(input);

                        loadButton.Enabled = false;
                    }

                    catch (IOException)
                    {
                        MessageBox.Show("Error reading from file", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }

            try
            {
                var inputRecord = fileReader.ReadToEnd();
                int counterArray = 0;
                if (inputRecord != null)
                {
                    string[] inputFields = inputRecord.Split(',');
                    emailText.Text = inputRecord;
                    counterArray++;
                }
                else
                {
                    fileReader.Close();
                }
            }

            catch (IOException)
            {
                MessageBox.Show("No more records in file", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (NullReferenceException)
            {
                return;
            }


        }

        private void listButton_Click(object sender, EventArgs e)
        {
            int arrayAmount = 31;
            int wordToShow = 0;
            string wordReceived;
            string listMessage = null;

            while (wordToShow != arrayAmount)
            {
                WordList spamWord = new WordList();
                spamWord.setScamWord(wordToShow);
                string wordSelected = spamWord.getScamword();

                wordReceived = wordSelected;
                listMessage = String.Concat(listMessage, wordSelected, ", ");

                wordToShow += 1;
            }

            WordList lastSpamWord = new WordList();
            lastSpamWord.setScamWord(31);
            string lastWordSelected = lastSpamWord.getScamword();

            wordReceived = lastWordSelected;
            listMessage = String.Concat(listMessage, lastWordSelected, ". ");

            MessageBox.Show(listMessage);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

