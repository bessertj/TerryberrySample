using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TerryberrySample.Sample.Abstract;
using TerryberrySample.Sample.Domain.Entities;

namespace TerryberrySample.Sample.Infrastructure
{
    public class HelloWorldRepository : IHelloWorldRepository
    {
        public HelloWorldContext db = new HelloWorldContext();

        public List<HelloWorld> GetAll()
        {
            return db.HelloWorldEntities;
        }
    }
}