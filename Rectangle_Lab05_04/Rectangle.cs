﻿using Project3_lab22._03_;
using System.Text;
public class Rectangle : IEquatable<Rectangle>, IPolygon, ICloneable
{
    public Point TopLeft { get; set; }
    public uint Width { get; set; }
    public uint Height { get; set; }
    
    public Rectangle(Point topLeft, uint width, uint height)
    {
        TopLeft = new Point(topLeft.X, topLeft.Y);
        Width = width;
        Height = height;
    }
    public Rectangle() : this(new Point(0, 0), 0, 0) { }

    public uint ComputeArea() => Height * Width;
    public uint ComputePerimeter() => 2 * Height + 2 * Width;

    public override bool Equals(object? obj) => Equals(obj as Rectangle);
    public Rectangle? Intersect(Rectangle other)
    {
        if (Equals(other))
            return Clone() as Rectangle;
        //Segment horizontalOther = new Segment((int)other.TopLeft.X, TopLeft.X + Width);

        return null;
    }
    public override string ToString()
    {
        return new StringBuilder("Rectangle{ ")
            .Append(TopLeft.ToString())
            .Append(" Width=")
            .Append(Width)
            .Append(" Height=")
            .Append(Height)
            .Append(" }")
            .ToString();
    }
    public bool Equals(Rectangle? other)
    {
        if (other == null)
        {
            return false;
        }
        if (object.ReferenceEquals(this, other))
        {
            return true;
        }
        if (this.GetType() != other.GetType())
        {
            return false;
        }
        return
            other.TopLeft.X == TopLeft.X &&
            other.TopLeft.Y == TopLeft.Y &&
            other.Width == Width &&
            other.Height == Height;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(TopLeft.X, TopLeft.Y, Width, Height);
    }
    public object Clone()
    {
        return new Rectangle(new Point(TopLeft.X,TopLeft.Y),Width,Height);
        //upcast, conversie in sus
    }
}