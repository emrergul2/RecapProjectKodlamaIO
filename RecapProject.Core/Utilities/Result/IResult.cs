using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecapProject.Core.Utilities.Result
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}