string[] favMeals = { "pizza", "sushi", "bbq", "burger", "tacos", "seafood"};

Console.WriteLine($"the number of your favourite meals is: {favMeals.Length}.");

for (int i = 0; i < favMeals.Length; i++)
{
    Console.WriteLine($"{(i + 1)} - {favMeals[i]}");
}

Console.WriteLine($"your absolute favourite meal is: {favMeals[0]}.");

Console.WriteLine($"your least favourite meal is: {favMeals[favMeals.Length - 1]}.");

//Bonus  

if (favMeals.Length % 2 == 0)
{
    Console.WriteLine($"your average favourite meals are: {favMeals[(favMeals.Length / 2) - 1]}, {favMeals[favMeals.Length / 2]}.");
}
else
{
    Console.WriteLine($"your average favourite meal is: {favMeals[favMeals.Length / 2]}.");
}
