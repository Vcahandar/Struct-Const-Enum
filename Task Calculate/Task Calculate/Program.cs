


using ServiceLayer.Services;

CalculateService calculate=new CalculateService();

//var sum = calculate.Calculate(new int[] { 1, 3, 6, 7, 20 });
////Console.WriteLine(sum);

var result=calculate.GetCalcul(new int[] { 1, 3, 6, 7, 20 });
Console.WriteLine(result);