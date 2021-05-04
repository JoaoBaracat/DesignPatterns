using System;

namespace SearchEngine
{
    class Program
    {
        static void Main(string[] args)
        {

            var searchEngineFacade = new SearchEngineFacade();
            var searchingResults = searchEngineFacade.GetSearchingResults("My query");

            Console.WriteLine(searchingResults);

            Console.ReadKey();

        }
    }
}
