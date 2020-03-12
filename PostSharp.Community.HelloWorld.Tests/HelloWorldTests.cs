using System;
using System.IO;
using Xunit;

namespace PostSharp.Community.HelloWorld.Tests
{
    public class HelloWorldTests
    {
        private readonly StringWriter sw = new StringWriter();
        public HelloWorldTests()
        {
            // Capture console output.
            Console.SetOut(sw); 
        }
        
        [Fact]
        public void MainTest()
        {
            Assert.Equal(42, new DeepThought().ReturnTheAnswer());
            Assert.Equal("Hello, world!Hello, world!Thinking...", sw.ToString().Replace("\r","").Replace("\n",""));
        }
        
        [Fact]
        public void MainControlTest()
        {
            new NoEnhancement().NormalMethod();
            Assert.Equal("", sw.ToString());
             // The method NormalMethod is not annotated, neither is its class or its assembly, so the method
             // won't be affected.
        }
    }

    public class NoEnhancement
    {
        public void NormalMethod()
        {
            
        }
        
    }
    [HelloWorld] 
     // Because HelloWorldAttribute is a MulticastAttribute, and it's set to target methods only, if we annotate 
     // a class with it, it will instead apply to all of its methods.
    public class DeepThought
    {
        public int ReturnTheAnswer()
        {
            Think();
            return 42;
        }

        private void Think()
         // Private methods are also methods, and will be affected. You could exclude them by configuring
         // multicasting (for example, with [HelloWorld(AttributeTargetMemberAttributes = MulticastAttributes.Public)]).
        {
            Console.WriteLine("Thinking...");
        }
    }
}