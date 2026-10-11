int distanceValue = AskingDistance();
RunGame(distanceValue);

// ASKING DISTANCE METHOD
int AskingDistance()
{
    int distanceValue;
    do
    {
        Console.Write("Player 1, How far away is the Manticore from city? Enter the value between 0 and 100: ");
        distanceValue = int.Parse(Console.ReadLine());
    } 
    while (distanceValue < 0 || distanceValue > 100);
   
    Console.Clear();
    return distanceValue;
}

// RUN GAME METHOD
void RunGame(int distanceValue)
{
    int manticoreHealth = 10;
    int cityHealth = 15;
    int round = 1;

    while (cityHealth > 0 && manticoreHealth > 0)
    {

        Console.WriteLine($"Manticore Health: {manticoreHealth}\nCity Health: {cityHealth}\nRound: {round}");
        int cannonDamage = CalculateCannonDamage(round);
        int targetRange = GetTargetRange();
        manticoreHealth = ProcessShot(targetRange, distanceValue, cannonDamage, manticoreHealth);
        if (manticoreHealth > 0)
        {
            cityHealth--;
        }

        round++;
    }

    DisplayGameResult(manticoreHealth);

}

// CALCULATE CANNON DAMAGE METHOD
int CalculateCannonDamage(int currentRound)
{
    if (currentRound % 3 == 0 && currentRound % 5 == 0)
    {
        Console.WriteLine("The cannon will deal 10 damage this round.");
        return 10;
    }
    else if (currentRound % 3 == 0 || currentRound % 5 == 0)
    {
        Console.WriteLine("The cannon will deal 3 damage this round.");
        return 3;
    }
    else
    {
        Console.WriteLine("The cannon will deal 1 damage this round.");
        return 1;
    }
}

// TARGET RANGE CALCULATION METHOD
int GetTargetRange()
{
    Console.Write("Player 2, enter the target range: ");
    int targetDistance = int.Parse(Console.ReadLine());
    return targetDistance;
}

// PROCESS SHOT METHOD
int ProcessShot(int targetRange, int actualDistance, int cannonDamage, int manticoreHealth)
{
    if (targetRange == actualDistance)
    {
        Console.WriteLine("That round was a direct hit!");
        return manticoreHealth - cannonDamage;
    }
    else if (targetRange > actualDistance)
    {
        Console.WriteLine("That round overshot the target!");
        return manticoreHealth;
    }
    else
    {
        Console.WriteLine("That round fell short of the target!");
        return manticoreHealth;
    }
}

// DISPLAY GAME RESULT METHOD
void DisplayGameResult(int manticoreHealth)
{
    if (manticoreHealth <= 0)
    {
        Console.WriteLine("The Manticore has been destroyed! The city has been saved!");
    }
    else
    {
        Console.WriteLine("The city has been destroyed! The Manticore wins!");
    }
}
