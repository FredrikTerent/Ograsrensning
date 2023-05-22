﻿namespace OgraasApi.Models
{
	public class Cell
	{
        public Weed? Weed { get; set; }
        public bool IsOccupied { get { return Weed != null; } }
        public bool IsHit { get; set; }
    }
}