using java.awt;
using java.awt.font;
using java.awt.geom;
using java.awt.image;
using java.awt.image.renderable;
using java.text;
using java.util;

namespace ikvm.awt
{

    public class DummyGraphicsEnvironment : GraphicsEnvironment
    {

        public override bool isHeadlessInstance()
        {
            return true;
        }

        public override Graphics2D createGraphics(BufferedImage bi)
        {
            return new DummyGraphics2D();
        }

        public override Font[] getAllFonts()
        {
            return getAvailableFontFamilyNames().Select(name => new Font(name, 0, 1)).ToArray();
        }

        public override string[] getAvailableFontFamilyNames()
        {
            return new string[] { "monospace", "sans-serif", "serif" };
        }

        public override string[] getAvailableFontFamilyNames(Locale l)
        {
            return getAvailableFontFamilyNames();
        }

        public override GraphicsDevice getDefaultScreenDevice()
        {
            throw new HeadlessException();
        }

        public override GraphicsDevice[] getScreenDevices()
        {
            return new GraphicsDevice[0];
        }
    }

    internal class DummyGraphics2D : Graphics2D
    {
        public override void addRenderingHints(Map hints)
        {
            throw new NotImplementedException();
        }

        public override void clearRect(int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }

        public override void clip(Shape s)
        {
            throw new NotImplementedException();
        }

        public override void clipRect(int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }

        public override void copyArea(int x, int y, int width, int height, int dx, int dy)
        {
            throw new NotImplementedException();
        }

        public override Graphics create()
        {
            throw new NotImplementedException();
        }

        public override void dispose()
        {
            throw new NotImplementedException();
        }

        public override void draw(Shape s)
        {
            throw new NotImplementedException();
        }

        public override void drawArc(int x, int y, int width, int height, int startAngle, int arcAngle)
        {
            throw new NotImplementedException();
        }

        public override void drawGlyphVector(GlyphVector g, float x, float y)
        {
            throw new NotImplementedException();
        }

        public override bool drawImage(Image img, AffineTransform xform, ImageObserver obs)
        {
            throw new NotImplementedException();
        }

        public override void drawImage(BufferedImage img, BufferedImageOp op, int x, int y)
        {
            throw new NotImplementedException();
        }

        public override bool drawImage(Image img, int x, int y, ImageObserver observer)
        {
            throw new NotImplementedException();
        }

        public override bool drawImage(Image img, int dx1, int dy1, int dx2, int dy2, int sx1, int sy1, int sx2, int sy2, ImageObserver observer)
        {
            throw new NotImplementedException();
        }

        public override bool drawImage(Image img, int x, int y, int width, int height, ImageObserver observer)
        {
            throw new NotImplementedException();
        }

        public override bool drawImage(Image img, int x, int y, Color bgcolor, ImageObserver observer)
        {
            throw new NotImplementedException();
        }

        public override bool drawImage(Image img, int x, int y, int width, int height, Color bgcolor, ImageObserver observer)
        {
            throw new NotImplementedException();
        }

        public override bool drawImage(Image img, int dx1, int dy1, int dx2, int dy2, int sx1, int sy1, int sx2, int sy2, Color bgcolor, ImageObserver observer)
        {
            throw new NotImplementedException();
        }

        public override void drawLine(int x1, int y1, int x2, int y2)
        {
            throw new NotImplementedException();
        }

        public override void drawOval(int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }

        public override void drawPolygon(int[] xPoints, int[] yPoints, int nPoints)
        {
            throw new NotImplementedException();
        }

        public override void drawPolyline(int[] xPoints, int[] yPoints, int nPoints)
        {
            throw new NotImplementedException();
        }

        public override void drawRenderableImage(RenderableImage img, AffineTransform xform)
        {
            throw new NotImplementedException();
        }

        public override void drawRenderedImage(RenderedImage img, AffineTransform xform)
        {
            throw new NotImplementedException();
        }

        public override void drawRoundRect(int x, int y, int width, int height, int arcWidth, int arcHeight)
        {
            throw new NotImplementedException();
        }

        public override void drawString(string str, int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void drawString(string str, float x, float y)
        {
            throw new NotImplementedException();
        }

        public override void drawString(AttributedCharacterIterator iterator, int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void drawString(AttributedCharacterIterator iterator, float x, float y)
        {
            throw new NotImplementedException();
        }

        public override void fill(Shape s)
        {
            throw new NotImplementedException();
        }

        public override void fillArc(int x, int y, int width, int height, int startAngle, int arcAngle)
        {
            throw new NotImplementedException();
        }

        public override void fillOval(int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }

        public override void fillPolygon(int[] xPoints, int[] yPoints, int nPoints)
        {
            throw new NotImplementedException();
        }

        public override void fillRect(int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }

        public override void fillRoundRect(int x, int y, int width, int height, int arcWidth, int arcHeight)
        {
            throw new NotImplementedException();
        }

        public override Color getBackground()
        {
            throw new NotImplementedException();
        }

        public override Shape getClip()
        {
            throw new NotImplementedException();
        }

        public override Rectangle getClipBounds()
        {
            throw new NotImplementedException();
        }

        public override Color getColor()
        {
            throw new NotImplementedException();
        }

        public override Composite getComposite()
        {
            throw new NotImplementedException();
        }

        public override GraphicsConfiguration getDeviceConfiguration()
        {
            throw new NotImplementedException();
        }

        public override Font getFont()
        {
            throw new NotImplementedException();
        }

        public override FontMetrics getFontMetrics(Font f)
        {
            return new DummyFontMetrics(f);
        }

        public override FontRenderContext getFontRenderContext()
        {
            return new FontRenderContext(new AffineTransform(), true, true);
        }

        public override Paint getPaint()
        {
            throw new NotImplementedException();
        }

        public override object getRenderingHint(RenderingHints.Key hintKey)
        {
            throw new NotImplementedException();
        }

        public override RenderingHints getRenderingHints()
        {
            throw new NotImplementedException();
        }

        public override Stroke getStroke()
        {
            throw new NotImplementedException();
        }

        public override AffineTransform getTransform()
        {
            throw new NotImplementedException();
        }

        public override bool hit(Rectangle rect, Shape s, bool onStroke)
        {
            throw new NotImplementedException();
        }

        public override void rotate(double theta)
        {
            throw new NotImplementedException();
        }

        public override void rotate(double theta, double x, double y)
        {
            throw new NotImplementedException();
        }

        public override void scale(double sx, double sy)
        {
            throw new NotImplementedException();
        }

        public override void setBackground(Color color)
        {
            throw new NotImplementedException();
        }

        public override void setClip(int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }

        public override void setClip(Shape clip)
        {
            throw new NotImplementedException();
        }

        public override void setColor(Color c)
        {
            throw new NotImplementedException();
        }

        public override void setComposite(Composite comp)
        {
            throw new NotImplementedException();
        }

        public override void setFont(Font font)
        {
            throw new NotImplementedException();
        }

        public override void setPaint(Paint paint)
        {
            throw new NotImplementedException();
        }

        public override void setPaintMode()
        {
            throw new NotImplementedException();
        }

        public override void setRenderingHint(RenderingHints.Key hintKey, object hintValue)
        {
            // throw new NotImplementedException();
            return;
        }

        public override void setRenderingHints(Map hints)
        {
            // throw new NotImplementedException();
            return;
        }

        public override void setStroke(Stroke s)
        {
            throw new NotImplementedException();
        }

        public override void setTransform(AffineTransform Tx)
        {
            throw new NotImplementedException();
        }

        public override void setXORMode(Color c1)
        {
            throw new NotImplementedException();
        }

        public override void shear(double shx, double shy)
        {
            throw new NotImplementedException();
        }

        public override void transform(AffineTransform Tx)
        {
            throw new NotImplementedException();
        }

        public override void translate(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void translate(double tx, double ty)
        {
            throw new NotImplementedException();
        }
    }

    internal class DummyFontMetrics : FontMetrics
    {
        public DummyFontMetrics(Font font) : base(font)
        {
        }

        public override int getAscent()
        {
            return 0;
        }

        public override int getLeading()
        {
            return 0;
        }

        public override int getMaxAdvance()
        {
            return this.font.getSize();
        }

        public override int charWidth(char ch)
        {
            return this.font.getSize();
        }

        public override int charsWidth(char[] data, int off, int len)
        {
            return data.Select(ch => charWidth(ch)).Sum();
        }
    }
}