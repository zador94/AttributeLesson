using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace Attribute;

public class SerializedAndDeserialized 
{
    
    public void Serialized(Check check)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Check));
        try
        {
            using (Stream fileStram = File.Create("test.xml"))
            {
                xmlSerializer.Serialize(fileStram, check);
            }
            Console.WriteLine("Success");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }

    public void Deserialized(Check check)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Check));
        try
        {
            Check p = null;
            using (Stream fStream = File.OpenRead("test.xml"))
            {
                p = (Check)xmlSerializer.Deserialize(fStream);
            }
            Console.WriteLine(p);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    
}