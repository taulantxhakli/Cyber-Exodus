# Cyber-Exodus
  
   ## Table of Contents
  * [Description](#description)
  * [Table](#table)
  * [Sneak-Peek](#sneak-peek)
  * [Soundtrack](#soundtrack)
  * [Contributing](#contributing)
  * [Questions?](#questions) 
  
  
  ## Description
For the senior project, the team had decided to make a VR game set in a not so distant future where crime is at an all time high. Similar to the infamous Manhunt game, the player will be placed in a run-down prison and instructed to find the targets and eliminate them. This can be done by using the 3 pistols at the player’s disposal. This allows the player to store 3 weapons in their backpack using the built-in UI and possibly dual-wield them too. 
As for the project itself, it consists of two scenes, one of which is the menu scene which takes place in the laboratory. This is where the player can take control of the robot character and learn the controls before going into the prison itself. There is a canvas in front of the spawn location which will give more information on the controls and actions that are able to be done. Once the player feels that they are ready, they will collide with the white cube and be placed in the prison near the weapons truck for them to begin. Seeing as the game has been constructed in a sandbox design, there is no number or timer. Which means that the player can freely move around the prison without any repercussions. 

  ## Table
  
  This is the table of all the implementations that made it and did not:

| Talk | Completed | Comments |
| :---: | :---: | :---: |
| Locomotion with Point-Teleporting | Yes | This was done by combining the Oculus framework and Valve’s Steam VR framework and assets. |
| Ragdoll on NPCs | Yes | All of the NPCs have their bones rigged for ragdolling once they are shot. Some of the ragdolling is realistic, others are goofy. Each of the NPCs have been set to have 20 ragdoll force. |
| Melee | No | Due to the time constraint, and the issue of getting melee weapons to be used efficiently, we were unable to implement this. Though it is quite simple, just by having the melee using a collider and going close to the NPC to remove its animation and rigidbody, the issue was the ragdolling never came out good as we had hoped. So, instead of having it look too unrealistic, the idea was scrapped. |
| Laboratory Scene | Yes | Instead of the scene being its own addition to the game, it was later changed to be the “menu” section. |
| Prison Scene | Yes | The broken down prison is well detailed and the lighting is as realistic and precise as can be. |
| Stadium | No | Similar to the melee, this was due to time constraint and to me contracting COVID months back. Though we do have the stadium asset, it also did not fit well with the idea of a VR hunt game. |
| Pistol | Yes | This weapon fits the best with the game’s overall design. |
| Shotgun | No | Seeing as the NPCs “die” with one shot anyway, there was no need to have other weapons. Including the fact that getting a shotgun to work properly would require more time. |
| Flashlight | Yes | This was a simple addition to make. |
| Soundtrack | Yes | This was made by my (Taulant’s) brother. Seeing as he was the most artistic one and had the equipment to make the industrial metal music for the game. |
| Pulling Mechanic | Yes | The pulling only works on interactable objects, such as the guns, flashlight and ammo. We were planning to make the NPCs intractable as well, but that would mean to remove their existing collider, which would make the NPC fall through the floor, which is not what we wanted. So, that idea was scrapped. |

  
  ## Sneak-Peek
  https://www.youtube.com/watch?v=_aJjpnDpzRk&ab_channel=degenexpress


  ## Soundtrack
  [Cyber Exodus OST.zip](https://github.com/taulantxhakli/Cyber-Exodus/files/6517195/Cyber.Exodus.OST.zip)
  
  ## Contributing
  
  Contributions are always accepted. There is never no room for improvement. 
  
  ---
  
  ## Questions?
  
  ![Developer Profile Picture](https://avatars.githubusercontent.com/u/58316986?s=460&u=b6d47b95334d6366fb3a422f40454ac40f571a9f&v=4) 
  
  For any questions, please contact me with the information below:
 
  Email: txhakli@gmail.com
