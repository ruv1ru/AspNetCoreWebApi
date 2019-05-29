using System.Threading.Tasks;
using Web.Core.Interfaces;
namespace Web.Core.Services
{
    public class ArrayCalculationService : IArrayCalculationService
    {
        /// <summary>
        /// Returns an array with elements reversed.
        /// </summary>
        /// <param name="source">The source array to be reversed. The returned array will be of same length.</param>
        /// <returns>The reversed array.</returns>
        public async Task<int[]> ReverseArray(int[] source)
        {
            var result = new int[source.Length];

            var resultIndex = 0; 

            //Start from the last element of the array and traverse left
            for(int i = source.Length - 1; i >= 0; i--)
            {
                result[resultIndex] = source[i];
                resultIndex++;
            }

            return result;

        }
        
        
        /// <summary>
        /// Deletes an item from a specified position of an array 
        /// </summary>
        /// <param name="position">The position of the item to be removed. Starts from 1 (not zero based index).</param>
        /// <param name="source">The source array. The returned array will be shorter.</param>
        /// <returns>The new array without the item specified by the position.</returns>
        public async Task<int[]> DeleteItem(int position, int[] source)
        {
            if(position > source.Length || position < 1) return source;
            var result = new int[source.Length - 1];

            var resultIndex = 0;

            for(int i = 0; i < source.Length; i++)
            {
                //Insert all items not in 'position'
                if(i + 1 != position)
                {
                    result[resultIndex] = source[i]; 
                    resultIndex++;
                }
            }

            return result;
        }
    }
}