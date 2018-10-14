using System;
using System.Collections;
using static CoffeeMachine;

public class Controller
{
    public Controller()
    {
    }
    public CoffeeMachine CreateMachine(string _model, float _coffeeMax, float _milkMax, float _sugarMax, float _waterMax)
    {
        if (_model == "" || _model.IndexOf(" ") >= 0)
            throw new Exception("Invalid model name!");
        if (_coffeeMax > 1000 || _coffeeMax < 0)
            throw new Exception("Invalid coffee amount!");
        if (_milkMax > 1000 || _milkMax < 0)
            throw new Exception("Invalid milk amount!");
        if (_waterMax > 1000 || _waterMax < 0)
            throw new Exception("Invalid water amount!");
        if (_sugarMax > 1000 || _sugarMax < 0)
            throw new Exception("Invalid sugar amount!");

        CoffeeMachine coffeeMachine = new CoffeeMachine(_model, _coffeeMax, _milkMax, _sugarMax, _waterMax);
        return coffeeMachine;
    }
    public void MakeOneCoffee(ref CoffeeMachine _coffeeMachine, string _drinkType, float _money)
    {
        if (_drinkType == "" || _drinkType.IndexOf(" ") >= 0)
            throw new Exception("Invalid drink type!");
        if (_money <= 0)
            throw new Exception("Invalid amount of money!");
        if (_money < _coffeeMachine.GetDrinkTypeCost(_drinkType))
            throw new Exception("Not enough money for the drink!");
        CheckIngredients(ref _coffeeMachine, _drinkType);

        _coffeeMachine.MakeOneCoffee(_drinkType, _money);
    }
    public void RefilIngredient(ref CoffeeMachine _coffeeMachine)
    {
        _coffeeMachine.RefilIngredients();
    }
    public void CheckIngredients(ref CoffeeMachine _coffeeMachine, string _drinkType)
    {
        if (_drinkType == "" || _drinkType.IndexOf(" ") >= 0)
            throw new Exception("Invalid drink type!");
        if (_coffeeMachine.Coffee < _coffeeMachine.GetDrinkTypeCost(_drinkType) / 10)
            throw new Exception("Not enought coffee in machine!");
        if (_coffeeMachine.Milk < _coffeeMachine.GetDrinkTypeCost(_drinkType) / 10)
            throw new Exception("Not enought milk in machine!");
        if (_coffeeMachine.Sugar < _coffeeMachine.GetDrinkTypeCost(_drinkType) / 10)
            throw new Exception("Not enought sugar in machine!");
        if (_coffeeMachine.Water < _coffeeMachine.GetDrinkTypeCost(_drinkType) / 10)
            throw new Exception("Not enought water in machine!");
    }
}
