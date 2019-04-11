using System;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.CreateRowInfo
{
    public class GridViewFilteringChildRowInfo : GridViewRowInfo
    {
        #region Intialization

        public GridViewFilteringChildRowInfo(GridViewInfo view)
            : base(view)
        {

        }

        #endregion

        #region Properties

        public override AllowedGridViewRowInfoStates AllowedStates
        {
            get { return AllowedGridViewRowInfoStates.None; }
        }

        public override Type RowElementType
        {
            get { return typeof(GridFilteringChildRowElement); }
        }

        #endregion
    }
}
