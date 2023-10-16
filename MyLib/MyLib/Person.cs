using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyLib
{
    public class Person
    {
        string name;
        public Person(string name)
        {
            this.name = name;
        }
        public void Print() => Console.WriteLine($"Name: {name}");
    }
}