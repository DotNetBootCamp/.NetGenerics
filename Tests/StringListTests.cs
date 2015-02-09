using NUnit.Framework;
using Source;

namespace Tests
{
    [TestFixture]
    public class StringListTests
    {
        [Test]
        public void Given_Nothing_When_ICreatAnewList_Then_TheListShouldNotBeNull_And_TheLengthShouldBeZero()
        {
            var stringList = new StringList();
            Assert.NotNull(stringList);
            Assert.AreEqual(0, stringList.Length);
        }

        
        [Test]
        public void Given_AnEmptyStringList_When_IAddOneItemToIt_Then_TheLengthShouldBeOne()
        {
            var stringList = new StringList();
            stringList.Add("potato");
            Assert.AreEqual(1, stringList.Length);
        }

        [Test]
        public void Given_AListWithOneItem_When_ICallGetZero_Then_IShouldRecieveThatItem()
        {
            const string itemToAdd = "potato";
            var stringList = new StringList();
            stringList.Add(itemToAdd);
            var output = stringList.Get(0);
            Assert.AreEqual(output, itemToAdd);
        }

        [Test]
        public void Given_AListWithTwoItems_When_ICallGetOne_Then_IShouldRecieveTheLastItem()
        {
            const string itemToAdd = "potato";
            const string itemToAdd2 = "potato2";
            var stringList = new StringList();
            stringList.Add(itemToAdd);
            stringList.Add(itemToAdd2);
            var output = stringList.Get(1);
            Assert.AreEqual(output, itemToAdd2);
        }
        [Test]
        public void Given_AListWithThreeItems_When_ICallRemoveOne_Then_TheLengthShouldBe2_And_OnlyItemOneAndThreeShouldBeThere()
        {
            const string itemToAdd = "potato";
            const string itemToAdd2 = "potato2";
            const string itemToAdd3 = "potato2";
            var stringList = new StringList();
            stringList.Add(itemToAdd);
            stringList.Add(itemToAdd2);
            stringList.Add(itemToAdd3);
            stringList.Remove(1);
            Assert.AreEqual(2, stringList.Length);
            var output1 = stringList.Get(0);
            Assert.AreEqual(output1, itemToAdd);
            var output2 = stringList.Get(1);
            Assert.AreEqual(output2, itemToAdd3);
        }
    }
}
