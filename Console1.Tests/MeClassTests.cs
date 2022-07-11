using Console1.MeList;
using FluentAssertions;

namespace Console1.Tests
{
    public class MeClassTests
    {

        [Theory]
        [InlineData(5)]
        [InlineData(100)]
        [InlineData(56)]
        public void Add_AlwaysResizes_Array(int numElements)
        {
            MeList<int> testList = new MeList<int>();
            for (int i = 0; i < numElements; i++)
            {
                testList.Add(i);
            }

            int currentElementCount = testList.Count;
            int currentArrayLength = testList.GetInternalArrayLength();

            Assert.True(currentElementCount <= currentArrayLength);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(12)]
        [InlineData(60)]
        public void Add_WithArray_AlwaysResizesArray(int numArraysToAdd)
        {
            MeList<int> testList = new MeList<int>();
            int[] arrayToAdd = new[] { 1, 2, 3, 4, 5, 6, 6, 7, 8 };
            for(int i = 0; i < numArraysToAdd; i++)
            {
                testList.Add(arrayToAdd);
            }

            int currentElementCount = testList.Count;
            int currentArrayLength = testList.GetInternalArrayLength();

            Assert.True(currentElementCount <= currentArrayLength);
        }

        [Fact]
        public void Indexing_OutOfRange_Throws_OutOfRangeException()
        {
            MeList<int> testList = new MeList<int>() { 1, 2, 3, 4, 5, 6, 6, 7, 8 };
            
            Action result = () => { var res = testList[50]; };

            Assert.Throws<IndexOutOfRangeException>(result);
        }
        [Theory]
        [InlineData(400)]
        [InlineData(34)]
        public void TrimExcess_ResetsTheCapacity_To_CorrectValue(int num_items)
        {
            MeList<int> testList = new MeList<int>();
            for(int i = 0; i < num_items; i++)
            {
                testList.Add(i);
            }

            testList.TrimExcess();
            int currentCapacity = testList.Capacity;

            Assert.True(currentCapacity == num_items);
        }
    }
}