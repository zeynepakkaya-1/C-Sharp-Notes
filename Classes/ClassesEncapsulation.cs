Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "Zeynep";
customer.LastName = "Akkaya";

Customer customer2 = new Customer()
{
    Id = 2, FirstName = "Efe", LastName = "Akkaya"
};

class Customer
{
    // field & property
    public int Id { get; set; }

    // Encapsulation
    private string _firstName;
    public string FirstName
    {
        get { return _firstName; } set { _firstName = value; }
    }

    public string LastName { get; set; }

}