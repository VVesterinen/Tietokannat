using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Test1.Data;

namespace Test1
{
    class Program
    {
        static readonly TestContext _testContext = new TestContext();
        static void Main(string[] args)
        {
           var persons =  _testContext.Test.ToList();
           foreach (var p in persons)
           {
               Console.WriteLine($"Id: {p.Id}, Firstname: {p.FirstName}, Lastname: {p.LastName}");
           }

           var persons1 = _testContext.Test.Include(t => t.Test2).ToList();
           foreach (var p in persons1)
           {
               Console.WriteLine($"Id: {p.Id}, Firstname: {p.FirstName}, Lastname: {p.LastName}");
               foreach (var n in p.Test2)
               {
                   Console.WriteLine(n.Phone);
               }
           }
        }
    }
}