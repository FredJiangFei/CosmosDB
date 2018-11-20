using System;
using CrossPartitionQueries;
using Microsoft.Azure.Documents.Client;

namespace LearnCosmosDB
{
    class Program
    {
        static void Main(string[] args)
        {
            CrossPartitionQueriesDemo.Run().Wait();
        }
    }
}
