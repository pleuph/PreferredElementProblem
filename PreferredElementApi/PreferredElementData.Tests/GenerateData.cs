using PreferredElementData.Models;
using System;
using System.Linq;
using Xunit;

namespace PreferredElementData.Tests
{
    public class GenerateData
    {
        //[Fact(Skip = "Data generation")]
        [Fact]
        public void GenerateBricks()
        {
            var context = new DesignTimePreferredElementDbContext().CreateDbContext(null);

            var random = new Random();

            for (int i = 100000; i < 1000000; i += 100000)
                for (int j = 1000; j < 10000; j += 1000)
                    for (int k = 10; k < 100; k += 10)
                    {
                        var noOfColors = random.Next(1, 8);
                        var colors = Enumerable.Range(0, noOfColors)
                            .Select(a => new BrickColorCode { 
                                ColorCodeId = random.Next(1, 6),
                                Order = a
                            }).ToList();

                        var brick = new Brick
                        {
                            DesignId = i + j + k,
                            BrickColorCodes = colors
                        };

                        context.Bricks.Add(brick);
                    }

           context.SaveChanges();
        }
    }
}