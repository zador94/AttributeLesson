using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using Attribute;

Check check = new Check(123456)
{
   Product = "Gillete Mach 3",
   Price = 2000,
   Date = new DateTime(1994,01,20)
};

SerializedAndDeserialized serializedAndDeserialized = new SerializedAndDeserialized();

Console.WriteLine("Введите 1 или 2 для выбора");
int menu;
if(!Int32.TryParse(Console.ReadLine(), out menu) && menu != 1 && menu != 2)
{
   Console.WriteLine("Введите 1 или 2");
}
else
{
   switch (menu)
   {
      case 1:
         serializedAndDeserialized.Serialized(check);
         break;
      case 2:
         serializedAndDeserialized.Deserialized(check);
         break;
   }
}

