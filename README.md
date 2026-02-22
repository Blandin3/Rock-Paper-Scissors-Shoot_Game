# Rock Paper Scissors Game

A fun and interactive **Rock Paper Scissors** game built with **Unity**, where players can compete against the computer with a polished UI, sound effects, and customizable settings.

---

## 📋 Project Overview

This is a classic Rock Paper Scissors game implementation in Unity featuring:
- **Main Menu Screen** with navigation options
- **Interactive Gameplay** against AI opponent
- **Settings Panel** for audio control
- **How to Play Guide** for new players
- **About Page** with game information
- **Sound System** with music and sound effects support
- **Anti-Cheat Mechanism** to prevent selection changes after shooting
- **Replay Functionality** to play multiple rounds seamlessly

---

## 🎮 Game Features

### Core Gameplay
- **Player Selection**: Choose between Rock, Paper, or Scissors
- **Computer AI**: Random choice generation for the opponent
- **Winner Detection**: Automatic calculation of game results
- **Result Display**: Clear indication of Win, Lose, or Draw outcomes
- **Anti-Cheat Lock**: Player cannot change selection after shooting

### User Interface
- **Main Menu**: Home, How to Play, Settings, and About sections
- **Game Scene**: Dedicated gameplay interface with real-time feedback
- **Menu Navigation**: Smooth transitions between menu pages
- **TextMesh Pro**: Professional text rendering for all UI elements

### Audio System
- **Music Toggle**: Enable/disable background music
- **SFX Toggle**: Enable/disable sound effects
- **Persistent Audio Manager**: Settings persist across scenes using Singleton pattern
- **Dynamic Muting**: Audio sources mute/unmute based on settings

---

## 📁 Project Structure

```
Assets/
├── Scripts/
│   ├── GameController.cs          # Core game logic and win/loss determination
│   ├── MenuController.cs          # Menu navigation and scene management
│   └── SettingManager.cs          # Audio settings and singleton management
├── Scenes/
│   ├── MainMenu.unity             # Menu system and navigation
│   ├── GameScene.unity            # Actual gameplay scene
│   └── SampleScene.unity          # Optional sample/test scene
├── Prefabs/
│   ├── Animations/                # Animation assets and controllers
│   └── SoundFX/                   # Audio clips and sources
└── Art By Kandles/
    └── Game artwork and graphics
```

---

## 🛠️ Technical Details

### Scripts Overview

#### **GameController.cs**
Manages the core game logic:
- `enum Choice`: Rock, Paper, Scissors, None
- Player selection methods: `SelectRock()`, `SelectPaper()`, `SelectScissors()`
- Game flow: `Shoot()` determines winner and displays results
- Winner logic: Implements classic Rock Paper Scissors rules
- Replay system: `Replay()` resets game state for new round

#### **MenuController.cs**
Handles menu navigation:
- Navigation between Home, How to Play, Settings, and About pages
- Scene loading with `SceneManager`
- Game start and exit functionality

#### **SettingManager.cs**
Manages audio and persistent data:
- Singleton pattern for cross-scene persistence
- Music and SFX toggle controls
- Audio source management
- DontDestroyOnLoad for settings preservation

---

## 🎯 How to Play

1. **Start Game**: Launch the game and click "Start Game" from the main menu
2. **Select Choice**: Click on Rock, Paper, or Scissors button
3. **Shoot**: Press the Shoot button to reveal the computer's choice
4. **View Result**: The game displays who won
5. **Replay**: Click Replay to play another round or return to menu

---

## 🔧 Dependencies

This project uses Unity and the following packages:
- **TextMesh Pro**: For UI text display
- **Input System** (1.17.0): For modern input handling
- **Universal Render Pipeline** (17.3.0): For rendering
- **UI Elements** (2.0.0): For UI components
- **2D Packages**: Sprite, Animation, and Tilemap support
- **Audio System**: Native Unity audio management

---

## 🎨 Art & Assets

The game includes artwork by:
- **Kandles** (Character designs and graphics)
- **CatlandsGames** (Additional art assets)
- **OpenClipart vectors** (Rock Paper Scissors illustrations)

---

## 🔊 Audio System

### Features:
- **Background Music**: Persistent background track
- **Sound Effects**: Click sounds and game events
- **Individual Controls**: Separate toggles for music and SFX
- **Muting System**: Audio sources automatically mute based on settings

---

## ⚙️ Settings

Players can customize their experience through the Settings menu:
- **Music Toggle**: Turn background music on/off
- **SFX Toggle**: Turn sound effects on/off
- Settings persist across game sessions

---

## 🚀 Getting Started

### Prerequisites:
- Unity 2023.x or later (project configured for modern versions)
- No external dependencies required beyond built-in Unity packages

### Installation:
1. Clone or download this repository
2. Open the project in Unity
3. Load the MainMenu scene from `Assets/Scenes/MainMenu.unity`
4. Press Play in the Unity Editor or build the project

---

## 🐛 Known Features & Anti-Cheat

- **Selection Locking**: Once a player shoots, their selection is locked until replay to prevent cheating
- **Deterministic Rules**: Winner is calculated using enum-based logic for fairness
- **Clean State Management**: Replay resets all game variables properly

---

## 📝 License

This project is created for educational and entertainment purposes.

---

## 👥 Credits

- **Game Design & Development**: Rock Paper Scissors Game
- **Art Assets**: Kandles, CatlandsGames, OpenClipart
- **Built with**: Unity Engine

---

## 📧 Support

For issues, suggestions, or improvements, feel free to modify the scripts and customize the game to your needs!

**Enjoy playing! 🎮**
