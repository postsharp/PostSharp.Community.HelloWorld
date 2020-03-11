using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using PostSharp.Community.DeepSerializable;
using Xunit;

namespace PostSharp.Community.HelloWorld.Tests
{
    public class DeepSerializableTests
    {
        private StringWriter sw = new StringWriter();
        public DeepSerializableTests()
        {
            Console.SetOut(sw); 
        }
        
        [Fact]
        public void MainTest()
        {
            Assert.Equal(42, new DeepThought().ReturnTheAnswer());
            Assert.Contains("Hello, World!" + Environment.NewLine + "Hello, World!" + Environment.NewLine + "Thinking...", sw.ToString());
        }
        
        [Fact]
        public void MainControlTest()
        {
            new NoEnhancement().NormalMethod();
            Assert.Equal("", sw.ToString());
        }
    }

    public class NoEnhancement
    {
        public void NormalMethod()
        {
            
        }
        
    }
    [HelloWorld]
    public class DeepThought
    {
        public int ReturnTheAnswer()
        {
            Think();
            return 42;
        }

        private void Think()
        {
            Console.WriteLine("Thinking...");
        }
    }
}