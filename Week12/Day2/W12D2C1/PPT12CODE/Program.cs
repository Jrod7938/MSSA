using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.IO;
namespace W12D2C1
{
    class Program
    {
        static void Main(string[] args)
        {
            var assemblyunit = new CodeCompileUnit();

            var dynamicnamespace = new CodeNamespace("Demonamespace");

            
            dynamicnamespace.Imports.Add(new CodeNamespaceImport("System"));

            var progtype = new CodeTypeDeclaration("Program");
            dynamicnamespace.Types.Add(progtype);

            var mainmethod = new CodeEntryPointMethod();
            progtype.Members.Add(mainmethod);


            var expression = new CodeMethodInvokeExpression(new CodeTypeReferenceExpression("Console"), "WriteLine", new CodePrimitiveExpression("Hello.."));
            mainmethod.Statements.Add(expression);
            var expression2 = new CodeMethodInvokeExpression(new CodeTypeReferenceExpression("Console"), "WriteLine", new CodePrimitiveExpression("How Are You.."));
            mainmethod.Statements.Add(expression);
            var expression1 = new CodeMethodInvokeExpression(new CodeTypeReferenceExpression("Console"), "ReadLine");

            mainmethod.Statements.Add(expression1);



            var csharp = new CSharpCodeProvider();

            var filename = "prog.cs";

            var stream = new StreamWriter(filename);

            var textwriter = new IndentedTextWriter(stream);

            var options = new CodeGeneratorOptions();

            options.BlankLinesBetweenMembers = true;
            

            
            assemblyunit.Namespaces.Add(dynamicnamespace);

            
            csharp.GenerateCodeFromCompileUnit(assemblyunit, textwriter, options);

            textwriter.Close();

            stream.Close();



            // assembly

            var compilersettings = new CompilerParameters();
            compilersettings.ReferencedAssemblies.Add("System.dll");

            compilersettings.GenerateExecutable = true;

            compilersettings.OutputAssembly = "Demo.exe";
            compilersettings.GenerateInMemory = false;


            var results = csharp.CompileAssemblyFromFile(compilersettings,"prog.cs");

            Console.WriteLine(" Done ..");

            Console.ReadLine();

            
        }
    }
}
