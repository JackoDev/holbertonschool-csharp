using System;

/// <summary> To Represent a Obj class </summary>
class Obj
{
    /// <summary> Verifies if obj is an int </summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
            return true;
        return false;
    }
}