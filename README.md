# Abstraction ( as classes and methods )

<h1>Abstract Classes and Methods</h1>
Data abstraction is the process of hiding certain details and showing only essential information to the user.
Abstraction can be achieved with either abstract classes or interfaces (which you will learn more about in the next chapter).

in the Geeks4Geeks website the definition is "In C#, an abstract class is a class that cannot be instantiated. Instead, it serves as a base class for other classes to inherit from. Abstract classes are used to define a common set of behaviors or properties that derived classes should have."
The abstract keyword is used for classes and methods:

Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).

Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
An abstract class can have both abstract and regular methods:


<h2>from the lessons it is said</h2>
- Another impact of making a class abstract is that you can no longer create an instance of that class. A reference to that class is fine (that is what we have in ShapeManager) but we can't create a new Shape without knowing what shape that is. 

- This is where abstraction comes in handy. Instead of making a virtual method we can make an abstract method and then we don't have to provide an implementation. You can only create an abstract method inside an abstract class, so both the method and the class have to be made abstract.

- an abstract method and then we don't have to provide an implementation
![image](https://github.com/DanialPersian/AbstractionC-/assets/146435665/995d58df-12c8-4994-b6c9-c8f1ec3e6b38) ![image](https://github.com/DanialPersian/AbstractionC-/assets/146435665/6f710c81-9f2d-46bd-a2c0-5356db29852f)

Here we have the files i have made and i have started using folders aswel !

