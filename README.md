# swarm
Swarming Algorithm for Virtual Drones

This project was inspired by MIT's droce swarming project at http://vertol.mit.edu/index.html

This code repository is dedicated to creating a swarming algorithm that will allow a number of virtual drones to hover over a rider(or any load) and carry them around in 3D space.  Each member traingluates with its clodest 2 neighbors and then global trajectory is passed from the manager based on User Input.  This allows for decentralization of the calculations required to keep the swarm together.  This also allows electricity to flow from a central source to keep the swarm going longer without regard for central system failure.  If the central system fails, the swarm simply lands the rider with the small batteries in each swarm member drone.
