using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms.Design;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.Primitives;
using System.Runtime.CompilerServices;

namespace Telerik.WinControls.UI
{
    ///<exclude/>
    /// <summary>
    /// The root element of ScrollPanel has 2 scrollbars and handles them.
    /// Its child is a LayoutPanel that handles the arrangement of elements
    /// in the ScrollPanel.
    /// </summary>
    [
    ToolboxItem(false),
    DefaultProperty("Value"),
    DefaultEvent("Scroll")
    ]
#if RIBBONBAR
    internal class RadTestScrollView : RadControl
#else
    public class RadTestScrollView : RadControl
#endif
    {
        private RadScrollViewer scrollView;

        private FillPrimitive background;
        private ArrowPrimitive arrow;
        private RectanglePrimitive rectangle;

        #region Events
        public new event RadScrollPanelHandler Scroll;
        public event ScrollNeedsHandler ScrollNeedsChanged;
        public event RadPanelScrollParametersHandler ScrollParametersChanged;
        #endregion

        public RadTestScrollView()
        {
            backgroundAdded = false;
            arrowAdded = false;
            squareAdded = false;
        }

        #region Properties
        public Point MinValue
        {
            get
            {
                return this.scrollView.MinValue;
            }
        }

        public Point MaxValue
        {
            get
            {
                return this.scrollView.MaxValue;
            }
        }

        public Point Value
        {
            get
            {
                return this.scrollView.Value;
            }
            set
            {
                this.scrollView.Value = value;
            }
        }

        public bool UsePhysicalScrolling
        {
            get
            {
                return this.scrollView.UsePhysicalScrolling;
            }

            set
            {
                this.scrollView.UsePhysicalScrolling = value;
            }
        }
        #endregion

        #region Operations
        private bool backgroundAdded;
        public void ManageBackground()
        {
            if (background == null)
                return;

            if (backgroundAdded)
                scrollView.Children.Remove(background);
            else
                scrollView.Children.Insert(0, background);
            backgroundAdded = !backgroundAdded;

            Invalidate();
            this.RootElement.InvalidateMeasure();
        }

        private bool squareAdded;
        public void ManageSquare()
        {
            if (squareAdded)
                scrollView.Viewport.Children.Remove(rectangle); //.Items.Remove(rectangle);
            else
                scrollView.Viewport.Children.Add(rectangle); // .Items.Add(rectangle);
            squareAdded = !squareAdded;

            Invalidate();
            this.RootElement.InvalidateMeasure();
        }

        private bool arrowAdded;
        public void ManageTriangle()
        {
            if (arrowAdded)
                scrollView.Viewport.Children.Remove(arrow); // .Items.Remove(arrow);
            else
                scrollView.Viewport.Children.Add(arrow); // .Items.Add(arrow);
            arrowAdded = !arrowAdded;

            Invalidate();
            this.RootElement.InvalidateMeasure();
        }

        public void ScrollToTriangle()
        {
            if (arrowAdded)
                scrollView.ScrollElementIntoView(arrow);
        }

        public void ScrollToSquare()
        {
            if (squareAdded)
                scrollView.ScrollElementIntoView(rectangle);
        }

        public void SetHorizontalState(ScrollState newState)
        {
            if (scrollView != null && scrollView.HorizontalScrollState != newState)
            {
                scrollView.HorizontalScrollState = newState;
                scrollView.InvalidateMeasure();
            }
        }

        public void SetVerticalState(ScrollState newState)
        {
            if (scrollView != null && scrollView.VerticalScrollState != newState)
            {
                scrollView.VerticalScrollState = newState;
                scrollView.InvalidateMeasure();
            }
        }
        #endregion

        protected virtual void OnScroll(ScrollPanelEventArgs args)
        {
            if (Scroll != null)
            {
                Scroll(this, args);
            }
        }

        protected virtual void OnScrollNeedsChanged(ScrollNeedsEventArgs args)
        {
            if (ScrollNeedsChanged != null)
            {
                ScrollNeedsChanged(this, args);
            }
        }

        protected virtual void OnScrollParametersChanged(RadPanelScrollParametersEventArgs args)
        {
            if (ScrollParametersChanged != null)
            {
                ScrollParametersChanged(this, args);
            }
        }

        protected override void CreateChildItems(RadElement parent)
        {
            RadCanvasViewport viewport = new RadCanvasViewport();

            this.scrollView = new RadScrollViewer(viewport);
            this.scrollView.AutoSizeMode = RadAutoSizeMode.FitToAvailableSize;
            this.scrollView.Scroll += delegate(object sender, ScrollPanelEventArgs args) { OnScroll(args); };
            this.scrollView.ScrollNeedsChanged += delegate(object sender, ScrollNeedsEventArgs args) { OnScrollNeedsChanged(args); };
            this.scrollView.ScrollParametersChanged += delegate(object sender, RadPanelScrollParametersEventArgs args) { OnScrollParametersChanged(args); };

            this.rectangle = new RectanglePrimitive();
            this.rectangle.AutoSize = false;
            this.rectangle.SetBounds(10, 10, 190, 190);
            this.rectangle.ForeColor = Color.Black;
            this.rectangle.BackColor = Color.Aqua;

            this.arrow = new ArrowPrimitive();
            this.arrow.AutoSize = false;
            this.arrow.SetBounds(210, 210, 190, 190);
            this.arrow.ForeColor = Color.Black;
            this.arrow.BackColor = Color.Wheat;

            this.RootElement.Children.Add(this.scrollView);
            foreach (RadElement child in this.scrollView.Children)
            {
                if (child.Class == "RadScrollViewFill" && child is FillPrimitive)
                {
                    background = (FillPrimitive)child;
                    break;
                }
            }

            this.backgroundAdded = true;
            this.scrollView.Viewport.Children.Add(rectangle);
            this.squareAdded = true;
            this.scrollView.Viewport.Children.Add(arrow);
            this.arrowAdded = true;


            this.ThemeName = "";
        }
    }
}
