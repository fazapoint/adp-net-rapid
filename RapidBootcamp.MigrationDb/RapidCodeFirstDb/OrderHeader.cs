﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RapidBootcamp.MigrationDb.RapidCodeFirstDb;

public partial class OrderHeader
{
    public string OrderHeaderId { get; set; }

    public int CustomerId { get; set; }

    public DateTime TransactionDate { get; set; }

    public int? ShippingId { get; set; }

    public int? WalletId { get; set; }

    public int? PaymentId { get; set; }

    public virtual Customer Customer { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}