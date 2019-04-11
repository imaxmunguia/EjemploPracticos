using System.Drawing;
using Telerik.WinControls.Paint;
using System.ComponentModel;

namespace Telerik.WinControls.Primitives
{
    /// <summary>Represents a rectangle that is drawn on the sceen.</summary>
    public class RectanglePrimitive : BasePrimitive
    {
        /// <summary><para>Initializes a new instance of the RectanglePrimitive class.</para></summary>
        public RectanglePrimitive()
        {
            this.AutoSizeMode = RadAutoSizeMode.Auto;
        }

        /// <summary>Draws the primitive on the screen.</summary>
        public override void PaintPrimitive(IGraphics graphics, float angle, SizeF scale)
        {
            graphics.DrawRectangle(new Rectangle(0, 0, Size.Width - 1, Size.Height - 1), ForeColor);
        }
    }
}