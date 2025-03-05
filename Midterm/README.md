# Checkers Game with ML-Agents and Multiplayer

This project is a Checkers game developed as a midterm project for the Microsoft Software & Systems Academy. It combines classic game mechanics with modern AI using Unity's ML-Agents toolkit and includes both single player (versus AI) and multiplayer modes.

---

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Screenshots](#screenshots)
- [Video Demo](#video-demo)
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

## Installation

1. **Requirements:**
   - Unity 2020.3 LTS or later
   - .NET Framework compatible with Unity
   - Unity ML-Agents Toolkit

2. **Setup:**
   - Clone the repository.
   - Open the project in Unity.
   - Import the required Unity ML-Agents package via the Package Manager.
   - Build and run the project from within Unity.

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

## Screenshots



---

## Video Demo




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

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

