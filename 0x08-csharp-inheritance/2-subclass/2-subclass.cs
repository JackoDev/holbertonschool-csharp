using System;

/// <summary> To represent a Obj class </summary>
class Obj
    {
    /// <summary> Verifies if obj is a subclass </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return true;
        return false;
    }
}