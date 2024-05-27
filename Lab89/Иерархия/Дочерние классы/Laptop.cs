using Lab89;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

[Serializable]
public class Laptop : Computer
{
    public bool Upgrade {  get; set; }//Возможность замены видеокарты
    public bool Mobility { get; set; }
    public override string Information()
    {
        return( $"Серия - {Serial}\n" +
                $"Модель - {Model}\n" +
                $"Производитель - {Manufacturer}\n" +
                $"Страна изготовления - {ContryManufacturer}\n" +
                $"Цена - {Price}\n" +
                $"Вес - {Weight}\n" +
                $"Возможность улучшения - {Upgrade}\n" +
                $"Мобильность - {Mobility}\n" +
                $"Цена с учетом скидки - {Descont(this.Price)}р\n");
    }
    public override double Descont(int Price)
    {
        double i = (1 - (10.0 / 100.0));
        return (Price * i);
    }
    public string ToString()
    {
        return Serial+";"+Model+";"+Manufacturer+";"+ContryManufacturer+
            ";"+Price+";"+Weight+";"+Upgrade+";"+Mobility;
    }
    public Laptop()
    {
        Serial = "";
        Model = "";
        Manufacturer = "";
        ContryManufacturer = "";
        Price = 0;
        Weight = 0;
        Upgrade = false;
        Mobility = false;
    }
    public Laptop(string Serial, string Model, string Manufacturer, 
        string ContryManufacturer, string Price, string Weight, string Upgrade, string Mobility) 
    {
        if (Serial == "" || Model == "" ||Manufacturer == "" || ContryManufacturer == "" || Price == "" || Weight == "")
        {
            throw new ArgumentException("Одно из введенных полей являетя пустым");
        }
        try
        {
            Match m = r.Match(Manufacturer + ContryManufacturer);
            if (!m.Success)
            {
                this.Serial = Serial;//0
                this.Model = Model;//1
                this.Manufacturer = Manufacturer;//2
                this.ContryManufacturer = ContryManufacturer;//3
                this.Price = Int32.Parse(Price);//4
                this.Weight = Int32.Parse(Weight);//5
                if (Upgrade == "True")
                    this.Upgrade = true;
                else
                    this.Upgrade = false;
                if (Mobility == "True")
                    this.Mobility = true;
                else
                    this.Mobility = false;
                Form1.laptops.Add(this);
            }
            else
                throw new ArithmeticException("Поля содержат цифры или знак # или знак !");
        }
        catch (ArgumentNullException)
        {
            throw new ArgumentNullException("Проверьте поля. Возможно одно из них пустое");
        }
        catch (FormatException)
        {
            throw new FormatException("Проверьте поле \"Цена\" и поле \"Вес\"");
        }
    }
    public static bool operator >(Laptop counter1, Laptop counter2)
    {
        return counter1.Weight > counter2.Weight;
    }
    public static bool operator <(Laptop counter1, Laptop counter2)
    {
        return counter1.Weight < counter2.Weight;
    }
    public static bool operator true(Laptop obj1)
    {
        return obj1.Weight < 5;
    }
    public static bool operator false(Laptop obj1)
    {
        return obj1.Weight >= 5;
    }
    public static implicit operator Laptop(int x)//преобразование в кг
    {
        return x / 1000;
    }
}
