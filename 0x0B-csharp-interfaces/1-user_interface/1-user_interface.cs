using System;

///<summary> abstract Base class </summary>
abstract class Base
{
  public string name = "";

	public override string ToString()
	{
		return (this.name + " is a " + this.GetType().ToString());
	}
}

/// <summary> Int. Interface </summary>
interface IInteractive
{
    void Interact();
}

/// <summary> Breakable </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary> Collectable </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();

}

/// <summary> Inherits from Base and all interfaces </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
	public int durability { get; set; }
	public bool isCollected { get; set; }

  /// <summary> When the object interacts with something </summary>
	public void Interact()
	{

	}

  /// <summary> Takes place when the object brakes. </summary>
	public void Break()
	{

	}

  /// <summary> Takes place when the object collects something.</summary>
	public void Collect()
	{

	}
}