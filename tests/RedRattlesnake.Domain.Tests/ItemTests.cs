using RedRattlesnake.Domain;

namespace RedRattlesnake.Domain.Tests;

[TestClass]
public class ItemTests
{
    [TestMethod]
    public void Can_Create_Add_Rating()
    {
        var item= new Item("Name", "Description", "Brand", 10.00m);
        var rating= new RatingTests(5,"Name", "Review");

        item.AddRating(rating);

        Assert.AreEqual(rating, item.Ratings[0]);
    }
    [TestMethod]
    public void Cannot_Create_New_Item()
    {
        var item = new Item("Name", "Description", "Brand", 10.00m);

        Assert.AreEqual("Name", Item.Name);
        Assert.AreEqual("Name", Item.Description);
        Assert.AreEqual("Name", Item.Brand);
        Assert.AreEqual(10.00m, Item.Price);
    }
}