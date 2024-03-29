﻿using Orleans;
using System.Threading.Tasks;

namespace MyOrleans.Interfaces
{
    public interface IHello : IGrainWithIntegerKey
    {
        Task<string> SayHello(string value);
    }
}
