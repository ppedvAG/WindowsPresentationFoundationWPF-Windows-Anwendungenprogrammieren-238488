﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace M014.Models;

[Index("CategoryId", Name = "CategoriesProducts")]
[Index("CategoryId", Name = "CategoryID")]
[Index("ProductName", Name = "ProductName")]
[Index("SupplierId", Name = "SupplierID")]
[Index("SupplierId", Name = "SuppliersProducts")]
public partial class Product
{
    [Key]
    [Column("ProductID")]
    public int ProductId { get; set; }

    [Required]
    [StringLength(40)]
    public string ProductName { get; set; }

    [Column("SupplierID")]
    public int? SupplierId { get; set; }

    [Column("CategoryID")]
    public int? CategoryId { get; set; }

    [StringLength(20)]
    public string QuantityPerUnit { get; set; }

    [Column(TypeName = "money")]
    public decimal? UnitPrice { get; set; }

    public short? UnitsInStock { get; set; }

    public short? UnitsOnOrder { get; set; }

    public short? ReorderLevel { get; set; }

    public bool Discontinued { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("Products")]
    public virtual Category Category { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [ForeignKey("SupplierId")]
    [InverseProperty("Products")]
    public virtual Supplier Supplier { get; set; }
}