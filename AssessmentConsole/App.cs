using System;
using System.Collections.Generic;
using System.Linq;
using Assessment;

namespace AssessmentConsole
{
    public class App
    {
        public bool ProcessOption(string option) 
        {
            if (option == "1")
            {
                StartPagination();
                return false;
            }
            return true;
        }

        private void StartPagination()
        {
            string option = GetOption(
                @"Pagination commands
                1. Source data
                0. Back
                ");
             if (option == "1")
            {
                ProcessPagination();
            }
        }

        private void ProcessPagination()
        {
            string option = GetOption(
                @"Type:
                1. Comma separated data(,)
                2. Pipe separated data(|)
                3. Space separated data( )
                0. Go Back
                ");
            if (option == "1" ) 
            {
                string data = GetOption("Source data");
                NavigateData(data, option);
            }
            if (option == "2" )
            {
                string data = GetOption("Source data");
                NavigateData(data, option);
            }
            if (option == "3")
            {
                string data = GetOption("Source data");
                NavigateData(data, option);
            }
        }

        private void NavigateData(string data, string option)
        {
            string pageSize = GetOption("Type the Page size");
            IElementsProvider<string> provider = new StringProvider();
            IPagination<string> pagination = new PaginationString(data, int.Parse(pageSize), provider);
            DoNavigation(pagination);
        }

        private void DoNavigation(IPagination<string> pagination)
        {
            bool exit = false;
            while(!exit)
            {
                Console.WriteLine("Current Page:");
                 string option = GetOption(
                @"Type: \n
                1. First page
                2. Next page
                3. Previous page
                4. Last page
                5. Go to page
                0. Go Back
                ");
                string[] list = pagination.Get().ToArray();
                int tamano = list.Length;
                int paginas = pagination.paginas();
                int ind = 0;
                if (option == "1")
                {
                   
                    for (int i=0 ;ind<paginas;ind++)
                    {
                        Console.Write(list[ind]+ " ");
                       
                    }
                }
                if (option == "2")
                {
                    
                    for (int i = paginas; ind < paginas; i++)
                    {
                        Console.Write(list[i] + " ");
                        
                    }
                    ind = paginas;
                }

            
                else if (option == "0")
                {
                    exit = true;
                }
                if (option == "3")
                {   

                    for (int i = paginas; ind < paginas; i++)
                    {
                        Console.Write(list[i] + " ");

                    }
                    ind = paginas;
                }
                else if (option == "0")
                {
                    exit = true;
                }
                if (option == "4")
                {
                    pagination.GetVisibleItems();
                }
                else if (option == "0")
                {
                    exit = true;
                }
                if (option == "5")
                {
                    pagination.GetVisibleItems();
                }
                else if (option == "0")
                {
                    exit = true;
                }
                if (option == "4") 
                {
                    pagination.GetVisibleItems();
                } else if (option == "0")
                {
                    exit = true;
                }
            }
    
        }

        

        private string GetOption(string message)
        {
            Console.WriteLine(message);
            Console.Write("> ");
            return Console.ReadLine();
        }
    }
}