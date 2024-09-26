using HW5_16._09.Domain.Navigator;
using HW5_16._09;

Navigator navigator = new Navigator();


double path = 55.4;
Console.WriteLine(navigator.GetNavigate(new CarPath(), path));
Console.WriteLine(navigator.GetNavigate(new BicyclePath(), path));
Console.WriteLine(navigator.GetNavigate(new WalkerPath(), path));
Console.WriteLine(navigator.GetNavigate(new BusPath(), path));




Console.ReadKey();