using System;
using System.Collections.Generic;

namespace DogFactsSamples
{
    public class MyFactData
    {
        public MyFactData()
        {
        }
        public static IEnumerable<MyFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        public string Image { get; set; }
        static MyFactData()
        {
            List<MyFactData> all = new List<MyFactData>();
            all.Add(new MyFactData() { TheFact = "I like shopping at Target", ShortFact = "Target", Image="target.jpg" });
            all.Add(new MyFactData() { TheFact = "I had a road trip during the spring break", ShortFact = "Indianna", Image = "indianna.jpeg" });
            all.Add(new MyFactData() { TheFact = "I love my hair color", ShortFact = "Black", Image = "happy.jpg" });
            all.Add(new MyFactData() { TheFact = "Noodle is one of my favorite food", ShortFact = "Spaghetti", Image = "spagetti.jpg" });
            all.Add(new MyFactData() { TheFact = "I don't have any pets", ShortFact = "Pet", Image = "pet.jpeg" });
            All = all;

        }
    }
}