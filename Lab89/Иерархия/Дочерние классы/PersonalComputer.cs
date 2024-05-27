using Lab89;
using System.Text.RegularExpressions;

[Serializable]
public class PersonalComputer : Computer
{
    private string type;
    public string Type
    {
        get { return type; }
        set
        {
            type = value;
        }
    }       
    public PersonalComputer()
    {
        Serial = "";
        Model = "";
        Manufacturer = "";
        ContryManufacturer = "";
        Price = 0;
        Weight = 0;
        Type = "";
    }
    public PersonalComputer(string Serial, string Model, string Manufacturer, 
        string ContryManufacturer, string Price, string Weight, string Type)
    {
        if (Serial == "" || Model == "" || Manufacturer == "" || ContryManufacturer == "" || Price == "" || Weight == "" || Type == "")
        {
            throw new ArgumentException("Одно из введенных полей являетя пустым");
        }
        try
        {
            Match m = r.Match(Manufacturer + ContryManufacturer + Type);
            if (!m.Success)
            {
                this.Serial = Serial;
                this.Model = Model;
                this.Manufacturer = Manufacturer;
                this.ContryManufacturer = ContryManufacturer;
                this.Price = Int32.Parse(Price);
                this.Weight = Int32.Parse(Weight);
                this.Type = Type;
                Form1.personalComputers.Add(this);
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
    public override double Descont(int Price)
    {
        double i = (1 - (15.0 / 100.0));
        return (Price * i);
    }
    public override string Information()
    {
        return( $"Серия - {Serial}\n" +
                $"Модель - {Model}\n" +
                $"Производитель - {Manufacturer}\n" +
                $"Страна изготовления - {ContryManufacturer}\n" +
                $"Цена - {Price}\n" +
                $"Вес - {Weight}\n" +
                $"Цена с учетом скидки - {Descont(this.Price)}р\n");
    }
    public string ToString()
    {
        return Serial + ";" + Model + ";" + Manufacturer + ";" + ContryManufacturer + ";" + 
            Price + ";" + Weight + ";" + Type;
    }
}