﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssertMessage.Fody.SourceCode
{
    public interface ISourceCodeProvider
    {
        string[] GetSourceCode(string path);
    }
}