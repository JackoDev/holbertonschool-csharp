using System;

///<summary> Class for que opperations</summary>
class Queue<T>
{
	///<summary> Check for the Queue's type </summary>
	///<return> Returns the Queue's type </return>
	public Type CheckType()
	{
		return typeof(T);
	}
}