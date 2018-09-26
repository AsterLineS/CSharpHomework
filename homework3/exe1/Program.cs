using System;

public abstract class Shape
{
    private string myId;

    public Shape(string s)
    {
        Id = s;
    }
    public string Id//类型
    {
        get
        {
            return myId;
        }
        set
        {
            myId = value;
        }
    }

    public abstract double Area//面积，抽象
    {
        get;
    }

    public virtual void Draw()
    {
        Console.WriteLine("Draw Shape Icon");
    }

    public override string ToString()
    {
        return Id + "Area="+string.Format("{0:F2}",Area);
    }
}

//正方形类
public class Square:Shape
{
    private int mySide;//边长

    public Square(int side,string id):base(id)
    {
        mySide = side;
    }

    public override double Area
    {
        get
        {
            return mySide * mySide;
        }
    }

    public override void Draw()
    {
        Console.WriteLine("Draw 4 Side:" + mySide);
    }
}

//圆类
public class Circle : Shape
{
    private int myRadius;//边长

    public Circle(int radius, string id) : base(id)
    {
        myRadius = radius;
    }

    public override double Area
    {
        get
        {
            return myRadius * myRadius*System.Math.PI;
        }
    }

    public override void Draw()
    {
        Console.WriteLine("Draw Circle:" + myRadius);
    }
}

//矩形类
public class Rectangle : Shape
{
    private int myWidth;
    private int myHeight;

    public Rectangle(int width,int height,string id) : base(id)
    {
        myHeight = height;
        myWidth = width;
    }

    public override double Area
    {
        get
        {
            return myHeight * myWidth/2;
        }
    }

    public override void Draw()
    {
        Console.WriteLine("Draw Rectangle" );
    }

}

//三角形类
public class Triangle : Shape
{
    private int mySide;
    private int myHeight;

    public Triangle(int side, int height, string id) : base(id)
    {
        myHeight = height;
        mySide = side;
    }

    public override double Area
    {
        get
        {
            return myHeight * mySide;
        }
    }

    public override void Draw()
    {
        Console.WriteLine("Draw Triangle");
    }

}

public class TextClass
{
    public static void Main()
    {
        Shape[] shapes =
        {
            new Square(5,"Square #1"),
            new Circle(3,"Circle #1"),
            new Rectangle(4,5,"Rectangle #1"),
            new Triangle(4,5,"Triangle #1"),
        };

        System.Console.WriteLine("Shapes Collection");
        foreach(Shape s in shapes)
        {
            System.Console.WriteLine(s);
        }
    }
}