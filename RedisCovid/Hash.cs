﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;
namespace RedisCovid
{
    internal class Hash
    {
        private string? HashName { get; set; }
        private HashEntry[]? HashFields { get; set; }  
    }
}
