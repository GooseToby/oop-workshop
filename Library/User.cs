Class user
{
    string name { get ; set; }
    int age { get; set;}
    string cpr { get; set;}

    public User(string name, int age, string cpr)
    {
        this.name = name,
        this.age = age;
        this.cpr = cpr;
    }

}
