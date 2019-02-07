﻿
public class EqualityScale<T>
{
    public T Left { get; set; }
    public T Right { get; set; }

    public EqualityScale(T left, T right)
    {
        Left = left;
        Right = right;
    }

    public bool AreEqual()
    {
        return Left.Equals(Right);
    }
}

