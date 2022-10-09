using System.Runtime.Serialization;
using java.awt;

namespace ikvm.awt
{
    public class NetFontMetrics : java.awt.FontMetrics
    {
        public NetFontMetrics(Font font) : base(font)
        {
        }

        public NetFontMetrics(SerializationInfo info, StreamingContext ctx) : base(info, ctx)
        {
        }

        public override int charWidth(char ch)
        {
            return font.getSize();
        }

        public override int charsWidth(char[] data, int off, int len)
        {
            return font.getSize() * len;
        }
    }
}