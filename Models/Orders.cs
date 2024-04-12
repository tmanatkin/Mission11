﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace Intex.Models;
public partial class Orders
{
    public int? TransactionId { get; set; }
    [Required]
    public int? CustomerId { get; set; }
    [Required]
    public DateTime? Date { get; set; }
    [Required]
    public string? DayOfWeek { get; set; }
    [Required]
    public byte? Time { get; set; }
    [Required]
    public string? EntryMode { get; set; }
    [Required]
    public short? Amount { get; set; }
    [Required]
    public string? TypeOfTransaction { get; set; }
    [Required]
    public string? CountryOfTransaction { get; set; }
    [Required]
    public string? ShippingAddress { get; set; }
    [Required]
    public string? Bank { get; set; }
    [Required]
    public string? TypeOfCard { get; set; }
    public string? Fraud { get; set; }
}