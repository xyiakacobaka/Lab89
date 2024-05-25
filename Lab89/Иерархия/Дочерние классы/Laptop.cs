using Lab89;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

internal class Laptop : Computer
{
    public bool Upgrade {  get; set; }//Возможность замены видеокарты
    public bool Mobility { get; set; }
    public override void Information()
    {
        MessageBox.Show($"Информация о товаре:" +
                        $"Производитель - {Manufacturer}\n " +
                        $"Страна изготовления - {ContryManufacturer}\n" +
                        $"Цена - {Price}\n" +
                        $"Вес - {Weight}\n");
    }
    public override void Descont()
    {
        MessageBox.Show($"Цена с учетом скидки - {this.Price / (1 - (10 / 100))}");
    }
    public string ToString()
    {
        return Serial+" "+Model+" "+Manufacturer+" "+ContryManufacturer+" "+Price+" "+Weight+" "+Upgrade+" "+Mobility;
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
                if (Upgrade == "Присутствует")
                    this.Upgrade = true;
                else
                    this.Upgrade = false;
                if (Mobility == "Присутствует")
                    this.Mobility = true;
                else
                    this.Mobility = false;
                Form1.computers.Add(this);
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
