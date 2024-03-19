using Homework.Models;

Shape shape = new Shape();
shape.Name = "Homework Shapes";
shape.Color = "Red";
shape.Position = new int[]{ 1, 5, 6, 7 , 8 ,9};

shape.Move();


shape.getArea();
shape.getPerimeter();   


Rectangle rectangle = new Rectangle();
rectangle.SideA = 4;
rectangle.SideB = 6;

rectangle.getArea();
rectangle.getPerimeter();

Rectangle rectangle1 = new Rectangle();

rectangle1.SideA = 158;
rectangle1.SideB = 258;

rectangle1.getPerimeter();
rectangle1.getArea();

Circle circle = new Circle();
circle.Radius = 15;
circle.Color = "Blue"; // we can use the color proprety of the shape 

circle.getPerimeter();
circle.getArea();   

Circle circle2 = new Circle();  

circle2.Radius = 158;
circle2.getPerimeter();
circle2.getArea();
