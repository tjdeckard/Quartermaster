﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quartermaster.Tests.Unit
{
    [TestClass]
    public class When_exploring_pools
    {
        [TestMethod]
        public void Should_be_able_to_create_a_ResourcePool()
        {
            var nw = new FakeNetwork();
            var thisPool = new ResourcePool(nw,"VESSEL", "POOL");
            Assert.IsNotNull(thisPool);
        }

        [TestMethod]
        public void Should_be_able_to_check_for_all_present_resources()
        {
            var nw = new FakeNetwork();
            var thisPool = new ResourcePool(nw,"VESSEL", "POOL");
            var thisRecipe = TestHelpers.GetSampleRecipeA();
            var expected = true;
            var actual = thisPool.CheckResources(thisRecipe);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Should_be_able_to_check_for_missing_requirements()
        {
            var nw = new FakeNetwork();
            var thisPool = new ResourcePool(nw,"VESSEL", "POOL");
            var thisRecipe = TestHelpers.GetSampleRecipeB();
            var expected = false;
            var actual = thisPool.CheckResources(thisRecipe);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_be_able_to_check_for_missing_inputs()
        {
            var nw = new FakeNetwork();
            var thisPool = new ResourcePool(nw,"VESSEL", "POOL");
            var thisRecipe = TestHelpers.GetSampleRecipeB();
            var expected = false;
            var actual = thisPool.CheckResources(thisRecipe);
            Assert.AreEqual(expected, actual);
        }
    }
}