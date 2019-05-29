
using System;
using Web.Core.Services;
using System.Threading.Tasks;
namespace Web.Core.Interfaces
{
    public interface IArrayCalculationService
    {
        
        Task<int[]> ReverseArray(int[] source);
        Task<int[]> DeleteItem(int position, int[] source);
    }
}