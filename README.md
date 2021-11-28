#RateLimiter Sample

A basic Rate Limiter Sample for user-based rate-limiting for 100 requests per hour.

Basic Assumption

1. UserId, is passed in the header 
2. UserId "Admin" does not have any restriction over the rule
3. InMemory is used to store the values so, the state is not considered for this project. 

Rules

1. UserId has 100 requests per hour
2. If exceeded 429 error is returned.

Test

1. Postman
