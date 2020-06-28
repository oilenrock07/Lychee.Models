using System;

namespace Lychee.Models.Interfaces
{
    public interface IResultData<T>
    {
        T Data { get; }
        int HttpCode { get; }
        string ErrorMessage { get; }
        Exception Exception { get; }

        string Response { get; set; }
    }
}
