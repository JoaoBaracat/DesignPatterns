using System;
using System.Collections.Generic;
using System.Text;

namespace SearchEngine.SearchEngineMechanisms
{
    public class DataIndexers
    {
        public int[] GetIndexesOfStoredData(string query)
        {
            Console.WriteLine($"{query} can be found at index: 1, 5, 8");
            return new[]{ 1, 5, 8};
        }

    }
}
