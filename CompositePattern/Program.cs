﻿// See https://aka.ms/new-console-template for more information

var phone = new SingleGift("Phone", 256);
phone.CalculateTotalPrice();

//composite gift
var rootBox = new CompositeGift("RootBox", 0);
var truckToy = new SingleGift("TruckToy", 289);
var plainToy = new SingleGift("PlainToy", 587);
rootBox.Add(truckToy);
rootBox.Add(plainToy);
var childBox = new CompositeGift("ChildBox", 0);
var soldierToy = new SingleGift("SoldierToy", 200);
childBox.Add(soldierToy);
rootBox.Add(childBox);
Console.WriteLine($"Total price of this composite present is: {rootBox.CalculateTotalPrice()}");

public abstract class GiftBase
{
    protected string name;
    protected int price;

    public GiftBase(string name, int price)
    {
        this.name = name;
        this.price = price;
    }

    public abstract int CalculateTotalPrice();
}

public interface IGiftOperations
{
    void Add(GiftBase gift);
    void Remove(GiftBase gift);
}

public class CompositeGift : GiftBase, IGiftOperations
{
    private List<GiftBase> _gifts;

    public CompositeGift(string name, int price)
        : base(name, price)
    {
        _gifts = new List<GiftBase>();
    }

    public void Add(GiftBase gift)
    {
        _gifts.Add(gift);
    }

    public void Remove(GiftBase gift)
    {
        _gifts.Remove(gift);
    }

    public override int CalculateTotalPrice()
    {
        int total = 0;

        Console.WriteLine($"{name} contains the following products with prices:");

        foreach (var gift in _gifts)
        {
            total += gift.CalculateTotalPrice();
        }

        return total;
    }
}

public class SingleGift : GiftBase
{
    public SingleGift(string name, int price)
        : base(name, price)
    {
    }

    public override int CalculateTotalPrice()
    {
        Console.WriteLine($"{name} with the price {price}");

        return price;
    }
}  