
public class Rectangle
{
    public string Id { get; private set; }
    public double Width { get; private set; }

    public double Height { get; private set; }

    public double X { get; private set; }
    public double Y { get; private set; }

    public Rectangle(string id, double width, double height, double x, double y)
    {
        Id = id;
        Width = width;
        Height = height;
        X = x;
        Y = y;
    }

    public string Intersects(Rectangle rectangle)
    {
        if ((rectangle.Y >= this.Y && rectangle.Y - rectangle.Height <= this.Y && rectangle.X <= this.X && rectangle.X + rectangle.Width >= this.X) ||
            (rectangle.Y >= this.Y && rectangle.Y - rectangle.Height <= this.Y && rectangle.X >= this.X && rectangle.X <= this.X + this.Width) ||
            (rectangle.Y <= this.Y && rectangle.Y >= this.Y - this.Height && rectangle.X <= this.X && rectangle.X + rectangle.Width >= this.X) ||
            (rectangle.Y <= this.Y && rectangle.Y >= this.Y - this.Height && rectangle.X >= this.X && rectangle.X <= this.X + this.Width))
        {
            return "true";
        }
        else
        {
            return "false";
        }
    }


}

