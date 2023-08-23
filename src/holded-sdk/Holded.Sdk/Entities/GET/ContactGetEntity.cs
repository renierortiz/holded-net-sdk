using System.Text.Json.Serialization;

namespace Holded.Sdk.Entities.GET;

public class ContactGetEntity : EntityGetBase
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("customId")]
    public string CustomId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; } = null!;

    [JsonPropertyName("vatnumber")]
    public string Vatnumber { get; set; }

    [JsonPropertyName("tradeName")]
    public string TradeName { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("mobile")]
    public string Mobile { get; set; }

    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("iban")]
    public string Iban { get; set; }

    [JsonPropertyName("swift")]
    public string Swift { get; set; }

    [JsonPropertyName("groupId")]
    public string GroupId { get; set; }

    [JsonPropertyName("clientRecord")]
    public int? ClientRecord { get; set; }

    [JsonPropertyName("supplierRecord")]
    public int? SupplierRecord { get; set; }

    [JsonPropertyName("billAddress")]
    public BillAddressGetEntity BillAddress { get; set; }

    [JsonPropertyName("customFields")]
    public List<object> CustomFields { get; set; }

    [JsonPropertyName("defaults")]
    public Defaults Defaults { get; set; }

    [JsonPropertyName("socialNetworks")]
    public List<object> SocialNetworks { get; set; }

    [JsonPropertyName("tags")]
    public List<object> Tags { get; set; }

    [JsonPropertyName("notes")]
    public List<object> Notes { get; set; }

    [JsonPropertyName("contactPersons")]
    public List<object> ContactPersons { get; set; }

    [JsonPropertyName("shippingAddresses")]
    public List<object> ShippingAddresses { get; set; }

    [JsonPropertyName("isperson")]
    public int? Isperson { get; set; }

    [JsonPropertyName("createdAt")]
    public int? CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public int? UpdatedAt { get; set; }

    [JsonPropertyName("updatedHash")]
    public string UpdatedHash { get; set; }
}

public class Defaults
{
    [JsonPropertyName("salesChannel")]
    public int? SalesChannel { get; set; }

    [JsonPropertyName("expensesAccount")]
    public int? ExpensesAccount { get; set; }

    [JsonPropertyName("dueDays")]
    public int? DueDays { get; set; }

    [JsonPropertyName("paymentDay")]
    public int? PaymentDay { get; set; }

    [JsonPropertyName("paymentMethod")]
    public int? PaymentMethod { get; set; }

    [JsonPropertyName("discount")]
    public int? Discount { get; set; }

    [JsonPropertyName("language")]
    public string Language { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; }

    [JsonPropertyName("salesTax")]
    public List<object> SalesTax { get; set; }

    [JsonPropertyName("purchasesTax")]
    public List<object> PurchasesTax { get; set; }

    [JsonPropertyName("accumulateInForm347")]
    public string AccumulateInForm347 { get; set; }
}