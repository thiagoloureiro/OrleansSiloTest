using Orleans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrainInterfaces1
{
    public class GrainClass : Grain, IGrain1
    {
        public Task<string> SayHello(string message)
        {
            return Task.FromResult($"You said: '{message}' , I say: Hello!");
        }
    }
}
