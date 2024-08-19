using System;
using ClassLibrary;
using System.Management.Automation;

namespace MyModule
{
    [Cmdlet(VerbsDiagnostic.Test,"SampleCmdlet")]
    public class TestSampleCmdletCommand : PSCmdlet
    {
        protected override void ProcessRecord()
        {
            Console.WriteLine("Test");
            Class1 myObject = new();
            myObject.Init(@"D:\dev\eod");
		}
    }
}
