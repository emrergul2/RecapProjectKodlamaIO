using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecapProject.Core.Utilities.Result
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}