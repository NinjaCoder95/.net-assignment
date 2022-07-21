# .net-assignment

Assignment 4

What is singleton.?

Singleton objects are same for every object and every request. It creates a single instance throughout the application. It creates the instance for the first time and reuses the same object in the all calls.


What is Transient.?

In transient objects are always different, each time a new instance is provided to every controller and every service. Transient lifetime services are created each time they are requested. This is best for lightweight, stateless services.


What is Scoped.?

Scoped objects are the same within a request, but different across different requests. Scoped lifetime services are created once per request within the scope. It is equivalent to a singleton in the current scope
