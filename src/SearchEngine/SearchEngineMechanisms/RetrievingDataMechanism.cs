using System;
using System.Collections.Generic;
using System.Text;

namespace SearchEngine.SearchEngineMechanisms
{
    class RetrievingDataMechanism
    {
        public void GetData(int[] indexes)
        {
            Console.Write("Downloading web with indexes: ");
            foreach (var index in indexes)
            {
                Console.Write(index + ", ");

            }
            Console.WriteLine();
        }
    }
}
