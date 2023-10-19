Player player1 = new Player();
Player player2 = new Player();

player1.Attack(player2);
Console.WriteLine($"player1: {player1.Damage}, player2: {player2.Damage}");
player2.Attack(player1);
Console.WriteLine($"player1: {player1.Damage}, player2: {player2.Damage}");
player1.Attack(player1);
Console.WriteLine($"player1: {player1.Damage}, player2: {player2.Damage}");
Player player3 = player1;
player2.Attack(player3);
Console.WriteLine($"player1: {player1.Damage}, player2: {player2.Damage}, player3: {player3.Damage}");