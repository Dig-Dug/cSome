namespace checkit;
using System;
//Implementing interface
public class Car : IEquatable<Car>
{
    public string? Make { get; set; }
    public string? Model { get; set; }
    public string? Year { get; set; }

    public string dd = "dodpo";

    // Implementation of IEquatable<T> interface
    public bool Equals(Car? car)
    {


        return (this.Make, this.Model, this.Year) ==
            (car?.Make, car?.Model, car?.Year);
    }
}


//public required string lol { get; set; }



//var p2 = new Example("sss");

//Inheritance
//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/inheritance

//Polymorphism
//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/polymorphism

//Generics
//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics

