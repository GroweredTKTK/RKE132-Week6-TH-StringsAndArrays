string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "ASian takeaway" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are ging to eat {snacks[randomIndex]}.");