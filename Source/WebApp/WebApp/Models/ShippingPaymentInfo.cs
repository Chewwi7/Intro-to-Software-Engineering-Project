namespace LootXApp.Models;

public class ShippingPaymentInfo
{
    public string StreetName { get; set; }
    public string CityName { get; set; }
    public string StateName { get; set; }
    public int ZipCode { get; set; }
    public int PhoneNumber { get; set; }
    public int CreditCardNumber { get; set; }
    public int CreditCardExpirationDate { get; set; }
    public int CreditCardCVV { get; set; }
}