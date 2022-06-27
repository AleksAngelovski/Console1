using Console1.MeList;

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

            int currentElementCount = testList.count;
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

            int currentElementCount = testList.count;
            int currentArrayLength = testList.GetInternalArrayLength();

            Assert.True(currentElementCount <= currentArrayLength);
        }
    }
}