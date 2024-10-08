﻿using bethanyPieShop.InventoryManagement.Domain.General;
using bethanyPieShop.InventoryManagement.Domain.Contracts;

namespace bethanyPieShop.InventoryManagement.Domain.ProductManagement
{
    public class RegularProduct:Product, ISaveable
    {
        public RegularProduct(int id, string name, string? description, Price price, UnitType unitType, int maxAmountInStock) : base(id, name, description, price, unitType, maxAmountInStock)
        {
        }

        public override void IncreasStock()
        {
            AmountInStock++;
        }

        public string ConvertToStringForSaving()
        {
            return $"{Id};{Name};{Description};{maxItemsInStock};{Price.ItemPrice};{(int)Price.Currency};{(int)UnitType};4;";
        }

        public override object Clone()
        {
            return new RegularProduct(0, this.Name, this.Description, new Price() { ItemPrice = this.Price.ItemPrice, Currency = this.Price.Currency }, this.UnitType, this.maxItemsInStock);
        }
    }
}
