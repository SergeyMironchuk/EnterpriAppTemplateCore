﻿using System;

namespace PControl.DomainModel.CalcBalance
{
    public class Balance
    {
        public DateTime Date { get; set; }
        public Product Product { get; set; }
        public double Quantity { get; set; }

        public override bool Equals(object obj)
        {
            return Date == ((Balance)obj).Date && Product.Id == ((Balance)obj).Product.Id;
        }

        public override int GetHashCode()
        {
            return Date.GetHashCode() + Product.GetHashCode();
        }
    }
}