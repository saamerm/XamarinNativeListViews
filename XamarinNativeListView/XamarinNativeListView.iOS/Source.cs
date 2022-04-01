using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace XamarinNativeListView.iOS
{
    public class Source : UITableViewSource
    {
        private string _cellId = "AnyText";
        private List<City> _listItems;
        public Source(List<City> cities)
        {
            _listItems = cities;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(_cellId);
            //if (cell == null) cell = new UITableViewCell(UITableViewCellStyle.Default, _cellId);
            if (cell == null)  cell = new UITableViewCell (UITableViewCellStyle.Subtitle, _cellId);
            //if (cell == null)  cell = new UITableViewCell (UITableViewCellStyle.Value1,  CellId);
            //if (cell == null)  cell = new UITableViewCell (UITableViewCellStyle.Value2,  CellId);
            cell.TextLabel.Text = _listItems[indexPath.Row].Name;
            cell.DetailTextLabel.Text  = _listItems[indexPath.Row].Country;
            //cell.Accessory = UITableViewCellAccessory.DetailButton;
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _listItems.Count;
        }
    }
}
