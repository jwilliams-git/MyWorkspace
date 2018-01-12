using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieMVC.Models
{
    public class Tile
    {
        public string TileId { get; set; }
        public string TileDesc { get; set; }
        public string EmployeeId { get; set; }
        public GridLocation LocationX { get; set; }
        public GridLocation LocationY { get; set; }
        public string ReadUri { get; set; }
        public string UpdateUri { get; set; }
    }

    public class GridLocation
    {
        public int Start { get; set; }
        public int End { get; set; }
    }
}