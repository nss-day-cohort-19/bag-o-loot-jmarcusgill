using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class SantaHelperShould
    {
        SantaHelper _helper;

        public SantaHelperShould()
        {
            _helper = new SantaHelper();
        }

        [Fact]
        // Items can be added to bag, and assigned to a child.
        public void AddToyToChildBag() // single responsibility 
        {   
            string toyName = "Skateboard";
            int childId = 715;

            int toyId = _helper.AddToyToBag(toyName, childId);
            List<int> toys = _helper.GetChildsToyList(childId);// passing in childId to get 
                                                               // to get list of toys

            // returning T or F out of here, we are giving AddToyToBag the responsibility
            // of adding and returning value
            Assert.Contains(toyId, toys); 
        }

        [Fact]
        public void RemoveToyFromChildsBag()
        {
            int toyId = 666;
            int childId = 777;

            // remove toy from bag by passing in toyId
            _helper.RemoveToyFromBag(toyId);
            List<int> toyList = _helper.GetChildsToyList(childId);

            Assert.DoesNotContain(toyId, toyList); // checking to see that the single toy is out of the RemoveToy list.
        }

        [Fact]
        public void CheckingChildList()
        {
            int childId = 7;

            List<int> ChildToyList = _helper.GetChildsToyList(childId);
            
            Assert.True(ChildToyList.Count >= 0);
        }

        [Fact]
        public void ChildToyDeliveryComplete()
        {
            int childId = 10;
            int toyId = 15;
            var isDelivered = _helper.ToyIsDelivered(childId, toyId);
        }
    }
}