using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

abstract class Computer
{
    protected private Regex r = new Regex(@"[\d!#]");
    private string serial;
    public string Serial { get { return serial; } 
        set { 
            serial = value; 
        }
    }
    private string model;
    public string Model { get { return model; } 
        set {
            model = value; 
        } 
    }
    private string manufacturer;
    public string Manufacturer { get { return manufacturer; } 
        set {
            manufacturer = value;
        } }
    private string contryManufacturer;
    public string ContryManufacturer { get {  return contryManufacturer; } set
        {
            contryManufacturer = value;
        } }
    private int price;
    public int Price { get { return price; } 
        set {
            price = value;
        } }
    private int weight;//В граммах
    public int Weight
    {
        get { return weight; }
        set
        {
            weight = value;
        }
    }
    public Computer()
    {
        Serial = string.Empty; 
        Model = string.Empty;
        Manufacturer = string.Empty;
        ContryManufacturer = string.Empty;
        Price = 0;
        Weight = 0;
    }
    public abstract double Descont(int Price);//Скидка
    public abstract string Information(); //информация
    public string ToString()
    {
        return Serial + " " + Model + " " + Manufacturer + " " + ContryManufacturer;
    }
}
