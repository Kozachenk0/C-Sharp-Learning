Random coin = new Random();
int coinFlip = coin.Next(0, 2);

Console.WriteLine($"Coin flip: {(coinFlip > 0 ? "Heads" : "Tails")}");