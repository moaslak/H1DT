using Xunit;
using listClassFromScratch;
using System;
namespace listClassTest
{
    public class UnitTest1
    {
        listClass list = new listClass();

        static string[] array = { "1", "2", "john", "1337", "aazz", "1" };

        [Fact]
        public void testContains()
        {
            string checkTrue = "john";
            string checkFalse = "FALSE";
            Assert.True(list.contains(array, checkTrue));
            Assert.False(list.contains(array, checkFalse));

            checkTrue = "1";
            Assert.True(list.contains(array, checkTrue));
        }

        [Fact]
        public void testGetAt()
        {
            Assert.Equal("john", list.getAt(array,2));
            Assert.Equal("1", list.getAt(array,0));
            Assert.Equal("2", list.getAt(array,1));
        }

        [Fact]
        public void testGetSize()
        {
            Assert.Equal(6, list.getSize(array));
        }

        [Fact]
        public void testRemoveDuplets()
        {
            string[] expected = { "1", "2", "john", "1337", "aazz" };
            Assert.Equal(expected, list.removeDuplets(array));
        }

        [Fact]
        public void testRemoveAt()
        {
            string[] expected = { "1", "john", "1337", "aazz", "1" };
            Assert.Equal(expected, list.removeAtIndex(array, 1));
        }
    }
}
