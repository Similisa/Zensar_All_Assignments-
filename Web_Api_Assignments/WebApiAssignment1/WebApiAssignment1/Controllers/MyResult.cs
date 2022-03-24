﻿using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace WebApiAssignment1.Controllers
{
    internal class MyResult : IHttpActionResult
    {
        string val;
        HttpRequestMessage req;
        public MyResult(string value, HttpRequestMessage request)
        {
            val = value;
            req = request;
        }
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage()
            {
                Content = new StringContent(val),
                RequestMessage = req
            };
            return Task.FromResult(response);
        }
    }
}