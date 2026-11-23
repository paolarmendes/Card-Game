using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        private List<Image> cardImages = new List<Image>();

        private List<int> cardValues = new List<int>();

        private Random random = new Random();

        private List<int> computerHand = new List<int>();

        private List<int> playerHand = new List<int>();

        public Form1()
        {
            InitializeComponent();

            LoadCards();
            
        }

        private void LoadCards()
        {
            string cardsFolder = Path.Combine(Application.StartupPath, "Cards");

            string[] cardNames =
            {
                "Ace",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "Jack",
                "Queen",
                "King"
            };

            string[] suits =
            {
                "Clubs",
                "Diamonds",
                "Hearts",
                "Spades"
            };

            foreach (string cardName in cardNames)
            {
                foreach (string suit in suits)
                {
                    string fileName = cardName + "_" + suit + ".jpg";
                    string filePath = Path.Combine(cardsFolder, fileName);

                    Image cardImage = Image.FromFile(filePath);

                    cardImages.Add(cardImage);

                    int value;

                    if (cardName == "Ace")
                    {
                        value = 1;
                    }
                    else if (cardName == "Jack" ||
                             cardName == "Queen" ||
                             cardName == "King")
                    {
                        value = 10;
                    }
                    else
                    {
                        value = int.Parse(cardName);
                    }

                    cardValues.Add(value);
                }
            }
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            computerHand.Clear();
            playerHand.Clear();

            List<int> availableCards = new List<int>();

            for (int i = 0; i < 52; i++)
            {
                availableCards.Add(i);
            }

            for (int i = 0; i < 3; i++)
            {
                int randomPosition = random.Next(availableCards.Count);

                int cardIndex = availableCards[randomPosition];

                computerHand.Add(cardIndex);

                availableCards.RemoveAt(randomPosition);
            }

            for (int i = 0; i < 3; i++)
            {
                int randomPosition = random.Next(availableCards.Count);

                int cardIndex = availableCards[randomPosition];

                playerHand.Add(cardIndex);

                availableCards.RemoveAt(randomPosition);
            }

            pbComputer1.Image = cardImages[computerHand[0]];
            pbComputer2.Image = cardImages[computerHand[1]];
            pbComputer3.Image = cardImages[computerHand[2]];

            pbPlayer1.Image = cardImages[playerHand[0]];
            pbPlayer2.Image = cardImages[playerHand[1]];
            pbPlayer3.Image = cardImages[playerHand[2]];

            int computerScore = GetHandValue(computerHand);
            int playerScore = GetHandValue(playerHand);

            lblComputerScore.Text = "Computer Score: " + computerScore;
            lblPlayerScore.Text = "Your Score: " + playerScore;

            if (computerScore > playerScore)
            {
                lblWinner.Text = "Computer Wins!";
            }
            else if (playerScore > computerScore)
            {
                lblWinner.Text = "You Win!";
            }
            else
            {
                lblWinner.Text = "It's a Tie!";
            }
        }

        private int GetHandValue(List<int> hand)
        {
            int total = 0;

            foreach (int cardIndex in hand)
            {
                total += cardValues[cardIndex];
            }

            return total;
        }
    }
}