using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Telerik.WinControls.UI;

namespace Telerik.Examples.WinControls.GridView.RowDetails
{
    public class RowDetailsLayout : TableViewRowLayout
    {
        int systemWidth;
        SizeF availableSize;

        public override void InvalidateRenderColumns()
        {
            base.InvalidateRenderColumns();
            systemWidth = 0;
            foreach (GridViewColumn column in this.RenderColumns)
            {
                if (!(column is GridViewDataColumn))
                {
                    systemWidth += column.Width + Owner.CellSpacing;
                }
            }
            if (systemWidth > 0)
            {
                systemWidth -= Owner.CellSpacing;
            }
        }

        public override SizeF MeasureRow(SizeF availableSize)
        {
            SizeF desiredSize = base.MeasureRow(availableSize);
            this.availableSize = availableSize;
            return desiredSize;
        }

        public override RectangleF ArrangeCell(RectangleF clientRect, GridCellElement cell)
        {
            RowDetailsGrid grid = (RowDetailsGrid)Owner.GridViewElement.GridControl;
            if (cell.ColumnInfo == grid.DetailsColumn)
            {
                cell.StretchHorizontally = true;
                cell.BypassLayoutPolicies = true;
                if (cell.RowElement.IsCurrent)
                {
                    return new RectangleF(0, Owner.RowHeight, availableSize.Width - systemWidth, grid.DetailsRowHeight - Owner.RowHeight);
                }
                else
                {
                    return RectangleF.Empty;
                }
            }

            if (cell is GridDataCellElement)
            {
                clientRect.Height = Owner.RowHeight;
            }

            return base.ArrangeCell(clientRect, cell);
        }
    }
}
