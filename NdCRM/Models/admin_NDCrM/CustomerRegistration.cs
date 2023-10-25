using System;
using System.Collections.Generic;

namespace NdCRM.Models.admin_NDCrM;

public partial class CustomerRegistration
{
    public int Id { get; set; }

    public string? CompanyName { get; set; }

    public string? ContactPersonName { get; set; }

    public string MobileNumber { get; set; } = null!;

    public string? Email { get; set; }

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string GstNumber { get; set; } = null!;

    public string? UserId { get; set; }

    public string BillingAddress { get; set; } = null!;

    public string ProductDetails { get; set; } = null!;

    public string GenerateInvoice { get; set; } = null!;

    public DateTime? Startdate { get; set; }

    public DateTime? Renewaldate { get; set; }
}
