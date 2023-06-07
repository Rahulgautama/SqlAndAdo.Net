using System;
using System.Data.SqlClient;

namespace SqlAdo.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            AdoDotNet ado = new AdoDotNet();
            ado.Select();
        }
    }
}
