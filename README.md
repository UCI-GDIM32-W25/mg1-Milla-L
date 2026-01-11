[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
1. Milla Lucido, She/They

2. The MG1 breakdown activity connects to my MG1 because I was able to identify the two objects, player and seed, and was able to decide how to implement them as a game object and prefab respectively. I was also able to determine how to spawn the seeds, instanciate, and where to place them in relation to the player, on top in layers. I was able to determine that KeyCode.Space should be used to activate the method that planted the seeds as well as in that method create an if statement so that the seeds would stop being placed after it hit the limit, in this case five. In the breakdown, the player interacted with the UI by updating it, so in the MG1, I updated the UI by calling on private PlantCountUI to UpdateSeeds at the beginning and in the public void PlantSeeds() as it was called by the space and the seed counters needed to be increased and decreased. I made sure that the player was able to move vertically and horizontally using the WASD keys using the Input.GetAxis for each and multiplying by _speed and Time.deltaTime. The Start of the player class made sure that the UI had numbers rather than the ## symbols by setting the _numSeedsLeft = _numSeeds and the _numSeedsRemaining = 0 so that the _numSeedsLeft was set to five and the _numSeedsRemaining was set to zero. I also included the instructions on my Itch.io page like detailed in my breakdown. 

## Open-Source Assets
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
