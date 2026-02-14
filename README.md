# Overview

A Unity 2D simulation that spawns rigidbody objects on a grid and moves them according to a vector field.

# Features

- Grid-based object spawning
- Adjustable spawn area and density
- Global speed control for all objects
- Automatic object cleanup:
	- Distance-based destruction
	- Stationary-time destruction
- Maximum object count limit

# How It Works
**init** Script:

	Responsible for:

		- Initial grid spawning at scene start
		- Periodic respawning (based on updateInterval)
		- Tracking total active objects
		- Passing global parameters (speed, destroy distance) to objects

**Object** Script

	Responsible for:
		- Applying vector field velocity
		- Tracking stationary time
		- Destroying the corresponging GameObject when:
			- Too far from origin
			- Stationary for too long

# Inspector Parameters
| Parameter         | Description                                    |
| ----------------- | ---------------------------------------------- |
| prefab            | Object prefab with Rigidbody2D + Object script |
| objinc            | Grid spacing                                   |
| minXPos / maxXPos | Spawn X bounds                                 |
| minYPos / maxYPos | Spawn Y bounds                                 |
| objectSpeed       | Global speed value                             |
| updateInterval    | Time between respawn attempts                  |
| maxObjectCount    | Maximum active objects                         |
| destroyDistance   | Max squared distance before destruction        |

# Requirements
Unity (Tested with Unity 2D Physics)

# Usage
The Circle prefab in Assets/Prefabs must be attached to the rg public member in objects class.

The simulation can be run by:

	1. importing project in unity
	
	2. setting parameters
	
	3. playing the scene
