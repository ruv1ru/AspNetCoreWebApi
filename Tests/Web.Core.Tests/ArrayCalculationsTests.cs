using System;
using Xunit;

namespace Web.Core.Tests
{
    
    public class ArrayCalculationsTests
    {
        [Fact]
        public async void ReverseAscArray_ShouldReturnArrayInDescOrder()
        {
            var input = new int[5]{1,2,3,4,5};

            var arrayCalcService = new Web.Core.Services.ArrayCalculationService();

            var resultArray = await arrayCalcService.ReverseArray(input);

            Assert.Equal(resultArray, new int[5]{5,4,3,2,1});

        }

        [Fact]
        public async void ReverseEmptyArray_ShouldReturnEmptyArray()
        {
            var input = new int[0]{};

            var arrayCalcService = new Web.Core.Services.ArrayCalculationService();

            var resultArray = await arrayCalcService.ReverseArray(input);

            Assert.Equal(resultArray, new int[0]{});

        }


        [Fact]
        public async void ReverseRandomArray_ShouldReturnArrayReversed()
        {
            var input = GetRandomArray(50);

            var arrayCalcService = new Web.Core.Services.ArrayCalculationService();

            var resultArray = await arrayCalcService.ReverseArray(input);

            Array.Reverse(input);

            Assert.Equal(resultArray, input);
        }


        [Fact]
        public async void DeleteElementFromArray_ShouldReturnArrayWithoutDeletedElement()
        {
            var position = 3;
            var inputArray = new int[5]{1, 2, 3, 4, 5};

            var arrayCalcService = new Web.Core.Services.ArrayCalculationService();

            var resultArray = await arrayCalcService.DeleteItem(position, inputArray);

            Assert.Equal(resultArray, new int[4]{1, 2, 4, 5});

        }


        [Fact]
        public async void TryDeleteInvalidPosition_ShouldNotDeleteAnyItem()
        {
            var position = 6;
            var inputArray = new int[5]{1, 2, 3, 4, 5};

            var arrayCalcService = new Web.Core.Services.ArrayCalculationService();

            var resultArray = await arrayCalcService.DeleteItem(position, inputArray);
            
            Assert.Equal(resultArray, new int[5]{1, 2, 3, 4, 5});

        }

        private int[] GetRandomArray(int length)
        {
            int[] test = new int[length]; 

            Random randNum = new System.Random();
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = randNum.Next(1, 100);
            }
            return test;
        }
    }
}
