using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        //Arrange
        Dictionary<string, int> fruits = new Dictionary<string, int>()
        {
            ["lemon"] = 10,
            ["orange"] = 20
        };
        string curentFruit = "lemon";
        //Act
        int result = Fruits.GetFruitQuantity(fruits, curentFruit);
        //Assert
        Assert.That(result, Is.EqualTo(10));


    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int> fruits = new Dictionary<string, int>()
        {
            ["lemon"] = 10,
            ["orange"] = 20
        };
        string curentFruit = "kivi";
        //Act
        int result = Fruits.GetFruitQuantity(fruits, curentFruit);
        //Assert
        Assert.That(result, Is.EqualTo(0));

    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int> fruits = new ();
        string curentFruit = "kivi";
        //Act
        int result = Fruits.GetFruitQuantity(fruits, curentFruit);
        //Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        //Arrange
        Dictionary<string, int> fruits = null;
       
        string curentFruit = "kivi";
        //Act
        int result = Fruits.GetFruitQuantity(fruits, curentFruit);
        //Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        Dictionary<string, int> fruits = new Dictionary<string, int>()
        {
            ["lemon"] = 10,
            ["orange"] = 20
        };
        string curentFruit = null;
        //Act
        int result = Fruits.GetFruitQuantity(fruits, curentFruit);
        //Assert
        Assert.That(result, Is.EqualTo(0));
    }
}
