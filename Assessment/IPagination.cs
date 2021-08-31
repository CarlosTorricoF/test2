using System.Collections.Generic;

namespace Assessment
{
    public interface IPagination<T>
    {
        /// <summary>Moves cursor to the previous page. It should return an InvalidOperationException 
        /// when there is no previous page.</summary>
        void PrevPage();
        int paginas();

        /// <summary>Moves cursor to the next page. It should return an InvalidOperationException 
        /// when there is no next page.</summary>
        void NextPage();

        /// <summary>Moves cursor to the first page</summary>
        IEnumerable<T> FirstPage();
        IEnumerable<T> Get();

        /// <summary>Moves cursor to the last page</summary>
        IEnumerable<T> LastPage();

        /// <summary>Moves cursor directly to the specified page. It should return an InvalidOperationException 
        /// when the page is not valid. Invalid values are: negative numbers, a value that exceeds the number of pages </summary>
        IEnumerable<T> GoToPage(int page);

        //// <summary>Returns the current page</summary>
        int CurrentPage();

        //// <summary>Returns the number of pages</summary>
        int Pages();

        //// <summary>Returns the elements that are visible in the current page</summary>
        IEnumerable<T> GetVisibleItems();
    }
}