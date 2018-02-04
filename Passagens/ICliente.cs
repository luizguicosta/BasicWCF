﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    [ServiceContract]
    public interface ICliente
    {
        [OperationContract]
        void Add(Cliente c);

        [OperationContract]
        Cliente Get(string nome);
    }
}
