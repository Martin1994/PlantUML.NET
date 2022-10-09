using System.Text;
using java.io;
using java.nio.charset;
using net.sourceforge.plantuml;

namespace PlantUML
{
    public static class LiteRun
    {
        public static int Main(string[] args)
        {
            String graphics = typeof(ikvm.awt.NetGraphicsEnvironment).AssemblyQualifiedName;
            java.lang.System.setProperty("java.awt.graphicsenv", graphics);
            java.lang.System.setProperty("java.awt.headless", "true");

            string source = @"
@startuml
Bob -> Alice : 你好！
@enduml
";

            SourceStringReader reader = new SourceStringReader(source, StandardCharsets.UTF_8);

            ByteArrayOutputStream os = new ByteArrayOutputStream();
            reader.outputImage(os, new FileFormatOption(FileFormat.SVG));
            os.close();

            System.Console.WriteLine(Encoding.UTF8.GetString(os.toByteArray()));
            return 0;
        }
    }
}
