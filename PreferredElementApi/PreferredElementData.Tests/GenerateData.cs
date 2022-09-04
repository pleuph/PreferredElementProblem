using PreferredElementData.Models;
using System;
using System.Collections.Generic;
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

            // Simulate a segmented design id (xx.xx.xx)
            for (int i = 100000; i < 1000000; i += 100000)
                for (int j = 1000; j < 10000; j += 1000)
                    for (int k = 10; k < 100; k += 10)
                    {
                        // Randomize number of color codes for a brick (1-8)
                        var noOfColors = random.Next(1, 9);
                        var colors = Enumerable.Range(0, noOfColors)
                            .Select(a => new BrickColorCode { 
                                // Randomize each color code
                                ColorCodeId = random.Next(1, 7),
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

        //[Fact(Skip = "Data generation")]
        [Fact]
        public void GenerateItems()
        {
            var context = new DesignTimePreferredElementDbContext().CreateDbContext(null);

            var random = new Random();

            var bricks = context.Bricks.ToArray();

            for (int i = 0; i < 100000; i++)
            {
                // Randomize number of bricks (1-8)
                var noOfBricks = random.Next(1, 9);

                var itemBricks = new List<ItemBrick>();
                for(int j = 0; j < noOfBricks; j++)
                {
                    // Pick a random brick
                    var brickId = bricks[random.Next(0, bricks.Length)].Id;

                    // Avoid duplicates
                    while(itemBricks.Any(a => a.BrickId == brickId))
                        brickId = bricks[random.Next(0, bricks.Length)].Id;

                    // Randomize amount (1-99)
                    var amount = random.Next(1, 100);

                    itemBricks.Add(new ItemBrick { BrickId = brickId, Amount = amount });
                }

                // For now we'll only add a single master data record
                var masterData = new MasterData { 
                    Status = (ItemStatus)random.Next(0, 5),
                    Price = (decimal)random.Next(1, 100000) / 100                    
                };

                var item = new Item {
                    ItemBricks = itemBricks,
                    MasterDatas = new List<MasterData> { masterData }
                };

                context.Items.Add(item);
            }

            context.SaveChanges();
        }
    }
}