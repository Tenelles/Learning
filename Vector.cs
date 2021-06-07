using System;
using System.Collections.Generic;
using System.Text;

class Vector
{
    public float X { get; private set; }
    public float Y { get; private set; }

    public Vector(float x = 0, float y = 0)
    {
        X = x;
        Y = y;
    }

    public static Vector Zero => new Vector(0, 0);

    public static Vector Plus(Vector first, Vector second) => new Vector(first.X + second.X, first.Y + second.Y);
    public static Vector Minus(Vector first, Vector second) => new Vector(first.X - second.X, first.Y - second.Y);
    public static Vector Multiply(Vector point, float number) => new Vector(point.X * number, point.Y * number);
    public static Vector Divide(Vector point, float number) => new Vector(point.X / number, point.Y / number);
    public static bool AreEqual(Vector first, Vector second) => first.X == second.X && first.Y == second.Y;

}