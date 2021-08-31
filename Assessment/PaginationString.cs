using System.Collections.Generic;
using System.Linq;

namespace Assessment
{
    public class PaginationString : IPagination<string>
    {
        private readonly IEnumerable<string> data;
        private readonly int pageSize;
        private int currentPage;

        public PaginationString(string source, int pageSize, IElementsProvider<string> provider)
        {
            data = provider.ProcessData(source);
            currentPage = 1;
            this.pageSize = pageSize;
        }
       
        public int paginas()
        {
            return pageSize;
        }
        public IEnumerable<string> FirstPage()
        {
            IEnumerable<string> data2 = data;
            return data2;

        }

        public void GoToPage(int page)
        {
            throw new System.NotImplementedException();
        }

        public void LastPage()
        {
            throw new System.NotImplementedException();
        }

        public void NextPage()
        {
            
        }

        public void PrevPage()
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<string> Get()
        {
            return data;
        }

        public IEnumerable<string> GetVisibleItems()
        {
            return data.Skip(currentPage*pageSize).Take(5);
        }

        public int CurrentPage()
        {
            throw new System.NotImplementedException();
        }

        public int Pages()
        {
            throw new System.NotImplementedException();
        }

        void IPagination<string>.PrevPage()
        {
            throw new System.NotImplementedException();
        }

        void IPagination<string>.NextPage()
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<string> IPagination<string>.FirstPage()
        {
            throw new System.NotImplementedException();
        }

      

        IEnumerable<string> IPagination<string>.LastPage()
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<string> IPagination<string>.GoToPage(int page)
        {
            throw new System.NotImplementedException();
        }

        int IPagination<string>.CurrentPage()
        {
            throw new System.NotImplementedException();
        }

        int IPagination<string>.Pages()
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<string> IPagination<string>.GetVisibleItems()
        {
            throw new System.NotImplementedException();
        }
    }
}