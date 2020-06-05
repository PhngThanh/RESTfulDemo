using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTfulDemo.Models
{
    public class ResponseResult
    {
        public string Message { get; set; }
        public object Data { get; set; }

        public ResponseResult(string message, object data)
        {
            Message = message;
            Data = data;
        }

        public ResponseResult()
        {
        }
    }
}