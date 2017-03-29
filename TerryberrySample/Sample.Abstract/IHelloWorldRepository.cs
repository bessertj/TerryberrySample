using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerryberrySample.Sample.Domain.Entities;

namespace TerryberrySample.Sample.Abstract
{
    public interface IHelloWorldRepository
    {
        List<HelloWorld> GetAll();
    }
}
