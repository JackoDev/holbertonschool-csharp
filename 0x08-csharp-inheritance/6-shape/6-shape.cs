﻿using System;

/// <summary> A shape class </summary>
class Shape
{
/// <summary> Not implemented method Area()</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
/// <summary> A Rectangle class that inherits from Shape </summary>
class Rectangle : Shape 
{
    private int width;
    private int height;
    
    /// <summary> Gets and sets Rectangle's width </summary>
    public int Width {
        get { return width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    /// <summary> Gets ans sets Rectangle's heigth </summary>
    public int Height {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }

}