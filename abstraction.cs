
Menu items
---------------------------------------------------------------------
namespace Summative8Practice.Menu
{
    internal abstract class MenuItem
    {
        public abstract void Select();
        //Note, because there are no methods implemented here at all we could make this an interface.
        public abstract void MenuText();
        public abstract override string ToString();

    }
    //The ConsoleMenu class has a list of MenuItem instances
    internal abstract class ConsoleMenu
    {
        protected List<MenuItem> _menuItems = new List<MenuItem>();
        //The ConsoleMenu also has a bool Property called IsActive. This is set to true when the ConsoleMenu is selected.
        public bool IsActive { get; set; }

        public abstract void CreateMenu();
    }
}
-------------------------------------------------------------------
circle.cs
namespace Summative8Practice.Shapes
{
    //Here the Circle inherits from the Shape class
    //Add those methods now using the override keyword.
    class Circle : Shape
    {
        public override float Area()
        {
            return MathF.PI * _Radius * _Radius;
        }

        public override float Perimeter()
        {
            return 2 * MathF.PI * _Radius;
        }
        public override string ToString()
        {
            return $"{ShapeColour} circle with radius {Radius}.";
        }

        public const int MIN_RADIUS = 0;
        public const int MAX_RADIUS = 50;

        private float _Radius;

        public float Radius
        {
            get { return _Radius; }
            set { if (value >= MIN_RADIUS && value <= MAX_RADIUS) { _Radius = value; } }
        }

        public Circle(float radius, Colour colour)
        {
            Radius = radius;
            ShapeColour = colour;
        }
    }
}
----------------------------------------------------------------------------
Shape.cs
//basically about shapes like square or triangle
namespace Summative8Practice.Shapes
{
    internal class Shape
    {
        // The idea here is that things that all Shapes do in the same way can be done in the Shape class, like storing information about the colour of the shape.
        public enum Colour { Red, Green, Blue }
        public Colour ShapeColour { set; get; }
        //an abstract method and then we don't have to provide an implementation. 
        public abstract float Area();
        public abstract float Perimeter();
    }
}

//Another impact of making a class abstract is that you can no longer create an instance of that class. A reference to that class is fine (that is what we have in ShapeManager) but we can't create a new Shape without knowing what shape that is. 
//This is where abstraction comes in handy. Instead of making a virtual method we can make an abstract method and then we don't have to provide an implementation. You can only create an abstract method inside an abstract class, so both the method and the class have to be made abstract.
-----------------------------------------------------------------------------
ShapeManager.cs

namespace Summative8Practice.Shapes
{
    internal class ShapeManager
    {
        public List<Shape> Shapes { get; private set; }

        public ShapeManager()
        {
            Shapes = new List<Shape>();
        }

        public void AddShape(Shape pShape)
        {
            Shapes.Add(pShape);
        }
    }
}

//The idea behind the ShapeManager is that it should be able to manage a list of shapes for us. Eventually we will use this to give us information about the list of Shapes - but for now we can just create a ShapeManager and add a Shape to it.

__________________________________________________________________________
Square.cs
namespace Summative8Practice.Shapes
{
    internal class Square : Shape
    {
        public const int MIN_SIDE = 0;
        public const int MAX_SIDE = 50;

        private float _Width;

        public float Height { get { return _Width; } }

        public Square(float width, Colour colour)
        {
            Width = width;
            ShapeColour = colour;
        }

        public float Width
        {
            get { return _Width; }
            private set { if (value >= MIN_SIDE && value <= MAX_SIDE) { _Width = value; } }
        }
        public override float Area()
        {
            return _Width * _Width;
        }

        public override float Perimeter()
        {
            return 4 * _Width;
        }

        public override string ToString()
        {
            return $"{ShapeColour} Square with width {Width}.";
        }
    }

}
-----------------------------------------------
program.cs
this is empty 
- the full code hasnt been finished 
