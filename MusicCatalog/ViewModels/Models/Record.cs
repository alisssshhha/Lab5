public class Record
{
    public string Author { get; set; }
    public string Name { get; set; }
    
    public Record(string author , string name)
    {
        Author = author;
        Name = name;
    }
}