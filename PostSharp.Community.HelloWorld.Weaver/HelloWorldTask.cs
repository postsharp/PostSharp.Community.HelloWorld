using System.Collections.Generic;
using System.Reflection;
using PostSharp.Community.DeepSerializable;
using PostSharp.Extensibility;
using PostSharp.Sdk.CodeModel;
using PostSharp.Sdk.CodeModel.TypeSignatures;
using PostSharp.Sdk.Extensibility;
using PostSharp.Sdk.Extensibility.Configuration;
using PostSharp.Sdk.Extensibility.Tasks;

namespace PostSharp.Community.HelloWorld.Weaver
{
    [ExportTask(Phase = TaskPhase.Transform, TaskName = nameof(HelloWorldTask))]
    [TaskDependency("AnnotationRepository", IsRequired = true, Position = DependencyPosition.Before)]
    public class HelloWorldTask : Task
    {
    }
}