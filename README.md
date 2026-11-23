# 🃏 Card Game

A desktop card game developed using **C# and Windows Forms**. The game randomly deals three cards to the player and three cards to the computer, calculates each hand's total value, and determines the winner.

## 🎮 Features

- **52-Card Deck:** Uses a standard deck of 52 playing cards, including all four suits.
- **Random Card Dealing:** Randomly distributes three cards to each player.
- **No Duplicate Cards:** Removes dealt cards from the available deck to prevent the same card from being dealt twice in one round.
- **Score Calculation:** Calculates each player's score based on the values of their three cards.
- **Winner Determination:** Compares both scores and displays the winner or a tie.
- **Windows Forms Interface:** Displays card images, player scores, and game results through an interactive graphical interface.

## 🛠️ Technologies

- C#
- .NET Framework 4.7.2
- Windows Forms
- Visual Studio

## 🃏 Card Values

Each card has a numerical value used to calculate the total score:

| Card | Value |
|---|---:|
| Ace | 1 |
| 2–10 | Face value |
| Jack | 10 |
| Queen | 10 |
| King | 10 |

The player with the highest total score wins the round.

## 🚀 Getting Started

### Prerequisites

- Windows operating system
- Visual Studio with .NET Framework 4.7.2 support

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/paolarmendes/Card-Game.git
   ```

2. Open the project folder.

3. Open `Project.csproj` in Visual Studio.

4. Build the solution.

5. Run the application.

## 📂 Project Structure

```text
Card-Game/
│
├── Cards/              # Playing card images
├── Properties/         # Project properties and resources
├── Form1.cs            # Main game logic
├── Form1.Designer.cs   # Windows Forms interface
├── Form1.resx          # Form resources
├── Program.cs          # Application entry point
├── App.config          # Application configuration
└── Project.csproj      # Project configuration
```

## 📚 What I Learned

Through this project, I practiced and strengthened my skills in:

- C# programming and Windows Forms development.
- Working with List collections and random number generation.
- Implementing loops, conditional statements, and reusable methods.
- Handling images and file paths.
- Developing game logic and score calculation.
- Creating event-driven applications using button click events.

## 👩‍💻 Author

**Paola Ramos Mendes**

Computer Programming and Analysis Student

[GitHub](https://github.com/paolarmendes)
