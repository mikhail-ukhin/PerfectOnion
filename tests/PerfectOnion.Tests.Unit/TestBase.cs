using System;
using System.Reflection;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace PerfectOnion.Tests.Unit
{
    public class TestBase
    {
        protected IServiceProvider ServiceProvider;
        
        public TestBase()
        {
            ServiceProvider = new ServiceCollection()
                .AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies())
                .BuildServiceProvider();
        }
    }
}