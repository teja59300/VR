using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if(!context.Activities.Any())
            {
                var activities = new List<Activity>()
                {
                        new Activity
                        {
                            Title = "Past Activity 1",
                            Date = DateTime.Now.AddMonths(-2),
                            Description = "Activity 2 months ago",
                            Category = "FoodCrops",
                            City = "WestGodavari",
                            Venue = "Pentapadu",
                        },
                        new Activity
                        {
                            Title = "Past Activity 2",
                            Date = DateTime.Now.AddMonths(-1),
                            Description = "Activity 1 month ago",
                            Category = "CashCrops",
                            City = "Penugonda",
                            Venue = "Tadepalligudem",
                        },
                        new Activity
                        {
                            Title = "Future Activity 1",
                            Date = DateTime.Now.AddMonths(1),
                            Description = "Activity 1 month in future",
                            Category = "CashCrops",
                            City = "WestGodavari",
                            Venue = "Tanuku",
                        },
                        new Activity
                        {
                            Title = "Future Activity 2",
                            Date = DateTime.Now.AddMonths(2),
                            Description = "Activity 2 months in future",
                            Category = "PlantationCrops",
                            City = "WestGodavari",
                            Venue = "Bhimavaram",
                        },
                        new Activity
                        {
                            Title = "Future Activity 3",
                            Date = DateTime.Now.AddMonths(3),
                            Description = "Activity 3 months in future",
                            Category = "FoodCrops",
                            City = "WestGodavari",
                            Venue = " Pentapadu",
                        },
                        new Activity
                        {
                            Title = "Future Activity 4",
                            Date = DateTime.Now.AddMonths(4),
                            Description = "Activity 4 months in future",
                            Category = "FoodCrops",
                            City = "WestGodavari",
                            Venue = "  Pentapadu",
                        },
                        new Activity
                        {
                            Title = "Future Activity 5",
                            Date = DateTime.Now.AddMonths(5),
                            Description = "Activity 5 months in future",
                            Category = "FoodCrops",
                            City = "WestGodavari",
                            Venue = "  Pentapadu",
                        },
                        new Activity
                        {
                            Title = "Future Activity 6",
                            Date = DateTime.Now.AddMonths(6),
                            Description = "Activity 6 months in future",
                            Category = "PlantationCrops",
                            City = "WestGodavari",
                            Venue = "Tanuku",
                        },
                        new Activity
                        {
                            Title = "Future Activity 7",
                            Date = DateTime.Now.AddMonths(7),
                            Description = "Activity 2 months ago",
                            Category = "HorticultureCrops",
                            City = "WestGodavari",
                            Venue = " Tadepalligudem",
                        },
                        new Activity
                        {
                            Title = "Future Activity 8",
                            Date = DateTime.Now.AddMonths(8),
                            Description = "Activity 8 months in future",
                            Category = "Other ",
                            City = "WestGodavari",
                            Venue = "Tadepalligudem",
                        }

                };

                context.Activities.AddRange(activities);
                context.SaveChanges();

            }
        }
    }
}