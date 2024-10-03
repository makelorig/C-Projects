//try
//{
//    int number = 10;
//    int divisior = 0;
//    int[] numbers = null;
//    int result = numbers.Length;
//    //int result = number / divisior;
//    Console.WriteLine($"Result: {result}");
//}
//catch(NullReferenceException ex)
//{
//    Console.WriteLine("Произошла ошибка");
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}
//catch(DivideByZeroException ex)
//{
//    Console.WriteLine( "Деление на ноль недопустимо" );
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine("Произошла ошибка");
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}
//finally
//{
//    Console.WriteLine("Блок: освобождение ресурсов");
//}

//var cart = new ShoppingCart();
//cart.SetDicountStrategy(new NoDiscoiuntStrategy());
//Console.WriteLine($"Сумма без скидки: {cart.CalculateTotalPrice(1000)}");
//cart.SetDicountStrategy(new SeasonalDiscoiuntStrategy());
//Console.WriteLine($"Сумма с сезонной скидкой: {cart.CalculateTotalPrice(1000)}");
//cart.SetDicountStrategy(new HolydayDiscoiuntStrategy());
//Console.WriteLine($"Сумма с праздничной скидкой: {cart.CalculateTotalPrice(1000)}");
//public interface IDicountStrategy
//{
//    public decimal GetDiscount(decimal totalAmount);

//}
//public class NoDiscoiuntStrategy: IDicountStrategy
//{
//    public decimal GetDiscount(decimal totalAmount)
//    {
//        return totalAmount;
//    }
//}
//public class SeasonalDiscoiuntStrategy: IDicountStrategy
//{
//    public decimal GetDiscount(decimal totalAmount)
//    {
//        return totalAmount*0.9m;
//    }
//}
//public class HolydayDiscoiuntStrategy: IDicountStrategy
//{
//    public decimal GetDiscount(decimal totalAmount)
//    {
//        return totalAmount*0.8m;
//    }
//}
//public class ShoppingCart
//{
//    private IDicountStrategy _dicountStrategy;
//    public void SetDicountStrategy(IDicountStrategy dicountStrategy)
//    {
//        _dicountStrategy = dicountStrategy;
//    }
//    public decimal CalculateTotalPrice(decimal totalAmount) 
//    {
//        if (_dicountStrategy != null) { return _dicountStrategy.GetDiscount(totalAmount); }throw new Exception("Цена не задана");
//    }

//}
using TryCatchExample;
var reciver = new Reciver("Bobik");
reciver.SetNotifiyStrat(new EmailNotify());
reciver.ReciveMessageFrom("email");
reciver.SetNotifiyStrat(new SmsNotify());
reciver.ReciveMessageFrom("sms");
reciver.SetNotifiyStrat(new PushNotify());
reciver.ReciveMessageFrom("push");


Sender sender = new Sender("anton");

NotifationContent content = new NotifationContent(sender,reciver,new EmailNotify());
content.info("Smatrphone vivo");

