using System;
using Telerik.WinControls.UI;
using System.Drawing;
using Telerik.WinControls;

namespace Telerik.Examples.WinControls.ChartView.FirstLook
{
    public class LegendItemElement : LightVisualElement
    {
        StackLayoutElement stack;
        LightVisualElement box;
        LightVisualElement text;

        public LegendItemElement(string text, Color color)
        {
            this.text.Text = text;
            this.box.BackColor = color;
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            stack = new StackLayoutElement();
            stack.FitInAvailableSize = true;
            stack.StretchHorizontally = false;
            stack.StretchVertically = false;
            stack.ShouldHandleMouseInput = false;
            stack.NotifyParentOnMouseInput = true;
            this.Children.Add(stack);

            box = new LightVisualElement();
            box.DrawFill = true;
            box.DrawBorder = true;
            box.GradientStyle = GradientStyles.Solid;
            box.BorderGradientStyle = GradientStyles.Solid;
            box.BorderColor = Color.White;
            box.MinSize = new System.Drawing.Size(15, 15);
            box.Padding = new System.Windows.Forms.Padding(4);
            box.StretchHorizontally = false;
            box.StretchVertically = false;
            box.ShouldHandleMouseInput = false;
            box.NotifyParentOnMouseInput = true;
            stack.Children.Add(box);

            text = new LightVisualElement();
            text.DrawFill = false;
            text.DrawBorder = false;
            text.ForeColor = Color.Black;
            text.Font = new System.Drawing.Font("Segoe UI", 9.0f);
            text.TextAlignment = ContentAlignment.TopLeft;
            text.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            text.StretchVertically = false;
            text.StretchHorizontally = false;
            text.ShouldHandleMouseInput = false;
            text.NotifyParentOnMouseInput = true;
            stack.Children.Add(text);
        }

        protected override void InitializeFields()
        {
            base.InitializeFields();
            this.StretchHorizontally = false;
            this.StretchVertically = false;
            this.ShouldHandleMouseInput = false;
            this.NotifyParentOnMouseInput = true;
        }

        protected override SizeF MeasureOverride(SizeF availableSize)
        {
            SizeF size = base.MeasureOverride(availableSize);
            return size;
        }
    }
}
