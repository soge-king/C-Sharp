Random random = new Random();
int hero_hp = 10; 
int monster_hp = 10;
int turn = 0;  // 0 for hero's turn, 1 for monster's turn

while (hero_hp > 0 && monster_hp > 0)
{
    int damage = random.Next(1, 11);
    
    if (turn == 0)
    {
        monster_hp -= damage;
        Console.WriteLine($"The Monster was damaged and lost {damage} health and now has {monster_hp} health.");
    }
    else
    {
        hero_hp -= damage;
        Console.WriteLine($"The Hero was damaged and lost {damage} health and now has {hero_hp} health.");
    }
    
    // Toggle turn
    turn = turn == 0 ? 1 : 0;
}

Console.WriteLine(hero_hp > monster_hp ? "Hero wins!" : "Oh No! The Monster wins!");
