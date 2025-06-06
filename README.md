# Adventure
https://www.youtube.com/watch?v=UFj7HGwR3UE

# Roll-a-ball

## Catarina - March 3rd

This is an assignment for my Game Development class in University. I follow a Unity tutorial called Roll-a-ball and then add one more level and two features.

The main goal of the tutorial is to build this plane where a ball is rolling around controlled by the player. To win, the ball must collect several yellow objects lying around without being caught by the enemy, a moving orange rectangle that follows the player’s every step. After collecting all the yellow collectibles, the enemy disapeers, but the player does not level up until he collides with the purple jewel.

The initial hardships I had related to the project were the lack of experience with the tools in the Unity editor. Such difficulties disappeared once I was into the tutorial and had build some of the features. After finishing the tutorial, I added as asked one more level and some more extra features.

One of the features I added was the Death Zone. Since the player can fall from the game area, I created a plane object that is bigger and is position directly under said game area. When the player enters in contact with the Death Zone, which is set to be a trigger, it displays a message, waits for 2 seconds and restarts the game. This was a solution I found for the player falling into the unknown and not being able to get out in case of flying out of the game area.

Another feature I added was the "Night Time". After a certain amount of time, if the player has not levelled up yet, the "night time" comes and the game restarts. It was made with the intention to cause adrenaline in the player. There is a set time (60 seconds) in which the Invoke method inside of the Start() method in the PlayerController.cs class calls a NightIsHere() method. In this method, the light intensity is set to 0, a message is displayed and the game restarts. All the other features are in the PlayerController.cs class, but this feature has its own NightTimeController.cs class because it's not connected to any player action.

The last feature I added was a special purple jewel that allows the player to level up, only after the player has collected all the 13 yellow collectibles. To do so, I created a jewel object which is a trigger. After the count gets to 13, meaning all yellow collectibles were caught, and checking if the text shown when leveling up is not active, it spawns the purple jewel in specific coordinates in the game area and destroys the enemy. Upon being collected by the player, it triggers the LevelUp() function in the PlayerController.cs class that triggers a LevelTransition() function that then transports the Player into the second level.

Finally, to create the second level, the scene was duplicated, but the game area was made smaller.

Notes: The SpawnPurpleJewel() method in the PLayerController. cs class was heavily inspired in the prompt in this website: https://discussions.unity.com/t/how-to-parent-spawned-object-from-array-solved/826062



## Iva - March 2nd

Roll a Ball, a beginner tutorial offered by Unity. This was my first interaction with game development and Unity. As I never did any similar programming, it was a completely new concept to wrap my head around. The mini game, as the name suggests, is a game that has a sphere as the player, that then rolls around and does some things.

First challenge was setting up the workspace and actually making the sphere. I waited for 2 classes to pass, before I started working on this tutorial. This helped as we learned about the editor itself and scripting during those two classes. With that, it was time to finally make this game. Having a mini ball that rolls around on a platform and falls down into an endless pit, maybe sounds sad to experienced devs, but for me it was a successful start to my first ever game.

The tutorial was quite straightforward, I didn't stray away from it, well, other than instead of making everything in shades of gray, I added purple, pink and blue. When the time came to make obstacles, I put them in a star shape, very bold. I hope to experiment more in future with shapes, textures and colours, find a way to express myself uniquely. It was fun to play around with physics, gravity, mass of an object and how it can be pushed around or collected.

After I finished the first part of the game, where you, the ball, roll around and collect all the cubes and win, I started with the AI enemy. I thought this was going to be very complicated, but I was pleasantly surprised. I made a mistake the first time by somehow adding a constant radius my enemy had to keep from the sphere, so when you played it, it would kind of just spin around you > <. After spending some time trying to fix this, I deleted the object and started anew. This time it was successful.

With this, the game came to an end. I am content with the results, but as we have more classes, I will strive to get better at Unity, by bettering my mini game. Perhaps, adding some new levels, maybe a timer or a faster enemy, maybe more obstacles.



# Game Design Document & Milestones - March 10th

## Execute Summary 
Our game is going to be a platform genre game. The target audience is 6 - 29-year-old girls and women, as well as any lover of adventure and non-violent platform games. The game is going to be a platform adventure game, as already stated. It will include a girl, entering a forest and finding an abandoned kitten. She will then go on a quest to bring this kitty back home. They will go through various obstacles and challenges in different area settings as they level up. While conquering these levels, she will gain new superpowers that will help them reach the end goal of tackling and defeating the final boss. 

## Game Play 
In level 1, the girl will overcome basic obstacles and as she progresses through each level, she will gain new superpowers and respective complementary superhero uniform items. At the current moment, this game is planned to have 4 levels, a forest, a cave, under the water and a desert. At the end, there is a monster which is the final boss. After defeating the final boss, they enter a pink space shuttle and travel to the kitty planet, where they are received with a party. In the monitor, you can see a HP bar with 9 kitty lives. If they run out before the end of the level, the level will restart and the life number will be restored. To change levels, they must collect leaves, gems, treasure coins and tapestry (on their 
respective level) to unlock the portals. 

## Mechanics 
Throughout the levels, our character will gain more and more mechanics. Starting from lower levels where she can walk and jump, to gaining armor that can defend her from obstacles, shooting gloves and flying ability at the end. The physics will be the classic platforming physics, similar to the real world with less gravity to give it more of a fantasy feel. Each level will have some obstacles she will need to jump on/over. With level up, obstacles will be harder to pass, with mini creatures she needs to fight and in the end defeat the final boss, which will be a mythical creature that can potentially spew something at her, 
hit her with its tail, … 
She is also going to have 9 lives. Failing a level makes you lose a life, getting hit 3 times from the final boss loses you a life. 

## Game Elements 
The worlds are different on each level, going from a forest to a cave, to an 
underwater world, to a desert.  
- The protagonist is a courageous girl with love for animals.
- Kitten is a cute companion.
- Level creatures are, for example, fish in the underwater world, trying to stop the girl.
- Final boss is a mythical creature that prevents the girl and the kitten from reaching their transportation for the kitten’s home.
  
## Assets
- meow sound, other music (AI, Cat, maybe Viktor - peer), the intro and outro, maybe draw our backgrounds, 2D characters and obstacles (hopefully drawn by us) 

## Milestones 
1. Prototype of core gameplay. Implement level 1 player movement, like walking and jumping. Make the basic level layout, this consists of making the obstacle course and the obstacles on it. Create some placeholder UI for the first milestone. The preferred outcome is a playable level 1. 
2. Design and implement the rest of the levels. Implement the powerups. An important note is on creating the characters and designing the background and obstacles, as well as making the rest of the levels playable. 
3. Final game polishing. Game testing and bug fixing. As well as adding additional features to make it nicer, like background music, sound effects.




# Game Developemnt Blog Post 3 - March 26th

## Prepare GitHub Structure

- As for now, we have a .gitignore file and readme.md file. Readme.md file was updated on the main branch, but in future when we start coding the game, the updates will be done through a separate branch.
- As we start implementing, each person will be given a task for which they will make a branch with latest main update, and work on their own branch.
- We will either implement PR(pull request) rules into GitHub or will just have an agreement that the other person has to review the PR, before merging it into the main.

## Detail Description of Levels

We decided to write out a detailed description of each level during this period because we did not start our implementation soon enough to have Level 1 done for BlogPost #3. 

We are going to take this time (week 13) to go through a “2D Beginner: Adventure Game” learning path, and after we will apply that knowledge and start making our game.

### Level  1

The forest level. The platform will be an obstacle course made so the player can go through it by walking and jumping over obstacles while collecting a number of leaves.

Player Mechanics - walking (left, right), jumping (including physics), collecting 10 leaves to gain a life for the final stage of fighting a final boss.

Platform Mechanics - moving tiles, vine-covered tiles that slow down the player

Platform - A pallet of tiles with a dark green and brown theme to match the forest setting, have a tile the player will need to jump on/over. They can vary from grassy forest ground to wooden tiles representing fallen logs that the player can jump over.

### Level 2

The cave level. The platform will be an obstacle course, which a player has to go through by walking, jumping (from the previous level), crouching under a low ceiling, and pushing the rocks to create a path, while collecting the gems to gain life.

Player Mechanic - in addition to the previous level, a mechanic of crouching, and pushing/moving the objects

Platform Mechanic - turning on the light ( there will be torches in the cave, where the light will turn on when the player is in close proximity), slippery rock tiles that make the player move faster

Platform - A pallet of tiles with a beige and brown colour theme to match the cave setting, it will still have some tiles that the player will need to go over, but also will have tiles that the player needs to go under (crouch).  They will vary from stone to slippery stone and some water dripping from ceilings. 

### Level 3

The underwater level. The background is the bottom of an ocean and the player can move up, down, left, and right. In this level, the player collects treasure coins. There will be several different coloured corals serving as obstacles, and there will be puffer fish being flown at the player by ocean currents. The player can have fun while popping the puffer fish with a magic wand that shoots light bubbles.

Player Mechanic- in this level, all the previous mechanics are translated into being able to swim in all directions. A new mechanic will be the ability to shoot the enemies (puffer fish) with a magic wand that shoots light bubbles.

Platform Mechanics - The puffer fish will act as the enemy and when pushed by the occasional currents, it will puff.   There will also be some corals entering and exiting the screen.

Platform-  An underwater background with corals of different colours and orange puffer fish. There will be some visual effects for the currents.

### Level 4

The desert level. The platform will be an obstacle course made so that the player can use all mechanics from previous levels, as well as a new flying mechanic. This level includes Monster Sphinx as a final boss. The player will fight the final boss, using all of the mechanics from the previous levels and this level. The three lives acquired in the past levels will help the player defeat the Sphinx. 

Player Mechanic -  in addition to the previous level, the player can fly ( perhaps, for a limited amount of time)

Platform Mechanics-  there will be moving snakes that show up from the sandy ground

Platform- A desertic landscape with a pyramid-themed background. The last boss is a Monster Sphinx. There will be tiles in beige and orange colours that will represent the desert, as well as some that look like those that have to be avoided.

# Game Development Blog Post 4 - April 27th
## Iva
As mentioned in the last blog post, I have went through the “2D Beginner: Adventure Game”. I mostly focused on, and revisited first 3 modules of it. This is where I learned about sprites, tiles and tilemaps, as well as about player movement and the physics of it.

## Level1
Before I started the implementation of the level, I made an empty unity project, deleted all the unnecessary folders that should not be pushed into git repository. Even though our .gitignore has the lines to ignore these files I decided it would be better and more clean to delete them. After setting this up on my machine I pushed into main. This was the first and last commit that would be pushed from main to main.

Afterwards I made a new branch from main called level1-setup. We decided to follow a convention of naming our branches by level-functionality. By having this naming convention we are able to describe what is going to be the main purpose of this branch and this will make the development process cleaner. In this branch, as the name states, I imported the environment art we found from https://segart.itch.io/2d-16px-grassland-tileset. By referencing the 2D tutorial, I made a tileset, and painted my tilemap. I also imported our pngs of the players. The main player character (Cherry) was drawn by Catarina, and the cat (Coco) by me in pixelorama. As of now we will be using this imported art, we want to focus on the functionality of the game before the art, and later in the process, when we are satisfied with the functionality we will try and draw our own tileset as well. After I was finished the pull request was made and we merged it to main.

The next step was making the player character (Cherry) move. Therefore I made a new level1-playerMovement branch. I started of by making her move left and right (like I learned from 2D unity tutorial). I had no problems implementing this part. Afterwards, I applied Box Colliders to the objects and made sure that my character walks on the ground, and cannot fall inside it. The decorations are not colliding, as I imagine them being a part of the background, rather than an obstacle. The ground tiles were used as obstacles where the player Cherry will bump into it, and have to jump on/over it. As I was trying to implement this jumping functionality I got stuck. First I tried to “blindly” make this, by following the same pattern it took to make the player walk left and right. Soon I discovered this was not enough, as I had to apply some physics to it, add a ground layer to my unity project and a ground check to know when the player is on the ground. I watched a few “make 2d unity player jump in under 1 minute” videos, and tried a few similar methods of adding this ground layer, in my script having a jump force, ground check and ground layer. Unfortunately by the end of this week, Cherry is unable to jump. In the future my first task will be to fix this functionality, and make sure she is able to jump, and then continue on with the progress of the game.

## Catarina

As mentioned in class, I also went through the tutorial on 2D game Developing, which allowed me to have the basic knowledge to build the game. Because we decided to divide the work in levels, I was in charge of starting to develop level 2.

## Level2

Firstly I tried to set up the connection between both scenes for the levelling up functionality because I had done something similar on the Roll-a-ball assignment. Now the levels are added to the scene list in correct order- Level 1 (0) and Level 2 (1) and there is some extra logic on the PlayerController script for leveling up. This functionality will be delivered with the characters collision with a portal object (literally), which will exist in the future.

As level 2 has the same basics as level 1, we started by duplicating level 1 and in Hierarchy, eliminate the GameObjects that would not be necessary for level 2. Then I tried to set up a background and tiles, also using some of the art mentioned above. I am currently trying to figure out how to set up the cave parallax. Bellow I will list some websites I am using to research about the topic. Next in the next future will be finishing the setup for level 2, open another branch to add some more mechanics like rock obstacle moving function, some special lighting and also the ability for the main character to crounch.

References: https://www.bing.com/videos/riverview/relatedvideo?&q=tutorial+on+how+to+create+a+2d+game+unity&&mid=0DE3ABE3044438C809C70DE3ABE3044438C809C7&&mcid=1BE2E886C8A8456E886336F40A2E8347&FORM=VRDGAR

https://www.encora.com/insights/how-to-take-advantage-of-parallax-in-programming-and-video-games

https://blog.yarsalabs.com/parallax-effect-in-unity-2d/

# Blog Post #5
## Iva Mucic June 6th

This week, I continued developing level 1 world by fixing the left and right movement and finally implementing the jumping functionality. I also added a camera follow script so the camera now smoothly tracks Cherry as she moves.
We decided to merge the sprites of Cherry and Coco since Coco will only follow Cherry passively, not act as a second player. This change made the movement logic cleaner.
I added the leaf collectible and linked it to a new health system, when the player picks up a leaf, health increases, and when falling into water or a damage zone, one leaf is lost. To reflect this, I also added a HUD showing current health status.
I then implemented a SoundManager and added sounds for background music, jumping, collecting, and damage. The background music now plays persistently across scenes using a LoadingManager.
Finally, I added a full pause menu with options to resume, change volume, restart, or quit, and began working on level 3’s tilemap, decorations, and enemy setup.
On level 3 the player is able to go through the level, jumping and collecting the pearls.
I did not have enough time to finish the enemy, so it does not move left to right it just stays in place. But if the player collides with it then they have to restart the level.

## Catarina

The past week my goal was to finish level 2 and make level 4. When developing level 2, as mentioned in the reflections, I had a lot of difficulties due to what we believe was a mixture of confusing branches and not knowing. This was an issue that followed me until the day before the handin. Despite all- I focused on improving the level 2 design every time I had to reset it. For the level 2, the goal was to give it a cave feel, from the gems and the tnt objects, to the intricate path. 
I also worked on the level transition logic, where I set the portal object so that as soon as the player collides, they would make the scenes change automatically. 
For the last level, the idea was to implement an enemy Ai, which would be the sphinx that now serves as a background. Te pyramid was set to be the portal for the epilogue, a plan that now is archived for future development.
The shrink ability was coded on a principle of when the input from the player is detected, the player shrinks to half it's size, going back to normal after another input.

# Blog Post #6
After months of planning, learning, coding, fixing bugs, and sometimes just staring at Unity in confusion, our game is finally finished! Our journey started from a simple Roll-a-Ball tutorial, where a sphere collects objects and avoids enemies. From that small beginning, it grew into a fully playable 4-level 2D adventure platformer starring Cherry, a brave girl, and her adorable cat companion Coco. They travel through a forest, a dark cave, a mysterious underwater world, and a harsh desert, all in a quest to help a lost kitten return home. 
## Level 1:
Forest This was our starting point. The forest level introduced basic mechanics—walking, jumping, and collecting leaves. The leaves act as lives, and when all are lost, the player restarts the level. We also implemented a smooth camera-follow feature and added a health HUD, giving players a clear view of their progress. The environment is made of tiles from a beautiful pixel-art set, with sounds and music setting the tone. Getting Cherry to jump correctly took longer than expected, but once we cracked the physics, it became the heart of our gameplay. 
## Level 2: 
Cave This level added more complexity. We introduced crouching, and light tiles. The background was trickier due to our attempts at implementing a parallax effect for a more immersive feel. We duplicated the forest scene to keep some base structure but modified it into a darker palette, more narrow paths, and added lighting mechanics using proximity triggers. We’re proud of how this level turned out—it feels different enough to be its own world, while still following the same game logic. 
## Level 3: 
Underwater This level gave us a chance to move away from the traditional platform layout and experiment with a new environment. Though the setting is underwater, Cherry retains her usual walking mechanics—navigating submerged tiles rather than swimming. She explores in all directions, collecting pearls while avoiding static (and eventually moving) purple fish. Originally, we intended the pufferfish to drift using a current-based movement system, but due to time constraints, they remain stationary as hazardous obstacles. A new sprite addition introduced here is Cherry’s magical wand. The level’s bright, colorful visuals enhance its playful, exploratory feel. 
## Level 4: 
Desert & Final Boss The final level combines all the mechanics learned before. We designed a large desert area with the Monster Sphinx, our final boss. Unfortunately, due to time constraints, the final boss mechanic is not available. 
## Reflection 
We’re extremely proud of what we created. This was our first full game, and while some features didn’t turn out exactly as we planned, the core vision stayed intact. The game feels personal—filled with our own art (Cherry and Coco were drawn by us!), original logic, and moments of trial and error. It’s also fun to play. We added a complete pause menu, background music that persists between scenes, and different sound effects to help the world feel alive. 
Some lessons we learned: 
*  Start simple, even if your ideas are big.
*  Divide the work but make sure everyone understands the whole project.
*  Art and functionality can live together—but prioritize mechanics early.
*  Playtesting often reveals small bugs that feel huge to players.
*  And finally, GitHub branches save friendships.

## References

 started a call that lasted an hour. — 4/22/2025 5:04 PM
Iwa — 4/22/2025 5:26 PM
https://segart.itch.io/
itch.io
Segart
https://pxldev.itch.io/big-32x32-tileset
itch.io
Big 32x32 Tileset - A Repackaged Asset Pack by PxlDev, Team Melon
Big 32x32 Tileset - A Repackaged Asset Pack by PxlDev, Team Melon
CJ — 4/22/2025 5:48 PM
Image
Iwa
 started a call that lasted 13 minutes. — 4/27/2025 11:28 PM
CJ — 5/31/2025 3:58 PM
Image
Image
CJ — 6/1/2025 3:17 PM
Image
Image
Image
Iwa — 6/1/2025 6:15 PM
http://www.walkerboystudio.com/wbstudio/project-2d-mario/
Walker Boys Studio
chadw
Project 2D Mario
Project 4: Mario 2D Mario 2D (Side Scroller) is the fourth of five Unity based game training projects. The projects are designed to grow in difficulty and scope. Each project should be successfully completed before moving to the next one. On completion of each project assignment, be sure to complete the presentation
Image
CJ — 6/2/2025 12:22 PM
Image
Image
CJ — 6/2/2025 1:46 PM
I am goign to take a while
He is returning from a meeting supposedly
CJ — 6/3/2025 8:44 AM
Level 1 collectibles approved and ready to be merged to main
Link to Doc:
https://docs.google.com/document/d/13xYaMJMjSLZMG7AnMnWYDhN4oFK50H3gfPcQpeutoiM/edit?usp=sharing
Player Movement Tutorial (left, right, jump) - https://www.youtube.com/watch?v=TcranVQUQ5U&list=PLgOEwFbvGm5o8hayFB6skAfa8Z-mw4dPV&index=1

Camera Work - https://www.youtube.com/watch?v=PA5DgZfRsAM&list=PLgOEwFbvGm5o8hayFB6skAfa8Z-mw4dPV&index=6

Setup of the project (the tilemap and painting of tileset), Collectibles Tutorial - https://learn.unity.com/course/2d-beginner-adventure-game?version=2022.3

Tilesets:
Level1 - https://segart.itch.io/2d-16px-grassland-tileset
Level3 - https://segart.itch.io/2d-16px-underwater-tileset

Background Music - Music by <a href="https://pixabay.com/users/moodmode-33139253/?utm_source=link-attribution&utm_medium=referral&utm_campaign=music&utm_content=142093">Vlad Krotov</a> from <a href="https://pixabay.com/music//?utm_source=link-attribution&utm_medium=referral&utm_campaign=music&utm_content=142093">Pixabay</a>
- https://pixabay.com/music/video-games-8-bit-dream-land-142093/

Jump Sound - Sound Effect by <a href="https://pixabay.com/users/freesound_community-46691455/?utm_source=link-attribution&utm_medium=referral&utm_campaign=music&utm_content=105724">freesound_community</a> from <a href="https://pixabay.com/sound-effects//?utm_source=link-attribution&utm_medium=referral&utm_campaign=music&utm_content=105724">Pixabay</a>
- https://pixabay.com/sound-effects/toy-button-105724/

Collect Collectible Sound - Sound Effect by <a href="https://pixabay.com/users/freesound_community-46691455/?utm_source=link-attribution&utm_medium=referral&utm_campaign=music&utm_content=14575">freesound_community</a> from <a href="https://pixabay.com/sound-effects//?utm_source=link-attribution&utm_medium=referral&utm_campaign=music&utm_content=14575">Pixabay</a>
- https://pixabay.com/sound-effects/decidemp3-14575/

Respawn Sound - Sound Effect by <a href="https://pixabay.com/users/freesound_community-46691455/?utm_source=link-attribution&utm_medium=referral&utm_campaign=music&utm_content=66829">freesound_community</a> from <a href="https://pixabay.com/sound-effects//?utm_source=link-attribution&utm_medium=referral&utm_campaign=music&utm_content=66829">Pixabay</a>
- https://pixabay.com/sound-effects/pixel-death-66829/

Click Sound - Sound Effect by <a href="https://pixabay.com/users/matthewvakaliuk73627-48347364/?utm_source=link-attribution&utm_medium=referral&utm_campaign=music&utm_content=290204">Matthew Vakalyuk</a> from <a href="https://pixabay.com/sound-effects//?utm_source=link-attribution&utm_medium=referral&utm_campaign=music&utm_content=290204">Pixabay</a>
- https://pixabay.com/sound-effects/mouse-click-290204/

Audio Tutorial - https://www.youtube.com/watch?v=7e6GJtm3FU4&list=PLgOEwFbvGm5o8hayFB6skAfa8Z-mw4dPV&index=11

Font - Copyright 2001 The Silkscreen Project Authors (https://github.com/googlefonts/silkscreen)
This Font Software is licensed under the SIL Open Font License, Version 1.1 . This license is copied below, and is also available with a FAQ at: https://openfontlicense.org

SIL OPEN FONT LICENSE Version 1.1 - 26 February 2007

Pause Menu Tutorial - https://www.youtube.com/watch?v=2pk1PPlS5Xs&list=PLgOEwFbvGm5o8hayFB6skAfa8Z-mw4dPV&index=15
message.txt
4 KB

