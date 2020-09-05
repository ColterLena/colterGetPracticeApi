# Get Practice API: A C# and .NET API
## Objectives

- Create a simple API
- Practice problem solving

## Requirements

- Create 2 endpoints, `/mumbling` and `/explosion`, that are based off of the katas,`[https://www.codewars.com/kata/mumbling](https://www.codewars.com/kata/mumbling)` and `[https://www.codewars.com/kata/digits-explosion(https://www.codewars.com/kata/digits-explosion)` respectfully.

- [ ] Create a new `webapi` api project
- [ ] Create a endpoint for the `mumbling` endpoint
  - [ ] Create a new Controller called `MumblingController`
  - [ ] This will have one `HttpGet` method
  - [ ] The method will accept a string either as a URL parameter or a query parameter. Your choice.
  - [ ] This endpoint method will take the string passed to it, manipulate according to the kata [https://www.codewars.com/kata/mumbling(https://www.codewars.com/kata/mumbling) and return the result
  - [ ] Have your code return the string
- [ ] Create a endpoint for the `explosion` endpoint
  - [ ] Create a new Controller called `ExplosionController`
  - [ ] This will have one `HttpGet` method
  - [ ] The method will accept a string either as a URL parameter or a query parameter. Your choice.
  - [ ] This endpoint method will take the string passed to it, manipulate according to the kata
        [https://www.codewars.com/kata/digits-explosion(https://www.codewars.com/kata/digits-explosion) and return the result
  - [ ] Have your code return the string
