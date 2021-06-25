class Vector
{
    public float X { get; private set; } // read everywhere, change in class Vector
    public float Y { get; private set; } // read everywhere, change in class Vector

    public Vector(float x = 0, float y = 0) // constructor, (?) x = 0, в случае если ничего не передавали.
    {
        X = x;
        Y = y;
    }

    public Vector Normalized => Length != 0 ? new Vector(X / Length, Y / Length) : Zero;

    public float Length => MathF.Sqrt(MathF.Pow(X, 2) + MathF.Pow(Y, 2));

    public static Vector Zero => new Vector(0, 0); // static method Zero, returns the zero point

    public static Vector operator +(Vector first, Vector second) => new Vector(first.X + second.X, first.Y + second.Y);
    public static Vector operator -(Vector first, Vector second) => new Vector(first.X - second.X, first.Y - second.Y);
    public static Vector operator *(Vector vector, float value) => new Vector(vector.X * value, vector.Y * value);
    public static Vector operator *(float value, Vector vector) => vector * value;
    public static Vector operator /(Vector vector, float value) => new Vector(vector.X / value, vector.Y / value);
    public static bool operator ==(Vector first, Vector second) => first.X == second.X && first.Y == second.Y;
    public static bool operator !=(Vector first, Vector second) => first.X != second.X || first.Y != second.Y;

    public override bool Equals(object obj) => obj.GetType() == GetType() && (Vector)obj == this;
    public override int GetHashCode() => HashCode.Combine(X, Y);
    public override string ToString() => "(" + X.ToString() + "; " + Y.ToString() + ")";

}