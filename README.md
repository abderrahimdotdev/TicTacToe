<p align="center">
    <img width="50%" alt="TicTacToe with Tom & Jerry Game User Interface" src="#">
    <br>
    <strong>Tom & Jerry Tic-Tac-Toe</strong>
</p>

## About

Tom & Jerry Tic-Tac-Toe is a cartoon-inspired twist on the classic game built with C# and Windows Forms. Play as the clever Jerry or the determined Tom in a fast-paced grid showdown! With themed icons, sound effects, and nostalgic visuals, this game captures the slapstick energy of the beloved cartoon series - all inside a simple 3x3 board.


## Features

- 🎨 Cartoon-Themed UI: Custom icons and buttons inspired by the Tom & Jerry.
- 🧠 Solo or Multiplayer: Play against a friend or challenge a basic Al (Tom-style aggressiveness or Jerry-style cleverness).
- 📹 Video Assistant Referee: Games played are automatically recorded and saved for potential reviews.
- 👀 Replay functionality: Analyze previous matches to ensure fair play was maintained.

## Technologies Used

- C#
- .NET Framework (Windows Forms)
  
## Screenshots

<p align="center">
    <img width="48%" alt="TicTacToe with Tom & Jerry Game User Interface" src="#">
    <img width="48%" alt="TicTacToe with Tom & Jerry Game User Interface" src="#">
</p>



  
## Game log file format: 

Every round is stored in a text file with a filename of a date pattern DD-MM-YYYY.txt<br>The content of the file is organized as shown below:

```
--------------------------------------------------------
> Jerry (Winner) [1-0] Tom :::::: at 12/07/2025 10:45:37
--------------------------------------------------------
Jerry : [1,1]
Tom : [0,1]
Jerry : [1,0]
Tom : [2,1]
Jerry : [1,2]
[OVER]
--------------------------------------------------------
> Jerry [1-1] Tom (Winner) :::::: at 12/07/2025 10:46:04
--------------------------------------------------------
Tom : [0,0]
Jerry : [1,1]
Tom : [0,1]
Jerry : [1,0]
Tom : [1,2]
Jerry : [2,1]
Tom : [0,2]
[OVER]
```
