using System.Runtime.Serialization;
namespace Attribute;

[Serializable]
public class Check 
{
    public string Product { get; set; }
    public double Price { get; set; }
    public DateTime Date { get; set; }
    public int Id { get; set; }

    
    public Check(){}

    public Check(int id)
    {
        this.Id = id;

    }

    public override string ToString()
    {
        return $"Product:{Product}, Price:{Price}, Date:{Date}";
    }
}