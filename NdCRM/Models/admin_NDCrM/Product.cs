using System;
using System.Collections.Generic;

namespace NdCRM.Models.admin_NDCrM;

public partial class Product
{
    public int Id { get; set; }

    public string? Productname { get; set; }

    public string? Price { get; set; }
}
