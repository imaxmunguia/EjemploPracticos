using System;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.Themes;
 
namespace Telerik.Examples.WinControls.Carousel.CarouselSettings
{
    public partial class Form1 : ShapedForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radComboAutoLoop.DataSource = Enum.GetNames(typeof(AutoLoopDirections));
            this.radTitleBar.TitleBarElement.SetValue(RadFormElement.IsFormActiveProperty, true);
            this.radCarouselDemo.AutoLoopDirection = AutoLoopDirections.Forward;
            this.radCheckEnableLooping.Checked = this.radCarouselDemo.EnableLooping = true;
            this.radSpinRestoreDuration.Value = this.radCarouselDemo.AutoLoopPauseInterval;
            this.radSpinVisibleElements.Value = this.radCarouselDemo.VisibleItemCount;
            this.radCheckAutoLoop.Checked = this.radCarouselDemo.EnableAutoLoop;
            this.radCheckVirtualMode.Checked = this.radCarouselDemo.VirtualMode;
        }

        private void radCheckBox2_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radCarouselDemo.VirtualMode = this.radCheckVirtualMode.Checked;
        }

        private void radCheckBox3_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.radCarouselDemo.EnableAutoLoop = this.radCheckAutoLoop.Checked;
        }

        private void radComboAutoLoop_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            AutoLoopDirections direction = (AutoLoopDirections)this.radComboAutoLoop.SelectedIndex;
            this.radCarouselDemo.AutoLoopDirection = direction;
        }

        private void radSpinEditor2_ValueChanged(object sender, EventArgs e)
        {
            this.radCarouselDemo.AutoLoopPauseInterval = (int)this.radSpinRestoreDuration.Value;
        }

        private void OnVisibleItemsCount_ValueChanged(object sender, EventArgs e)
        {
            int itemCount;

            if (int.TryParse(this.radSpinVisibleElements.Value.ToString(), out itemCount))
            {
                this.radCarouselDemo.VisibleItemCount = itemCount;
            }
        }

        private void OnEnableLooping_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            this.radCarouselDemo.EnableLooping = this.radCheckEnableLooping.Checked;
        }
    }
}