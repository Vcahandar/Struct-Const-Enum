using DomainLayer.Models;
using ServiceLayer.services;

Costumer costumer1 = new Costumer(1, "Cahandar", "Velibeyli", 26, "Komekci");
Costumer costumer2 = new Costumer(2, "Elcan", "Memmedov", 30, "Ashbaz");
Costumer costumer3 = new Costumer(3, "Arzu", "Humbetov", 24, "Xadimeci");
Costumer costumer4 = new Costumer(4, "Nurlan", "Mecidli", 28, "Surucu");
Costumer costumer5 = new Costumer(5, "Nurlan", "Mecidli", 22, "Surucu");

Costumer[] people = { costumer1, costumer2, costumer3, costumer4 ,costumer5};

CostumerAge costumer = new CostumerAge();
//var result = costumer.GetAge(people);

//Console.WriteLine(result);


var middleResult = costumer.GetMiddleAge(people);
Console.WriteLine(middleResult);

