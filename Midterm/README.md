# Checkers Game with ML-Agents and Multiplayer

This project is a Checkers game developed as a midterm project for the Microsoft Software & Systems Academy. It combines classic game mechanics with modern AI using Unity's ML-Agents toolkit and includes both single player (versus AI) and multiplayer modes.

[CHECKERS GAME DOWNLOAD LINK](https://github.com/Jrod7938/MSSA/releases/tag/v1.1)

![Solo](https://github.com/user-attachments/assets/7d26a41f-628f-4e5c-8264-9fe282864605)

---

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Video Demo](#video-demo)
- [Screenshots](#screenshots)
- [Usage](#usage)
- [Installation](#installation)
- [Project Structure](#project-structure)

- [Credits](#credits)
- [License](#license)

---

## Overview

This project implements a Checkers game with the following key elements:

- **AI Integration:** Utilizes Unity's ML-Agents for training an agent to play checkers.
- **Multiplayer Support:** Supports local networking for multiplayer gameplay using Windows Sockets TCP.
- **Classic Game Mechanics:** Implements standard checkers rules, including forced capture moves, chain captures, and promotions.
- **User Interface:** Provides an intuitive UI for game navigation, including menus for solo play, hosting, and connecting to a server.

---

## Features

- **Single-player vs AI:** Enjoy a challenging game against a trained AI.
- **Multiplayer Mode:** Connect locally to play against friends.
- **Dynamic Game Board:** Real-time update of moves and board states.
- **Score Tracking:** Maintains scores for both red and black teams.
- **Visual Feedback:** In-game alerts and UI feedback for player actions.
- **Chain Capture & Promotions:** Advanced game mechanics for a true checkers experience.

---

## Video Demo

### AI Training Using Self Play
https://github.com/user-attachments/assets/c3092291-6fea-4b7e-a287-de6db99fecf9

---

## Screenshots

### Home Screen
![HomeScreen](https://github.com/user-attachments/assets/f28bd6c0-cb2f-457c-a0dd-ee054785b95b)
### Multiplayer
![Multiplayer](https://github.com/user-attachments/assets/56878bbd-adfc-432d-9712-650920781da6)

---

## Usage

1. **Main Menu:**
   - Choose **Solo** for single-player mode (versus AI).
   - Choose **Host** to start a multiplayer game.
   - Choose **Connect** to join an existing multiplayer session.

2. **Gameplay:**
   - Use the mouse to select and move pieces.
   - In multiplayer mode, moves are synchronized over TCP.
   - The AI uses ML-Agents to make decisions during its turn.

3. **Controls:**
   - Click on a piece to select.
   - Drag to move to the desired location.

---

## Installation

1. **Requirements:**
   - Unity 2020.3 LTS or later
   - .NET Framework compatible with Unity
   - Unity ML-Agents Toolkit 3.0.0

2. **Setup:**
   - Clone the repository.
   - Open the project in Unity.
   - Import the required Unity ML-Agents package via the Package Manager.
   - Build and run the project from within Unity.

3. **Optional: For AI Training**
   - Install [Anaconda](https://www.anaconda.com/download)
   - Open Anaconda Command Prompt and type the following commands: 
      - ```conda create -n AI python=3.9 -y```
      - ```conda activate AI```
      - ```pip install mlagents```
   - For training, run the following command:
      - ```mlagents-learn \Checkers\Assets\Scripts\AI\configs\checkersConfig.yaml --train```
   - Press Play in the Checkers Game AI Scene

---

## Project Structure

- **Scripts/**: Contains all C# scripts including game logic, network handling, AI agent code, and UI management.
  - *CheckersBoard.cs*: Main game board implementation.
  - *Piece.cs*: Defines piece behavior and movement validation.
  - *Client.cs & Server.cs*: Networking logic for multiplayer mode.
  - *GameManager.cs*: Manages UI and game state transitions.
  - *CheckersAgent.cs*: AI agent for the ML-Agents integration.
- **Prefabs/**: Contains prefabs for game pieces and UI elements.
- **Scenes/**: Contains Unity scenes for the main menu and gameplay.
- **Scripts/AI**: Configuration and training files for the AI agent.

---

## Credits

- Developed by: [Jancarlos Rodriguez](https://github.com/Jrod7938)
- Microsoft Software & Systems Academy Midterm Project
- Unity Technologies for the engine and ML-Agents toolkit

---

## License

This project is licensed under the MIT License. See the [LICENSE](https://github.com/Jrod7938/MSSA/blob/main/LICENSE) file for details.

---

