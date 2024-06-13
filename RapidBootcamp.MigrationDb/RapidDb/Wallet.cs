﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RapidBootcamp.MigrationDb.RapidDb;

public partial class Wallet
{
    public int WalletId { get; set; }

    public int CustomerId { get; set; }

    public int WalletTypeId { get; set; }

    public decimal Saldo { get; set; }

    public virtual Customer Customer { get; set; }

    public virtual ICollection<OrderHeader> OrderHeaders { get; set; } = new List<OrderHeader>();

    public virtual WalletType WalletType { get; set; }
}