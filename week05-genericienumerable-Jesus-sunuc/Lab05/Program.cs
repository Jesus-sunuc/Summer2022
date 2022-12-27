using System;
namespace Lab05;
public class Program
{
    static public void CustomClass()
    {
        T_shirts t_shirt1 = new T_shirts(T_shirts.T_shirtsType.Small, "S");
        T_shirts t_shirt2 = new T_shirts(T_shirts.T_shirtsType.Medium, "M");
        T_shirts t_shirt3 = new T_shirts(T_shirts.T_shirtsType.Large, "L");
        T_shirts t_shirt4 = new T_shirts(T_shirts.T_shirtsType.ExtraLarge, "XL");

        T_shirts[] T_ShirtsArray = { t_shirt1, t_shirt2, t_shirt3, t_shirt4};

        var myList = new MyList<T_shirts>(T_ShirtsArray);

        foreach(T_shirts x in myList)
        {
            Console.WriteLine(x);
        }

        static void Main()
        {
            CustomClass();
        }
    }
}