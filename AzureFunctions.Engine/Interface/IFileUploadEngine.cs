﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AzureFunction.Engine.Interface
{
    public interface IFileUploadEngine
    {
        Task<bool> IsMultipartContent(HttpRequest request);
    }
}
