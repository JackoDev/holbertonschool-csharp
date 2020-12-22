using System;

/// <summary> To represent an Obj class </summary>
class Obj
{
    /// <summary> Verifies if obj is an instance of a class inherited from  an Array </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (typeof(Array).IsInstanceOfType(obj))
            return true;
        return false;
    }
}