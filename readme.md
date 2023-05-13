# HTX Labs Assesment

1. How do you determine if a 3D point lies inside a 3D sphere?
To determine if a 3D point lies inside of a 3D sphere, I would use the distance formula listed below:

`distance = sqrt((x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2)`

For example if the sphere had a center of `(0,0,0)` and a radius of `5` and there was a point of `(3,4,5)` that was the point in question, I can calculate the distance using the formula:

`distance = sqrt((0 - 3)^2 + (0 - 4)^2 + (0 - 5)^2)`

`distance = sqrt((-3)^2 + (-4)^2 + (-5)^2)`

`distance = sqrt(9 + 16 + 25)`

`distance = sqrt(50)`

`distance = 7.07`

Since this is out of range between the distance of `0` to `5` the point `(3,4,5)` is out of range of the 3D Sphere.

2. The following diagram contains 5 squares in a 2x2 configuration (four 1x1 + one 2x2):
Implement a function in either C++ or C# that takes a parameter of N, where N is the size of
the NxN matrix of any size greater than 0 and returns the total number of squares in the
matrix. For example, in C++ the function signature looks like this:

3. Design the interface for a game particle system in C#. The system should support creating
multiple particle groups in the game world. Show only the interface to the system, without
implementation. Assume the existence of any math libraries or other systems you need for the
interface:
- Each particle group has a type id that defines (via a lookup table not shown here) the number of
particles, the lifetime of each particle, the velocities of the particles, etc.
- Given a type id, particle groups can be created.
- Particle groups are attached to models, placed at a location, or exist only in screen space.
- Particle groups can be scaled and rotated.
- Particle groups can be ended early.

**See the folder here:** [HtxLabs](src/HtxLabs/)

4. Define a list of unit tests to validate an implementation of the particle system interface from the
previous question.

1. Test Case: creating a new particle group with a valid type ID.
	- Assert the particle group has the expected properties such as particle count, lifetime, and velocities.
	- Assert the particle group is added to the system's list of active particle groups.

2. Test Case: attaching a particle group to a model.
	- Assert the particle group is properly attached to the model.
	- Assert the particle group's position and orientation matches that of the model.

3. Test Case: placing a particle group at a location.
	- Assert the particle group is placed at the specified location.
	- Assert the particle group's position and orientation are not affected by the location change.

4. Test Case: placing a particle group in screen space.
	- Assert the particle group is placed in screen space.
	- Assert the particle group's position and orientation are not affected by the screen space placement.

5. Test Case: scaling a particle group.
	- Assert the particle group is scaled by the given factor.
	- Assert the particle group's position and orientation are not affected by the scaling.

6. Test Case: rotating a particle group.	
	- Assert the particle group is rotated by the given angle.
	- Assert the particle group's position and orientation are updated correctly.

7. Test Case: ending a particle group early.
	- Assert the particle group is no longer active and is removed from the system's list of active particle groups.

8. Test Case: creating a new particle group with an invalid type ID.
	- Assert an exception is thrown indicating that the type ID is invalid.
	- Assert the system's list of active particle groups is not modified.

8. Test Case: attempting to attach a particle group to an invalid model.
	- Assert an exception is thrown indicating that the model is invalid.
	- Assert the system's list of active particle groups is not modified.

9. Test Case: attempting to end an inactive particle group.
	- Assert an exception is thrown indicating that the particle group is not active.
	- Assert the system's list of active particle groups is not modified.

5. Write a boid system in C# or JS. You can use any libraries or tech you want. The only stipulation
is that the system needs to simulate a flying insect swarm instead of the normal birds/fish. The
deliverable on this is the code as well as a screenshot (or video) that you think best exemplifies the
behavior.

6. Consider an e-commerce system that will support multiple forms of payment, a shopping cart,
discount codes, targeted marketing…basically imagine Amazon. Describe the minimum viable product
for that system.
- The minimum viable product for this system would be:
	- User registration and authentication: where users can log in, log out, track order history, access their shopping cart, and modify account information of their own.
	- Product Catalog: Products with images, description, and price based on items they'd want to purchase.
	- Shopping Cart: Enabling users to add items to their cart and adjust the quantity.
	- Payment system (or integrations using a 3rd party tool): support for credit or debit card payment along with platforms such as stripe or paypal.
	- Discount codes: allow users to enter discount codes for their order.
	- Order Confirmation and Tracking: details should be provided to the customer on their order purchase, and tracking details of shipment and arrival to establish transparency.
	- Targeted marketing: a consent agreement should be used to send personalized marketing content such as emails to customers based off their search and purchase history.

7. If you have a database that is getting overloaded with a large number of requests per second,
how would you generally diagnose and fix the issue?
- Monitor the database performances: use monitoring tools to track database performance and metrics to identify bottlenecks and performance issues. (Use something like [Datadog](https://www.datadoghq.com/) or [Sumologic](https://www.sumologic.com/) 
- Caching: impliment caching strategies to reduce database requests and improve performance. (Use something like [redis](https://redis.com/)