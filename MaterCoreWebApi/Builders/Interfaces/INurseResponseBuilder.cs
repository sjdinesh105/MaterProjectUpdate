﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaterCore.WebApi.Builders.Interfaces
{
    public interface INurseResponseBuilder
    {
        List<Mater.Data.Models.Nurse> GetNurse();
    }
}
