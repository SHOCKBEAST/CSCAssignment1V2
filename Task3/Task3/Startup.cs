﻿using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Owin;
using Owin;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: OwinStartup(typeof(Task3.Startup))]

namespace Task3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }


        public void ConfigurationServices(IServiceCollection services)
        {
          
           //services.Configure<ReCAPTCHASettings>(Configuration.GetSection("GooglereCAPTCHA"));
        }
    }
    
}
