

using Secao8_Enumerables.Entities;
using Secao8_Enumerables.Entities.Enums;

Order order = new Order
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};
Console.WriteLine(order);

// Coverter em string 
string txt = OrderStatus.PendingPayment.ToString();
Console.WriteLine(txt);

// Coverter Enum 
OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
Console.WriteLine(os);


Console.ReadKey();

