﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace M016.Model;

[Keyless]
[Table("KundenUmsatz")]
public partial class KundenUmsatz
{
    [Required]
    [StringLength(20)]
    public string LastName { get; set; }

    [Required]
    [StringLength(10)]
    public string FirstName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HireDate { get; set; }

    [StringLength(60)]
    public string Address { get; set; }

    [StringLength(15)]
    public string City { get; set; }

    [StringLength(15)]
    public string Region { get; set; }

    [StringLength(10)]
    public string PostalCode { get; set; }

    [StringLength(15)]
    public string Country { get; set; }

    [StringLength(24)]
    public string HomePhone { get; set; }

    [Column(TypeName = "money")]
    public decimal? Salary { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RequiredDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ShippedDate { get; set; }

    [Column("OrderID")]
    public int OrderId { get; set; }

    public int Expr1 { get; set; }

    [Column(TypeName = "money")]
    public decimal? Freight { get; set; }

    public int Expr2 { get; set; }

    [Required]
    [StringLength(40)]
    public string Expr3 { get; set; }

    [StringLength(24)]
    public string Expr4 { get; set; }

    [Column("ProductID")]
    public int ProductId { get; set; }

    [Required]
    [StringLength(40)]
    public string ProductName { get; set; }

    [StringLength(20)]
    public string QuantityPerUnit { get; set; }

    [Column(TypeName = "money")]
    public decimal? UnitPrice { get; set; }

    public int Expr5 { get; set; }

    public int Expr6 { get; set; }

    public short Quantity { get; set; }

    public float Discount { get; set; }

    [Column(TypeName = "money")]
    public decimal Expr7 { get; set; }

    [Required]
    [Column("CustomerID")]
    [StringLength(5)]
    public string CustomerId { get; set; }

    [Required]
    [StringLength(40)]
    public string CompanyName { get; set; }

    [StringLength(30)]
    public string ContactName { get; set; }

    [StringLength(30)]
    public string ContactTitle { get; set; }

    [StringLength(60)]
    public string Expr8 { get; set; }

    [StringLength(15)]
    public string Expr9 { get; set; }

    [StringLength(15)]
    public string Expr10 { get; set; }

    [StringLength(10)]
    public string Expr11 { get; set; }

    [StringLength(15)]
    public string Expr12 { get; set; }

    [StringLength(24)]
    public string Phone { get; set; }

    [StringLength(24)]
    public string Fax { get; set; }
}