using System;

enum Rating
{
    Good,
    Great,
    Excellent
}
struct Dog
{   
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string nameDog, float ageDog, string ownerDog, Rating ratingDog)
    {
        name = nameDog;
        age = ageDog;
        owner = ownerDog;
        rating = ratingDog;
    }
}