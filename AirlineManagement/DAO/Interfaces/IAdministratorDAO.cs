﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineManagement
{
    public interface IAdministratorDAO : IBasicDB<Administrator>
    {
        Administrator GetAdministratorByUsername(string name);
    }
}
