using ConsoleApp1;
using System.Collections.Generic;

var list = new List<Product>()
{
    new Product()
    {
        Id = 1,
        Name = "Tomato",
        Description = "Nice one"
    },

    new Product()
    {
        Id = 2,
        Name = "Potato",
        Description = "Nice two"
    },

    new Product()
    {
        Id = 3,
        Name = "Tree",
        Description = "Oak"
    },

    new Product()
    {
        Id = 4,
        Name = "Cucumber",
        Description = "So long"
    },

    new Product()
    {
        Id = 5,
        Name = "Pen",
        Description = "Red ink"
    },

    new Product()
    {
        Id = 6,
        Name = "Glass",
        Description = "Be careful"
    }
};

var result = Utils.Map(list);
var t = string.Join(Environment.NewLine, result.Select(x => string.Format($"{x.Name} {x.Description}")).ToArray());
Console.WriteLine(t);
Console.ReadKey();