﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public abstract class BaseService
    {
        public List<Error> Errors { get; set; } = new List<Error>();

    }
}
