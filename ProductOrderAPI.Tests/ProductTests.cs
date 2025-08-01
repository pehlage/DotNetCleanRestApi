using ProductOrderAPI.Domain.Entities;
using Xunit;

namespace ProductOrderAPI.Tests;

public class ProductTests
{
    [Fact]
    public void Product_ShouldHave_ValidName()
    {
        var product = new Product { Name = "Notebook", Price = 1999.99M };
        Assert.NotNull(product.Name);
    }
}
