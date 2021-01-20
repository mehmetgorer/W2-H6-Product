using System;


class MainClass
 {
  public static void Main (string[] args)
  {

    Console.WriteLine("===============================================");
    Console.WriteLine("2021 console prices and customer ratings in Turkey");
    Console.WriteLine("===============================================");

    product PlayStation5 = new product();
    PlayStation5.Name= "PlayStation 5";
    PlayStation5.Price= 10000 ;
    PlayStation5.Customerratings= 4.8;

    product XboxOneX = new product();
    XboxOneX.Name= "Xbox One X";
    XboxOneX.Price= 7500 ;
    XboxOneX.Customerratings= 4.6 ;

    product NintendoSwitch = new product();
    NintendoSwitch.Name= "Nintendo Switch";
    NintendoSwitch.Price= 5500;
    NintendoSwitch.Customerratings= 4.5;

    product[] products = new product[] { PlayStation5, XboxOneX, NintendoSwitch};

    foreach (var product in products)
    {
      Console.WriteLine(product.Name + " " + product.Price+ " TL " + product.Customerratings + "  ");
    }
    
  }
}
 class product
{
  public string Name {get;set;}
  public int Price {get;set;}
  public double Customerratings {get;set;}
}