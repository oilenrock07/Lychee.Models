using Lychee.Models.Interfaces;
using System;
using System.Net;

namespace Lychee.Models
{
    public class ResultData<T> : IResultData<T>
    {
        public T Data { get; }
        public int HttpCode { get; }
        public string ErrorMessage { get; }
        public Exception Exception { get; }

        public string Response { get; set; }

        public ResultData(T data)
        {
            Data = data;
            HttpCode = (int)HttpStatusCode.OK;
        }

        public ResultData(string errorMessage, Exception ex)
        {
            ErrorMessage = errorMessage;
            Exception = ex;
        }

        public ResultData(T data, int httpCode, string errorMessage, Exception exception, string response)
        {
            Data = data;
            HttpCode = httpCode;
            ErrorMessage = errorMessage;
            Exception = exception;
            Response = response;
        }
    }
}
