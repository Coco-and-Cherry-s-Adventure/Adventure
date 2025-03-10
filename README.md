# Adventure

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
