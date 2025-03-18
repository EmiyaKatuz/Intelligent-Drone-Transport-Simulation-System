# Intelligent Drone Transport Simulation System
 
## Overview
This project simulates the delivery of essential supplies in epidemic-affected areas using unmanned aerial vehicles (drones). Developed in Unity3D, it recreates realistic urban and campus environments while showcasing advanced path planning.

## Features
- **Realistic 3D Modeling:**  
  - Detailed urban and campus environments built from scratch.  
  - Simulation of real-world logistics scenarios.
- **Advanced Drone Simulation:**  
  - Dynamic drone takeoff, navigation, and delivery simulation.  
  - Optimized routing using a modified 3D A* algorithm.
- **Intuitive User Interface:**  
  - Multi-angle viewing and real-time control modules.  
  - Highly modular system design for easy scalability.

## Operating Instructions

### Installation
- On Windows 10/11, extract the compressed program folder.
- **Pre-packaged Executable:**  
  - A fully packaged executable program is available in the repository's [Releases](../../releases) section.  
  - Download the latest release and run `Lab.exe` directly.

### Basic Operation Workflow
1. **Coordinate Input:**  
   - Enter the target coordinates in the top-left input box in the format `X Y Z` (e.g., `49 1 1`).  
   - **Note:** Valid coordinate range is X: 0–49, Y: 0–10, and Z: 0–49. Coordinates outside this range will not be recognized.

2. **Localization:**  
   - Click the **"定位"** button to verify the target location.  
   - A marker will appear at the target: green if reachable, red if unreachable.

3. **Advance:**  
   - After confirming that the target is reachable, click the **"前进"** button.  
   - The drone will move toward the target point, leaving a red trail that traces its flight path.

4. **Scene Switching:**  
   - Use the **"切换场景"** (Change the scene) button to toggle between different simulation scenes (e.g., school and city).  
   - The coordinate input, localization, and advance operations remain consistent across scenes.

5. **View Controls:**  
   - **First-Person View:** Hold the right mouse button and move the mouse to adjust the view.  
   - **Third-Person View:** Use the WASD keys to change the camera position and hold the right mouse button to adjust the view.  
   - Press the **J** and **K** keys to switch between first-person and third-person views.

## Technologies
- Unity3D
- Custom 3D A* pathfinding algorithm

## Getting Started
1. Clone the repository.
2. Open the project in Unity3D.
3. Follow the installation and operating instructions above or download the pre-packaged executable from the Releases.

## License
This project is licensed under the Mozilla Public License Version 2.0 License.
