using System;

public class CoffeeMachine
{
	public CoffeeMachine(string _model, float _coffeeMaximum, float _milkMaximum, float _waterMaximum, float _sugarMaximum)
	{
        ModelName = _model;
        CoffeeMaximum = _coffeeMaximum;
        MilkMaximum = _milkMaximum;
        WaterMaximum = _waterMaximum;
        SugarMaximum = _sugarMaximum;
    }

    //Data
    public string ModelName;
    public float Coffee { get; set; }
    public float Milk { get; set; }
    public float Water { get; set; }
    public float Sugar { get; set; }

    float CoffeeMaximum { get; set; }
    float MilkMaximum { get; set; }
    float WaterMaximum { get; set; }
    float SugarMaximum { get; set; }
    float Money { get; set; }

    enum DrinkTypes
    {
        Americano,
        Cappuccino,
        Espresso,
        Latte,
        Moccacino
    }
    public float GetDrinkTypeCost(string _drinkType)
    {
        if (_drinkType == "Americano")
            return 1.2f;
        if (_drinkType == "Cappuccino")
            return 2.3f;
        if (_drinkType == "Espresso")
            return 3.4f;
        if (_drinkType == "Latte")
            return 4.5f;
        if (_drinkType == "Moccacino")
            return 5.6f;
        else throw new Exception("Wrong drink type");
    }

    //Methods
    public void MakeOneCoffee(string _drinkType, float _money)
    {
        Money += _money;
        Coffee -= GetDrinkTypeCost(_drinkType) / 10;
        Milk -= GetDrinkTypeCost(_drinkType) / 10;
        Sugar -= GetDrinkTypeCost(_drinkType) / 10;
        Water -= GetDrinkTypeCost(_drinkType) / 10;
    }

    public void RefilIngredients()
    {
        Coffee = CoffeeMaximum;
        Milk = MilkMaximum;
        Sugar = SugarMaximum;
        Water = WaterMaximum;
    }
}
