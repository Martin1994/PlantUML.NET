using System;
using System.Linq.Expressions;
using System.Text;
using System.Reflection;
using java.awt.color;
using java.io;
using java.util.function;
using net.sourceforge.plantuml;

using Console = System.Console;

namespace WebPlantUml
{

    public static class Program
    {

        public static int Main(string[] args)
        {
            String graphics = typeof(ikvm.awt.DummyGraphicsEnvironment).AssemblyQualifiedName;

            IKVM.Runtime.AotInitializer.AssemblyReferenceOverride = new Dictionary<Assembly, Assembly[]>()
            {
                { typeof(Program).Assembly, new Assembly[] { typeof(SourceStringReader).Assembly } },
                { typeof(SourceStringReader).Assembly, new Assembly[] { typeof(java.lang.System).Assembly } }
            };

            java.lang.System.setProperty("java.home", @"C:\Program Files\Amazon Corretto\jdk1.8.0_342\jre");
            java.lang.System.setProperty("java.awt.graphicsenv", graphics);
            java.lang.System.setProperty("java.awt.headless", "true");

            SourceStringReader reader = new SourceStringReader(args[0]);
            ByteArrayOutputStream os = new ByteArrayOutputStream();
            reader.outputImage(os, new FileFormatOption(FileFormat.SVG));
            os.close();

            Console.WriteLine(Encoding.UTF8.GetString(os.toByteArray()));
            return 0;
        }
    }
}
