using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_Project
{
    public partial class Form1 : Form
    {
        string[] words = { "banish", "remember", "offset", "dead", "clearance", "egg", "fool", "accompany", "rubbish", "crosswalk" };
        Random rnd = new Random();
        List<char> guessedLetters = new List<char>();
        string chosenWord = "";
        string hiddenWord = "";
        int numAttempts = 0;
        int arrayIndex = 0;
        char letterGuess;
        bool repeat;

        //Check if letter is already guessed; if it is, do not append guessedLetters array
        public string hideWord(String word)
        {
            /*Takes the length of the chosen word and hides it behind an equal number of asterisks */
            for(int i = 0; i < word.Length; i++)
            {
                hiddenWord += '*';
            }
            return hiddenWord;
        }

        public bool isRepeat(char guess)
        {
            return guessedLetters.Contains(guess);
        }

        public string revealLetter(char guess) 
        {
            for(int i = 0; i < hiddenWord.Length; i++)
            {
                if(guess == chosenWord[i])
                {
                    StringBuilder sb = new StringBuilder(hiddenWord);
                    sb[i] = guess;
                    hiddenWord = sb.ToString();
                    gameWordLabel.Text = hiddenWord;
                }
            }
            return hiddenWord;
        }

        public void startGame()
        {
            arrayIndex = rnd.Next(0, 9);
            chosenWord = words[arrayIndex];
            gameWordLabel.Text = "";
            hiddenWord = ""; //clears hiddenWord so that asterisks do not append last hidden word each time a new game is made
            gameWordLabel.Text = hideWord(chosenWord);
            usedLetterLabel.Text = "";
            numAttemptsLabel.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
            startGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            startGame();
            guessedLetters.Clear();
            usedLetterLabel.Text = "";
            letterGuessBox.Text = "";
            numAttemptsLabel.Text = "";
            numAttempts = 0;
        }

        private void letterGuessBox_TextChanged(object sender, EventArgs e)
        {
            if (letterGuessBox.Text.Length == 0)
            {

            }
            else
            {
                letterGuess = letterGuessBox.Text[0];
            }
        }

        private void gameWordLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkLetterBtn_Click(object sender, EventArgs e)
        {
            
            if (chosenWord.Contains(letterGuess) && !isRepeat(letterGuess))
            {
                revealLetter(letterGuess);
                guessedLetters.Add(letterGuess);
                numAttempts++;
                usedLetterLabel.Text += letterGuess + ", ";
                numAttemptsLabel.Text = numAttempts.ToString();
            }
            else if ((!chosenWord.Contains(letterGuess)) && !isRepeat(letterGuess))
            {
                guessedLetters.Add(letterGuess);
                numAttempts++;
                usedLetterLabel.Text += letterGuess + ", ";
                numAttemptsLabel.Text = numAttempts.ToString();
            }
            else
            {
                MessageBox.Show("You have already guessed this character, silly goose!");
            }
            letterGuessBox.Text = "";
        }

        private void giveUpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You gave up! Silly goose! The word was " + chosenWord + ". Press 'Start new game' to start a new game!");
            gameWordLabel.Text = chosenWord;
            startGame();
        }
    }
}
