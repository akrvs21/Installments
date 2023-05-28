
using System;
/**
 * Смартфон: рассрочка [3–9] месяцев
 * Компьютер: рассрочка [3–12] месяцев
 * Телевизор: рассрочка [3–18] месяцев
 * На каждую дополнительную единицу диапазона будет добавлено 3% для смартфонов, 4% для компьютеров и 5% для телевизоров
 * Четыре параметра для получения общей суммы платежа по продукту: продукт, сумма, номер телефона покупателя и диапазон рассрочки.
 */
class Program
{
    public double calculateInstallment(
    string productName,
    double productSum,
    string phoneNumber,
    double installmentRange
)
    {
        if (installmentRange < 3) Console.WriteLine("No such range");
        double cellphoneMaxRange = 9;
        double computerMaxRange = 12;
        double tvMaxRange = 18;
        double multiplier = 0;

        switch (productName)
        {
            case "Смартфон":
                multiplier = Math.Ceiling(installmentRange / cellphoneMaxRange);
                productSum = productSum * ((multiplier * 3) / 100 + 1);
                break;

            case "Компьютер":
                multiplier = Math.Ceiling(installmentRange / computerMaxRange);
                productSum = productSum * ((multiplier * 4) / 100 + 1);
                break;

            case "Телевизор":
                multiplier = Math.Ceiling(installmentRange / tvMaxRange);
                productSum = productSum * ((multiplier * 5) / 100 + 1);
                break;

            default:
                Console.WriteLine("No such product");
                break;
        }

        return productSum;
    }

    public static void Main(string[] args)
    {
        Program pr = new Program(); // Creating a class Object  
        double rslt = pr.calculateInstallment("Смартфон", 1000, "935005016", 18); //Calling the method and assigning the value to an integer type
        Console.WriteLine("Total amount of installments is " + rslt); //Printing the result
    }
}