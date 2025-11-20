class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;

    public Address(string street,string city,string province,string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string DisplayAdd()
    {
        string AddDetails = $"|ADDRESS DETAILS|\n{_street}\n{_city}\n{_province}\n{_country}";
        return AddDetails;
    }

}