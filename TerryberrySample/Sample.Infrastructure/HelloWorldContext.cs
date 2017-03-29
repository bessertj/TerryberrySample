using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TerryberrySample.Sample.Domain.Entities;

namespace TerryberrySample.Sample.Infrastructure
{
    public class HelloWorldContext
    {
        public HelloWorldContext()
        {
            HelloWorldEntities = new List<HelloWorld>();
            for (var i = 0; i <= 9; i++)
            {
                HelloWorldEntities.Add(new HelloWorld { Message = "hello world" });
            }
        }

        public List<HelloWorld> HelloWorldEntities { get; set; }
    }
}