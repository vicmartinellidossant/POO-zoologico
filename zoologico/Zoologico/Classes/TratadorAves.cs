﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoologico.Interfaces;

namespace Zoologico.Classes
{
    public class TratadorAves : Tratador, ICuidavel
    {

        public TratadorAves(string nome, string especialidade) : base(nome, especialidade)
        {

        }

        public void Cuidar()
        {
            Console.WriteLine($"{Nome} está cuidando de uma ave");
        }
    }
}
