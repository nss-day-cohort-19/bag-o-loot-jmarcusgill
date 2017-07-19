using System;
using System.Collections.Generic;
using System.Linq;

namespace BagOLoot
{
    public class SantaHelper
    {
        public int AddToyToBag(string toy, int child) // signature 
        {
            return 4;
        }
        public List<int> GetChildsToyList(int childId)
        {
            return new List<int>() {4, 6, 7, 8};
        }

        public List<int> getChildsToyList(int childId)
        {
            return  new List<int>() {2, 3, 4, 777};
        }

        public void RemoveToyFromBag(int toyId)
        {

        }
        public List<int> ChildToyList(int childId)
        {
            return new List<int>();
        }

        public bool ToyIsDelivered(int childId, int toyId)
        {
            return true;
        }
    }
}
