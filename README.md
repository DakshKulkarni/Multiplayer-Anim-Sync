# REIA Multiplayer VR Assignment

##  Project Overview 
This project is a basic VR multiplayer animation viewer built using Unity 2022.3.55f1, Meta XR SDK, and Photon PUN 2. It features:

- A **Lobby scene** where you can create/join multiplayer rooms 
![Screenshot 2025-04-13 031956](https://github.com/user-attachments/assets/1b8d21b7-c8db-4531-8942-479bc8c21aeb)
- A **Main scene** where synced Meta avatars display animations and joint tracking info  
- A **host-controlled animation system** (Idle, Walk, Run, Jump) 

- A **UI panel** that shows joint angles and posture summaries in real-time  

---

##  Setup Instructions

###  Requirements
- **Unity version:** 2022.3.55f1  
- **Meta Quest 2/3 Pro** (tested using Quest standalone builds)  
- **Photon PUN 2** installed and configured with your App ID  
- **Meta XR All-in-One SDK** with Interaction SDK  

---

###  How to Test

#### 1. **Launch Lobby Scene**
- In **VR**, look at the **input field** and click it.
- A virtual keyboard will automatically pop up
- Enter a room name to create or join.

#### 2. **Creating a Room (Host)**
- Enter a unique room name.
- **IMPORTANT:** Please wait **2-3 seconds** before clicking "Create Room" 

#### 3. **Joining a Room (Client)**
- On another build (ideally on another Quest headset):
  - Enter the **same room name**.
  - Click "Join Room".

 After either button, you’ll transition to the **MainScene** automatically.

---

###  Main Scene Controls

- You might need to move around using your joystick to align with the floating UI panel.
- The UI contains:

  -  A **dropdown** to select animation: `Idle`, `Walk`, `Run`, `Jump`   ![Screenshot 2025-04-13 032317](https://github.com/user-attachments/assets/f410160d-5c42-4890-b968-ea88b2dd4319)
  -  A **slider** to control playback progress
  -  A **panel** showing:
    - Real-time **joint angles** (Left Elbow, Right Knee)
    - A **posture summary** (e.g., "Left Arm: Raised")
    - ![Screenshot 2025-04-13 032126](https://github.com/user-attachments/assets/f887e572-bdf3-462d-86b8-5a59d22d2170)
    - The **current animation**
![Screenshot 2025-04-13 032204](https://github.com/user-attachments/assets/b85efb87-db9a-4dae-af46-0da593aa5514)

---

### Bugs & Notes

-  **Dropdown glitch:** Sometimes the animation doesn’t switch unless you spam the dropdown item multiple times (5–10+ times). I suspect it’s due to a Unity/loop toom issue I am assmuing, will look into it again to fix it. Apologies for this inconvenience.
-  I could not test this with 2 Quest headsets, so I could only verify one side of the room connection. All Photon logic for avatar syncing and room join is implemented correctly, though.

---

## Build

- If you just want to test:
  - Download the zip named Builds and install the apk named last build and install it on your Quest directly.

- If you want to build it yourself:
  1. Clone/download the project.
  2. Open it using **Unity 2022.3.55f1**.
  3. Make sure Photon App ID is configured.
  4. Build and Run for Android (Quest).

---

##  Developer Notes

> This was technically my first proper multiplayer VR project using Photon I had done something earlier with Meta's building blocks but this was the real deal. I faced **tons of setup issues**, sync bugs, UI glitches, input problems... but honestly, that made it exciting.

> I now feel confident building Photon multiplayer project from scratch. Even though the UI is basic and some features are janky, I'm proud of what I built — and this ended up being one of my favorite assignments so far.

Thanks for checking it out!!
