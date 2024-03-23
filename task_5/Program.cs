public class Character
{
    public string Name { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }
    public string Clothes { get; set; }
    public string Inventory { get; set; }
}

public abstract class CharacterBuilder
{
    protected Character character;

    public Character GetCharacter()
    {
        return character;
    }

    public void CreateCharacter()
    {
        character = new Character();
    }

    public abstract CharacterBuilder SetName(string name);
    public abstract CharacterBuilder SetHairColor(string color);
    public abstract CharacterBuilder SetEyeColor(string color);
    public abstract CharacterBuilder SetClothes(string clothes);
    public abstract CharacterBuilder SetInventory(string inventory);
}

public class HeroBuilder : CharacterBuilder
{
    public override CharacterBuilder SetName(string name)
    {
        character.Name = name;
        return this;
    }

    public override CharacterBuilder SetHairColor(string color)
    {
        character.HairColor = color;
        return this;
    }

    public override CharacterBuilder SetEyeColor(string color)
    {
        character.EyeColor = color;
        return this;
    }

    public override CharacterBuilder SetClothes(string clothes)
    {
        character.Clothes = clothes;
        return this;
    }

    public override CharacterBuilder SetInventory(string inventory)
    {
        character.Inventory = inventory;
        return this;
    }
}

public class EnemyBuilder : CharacterBuilder
{
    public override CharacterBuilder SetName(string name)
    {
        character.Name = name;
        return this;
    }

    public override CharacterBuilder SetHairColor(string color)
    {
        character.HairColor = color;
        return this;
    }

    public override CharacterBuilder SetEyeColor(string color)
    {
        character.EyeColor = color;
        return this;
    }

    public override CharacterBuilder SetClothes(string clothes)
    {
        character.Clothes = clothes;
        return this;
    }

    public override CharacterBuilder SetInventory(string inventory)
    {
        character.Inventory = inventory;
        return this;
    }
}

public class Director
{
    public Character Construct(CharacterBuilder builder, string name, string hairColor, string eyeColor, string clothes, string inventory)
    {
        builder.CreateCharacter();
        return builder.SetName(name)
                      .SetHairColor(hairColor)
                      .SetEyeColor(eyeColor)
                      .SetClothes(clothes)
                      .SetInventory(inventory)
                      .GetCharacter();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Director director = new Director();

        HeroBuilder heroBuilder = new HeroBuilder();
        Character hero = director.Construct(heroBuilder, "Hero", "Black", "Blue", "Armor", "Sword");

        EnemyBuilder enemyBuilder = new EnemyBuilder();
        Character enemy = director.Construct(enemyBuilder, "Enemy", "Red", "Green", "Robe", "Staff");

        Console.WriteLine($"Hero: {hero.Name}, Hair: {hero.HairColor}, Eyes: {hero.EyeColor}, Clothes: {hero.Clothes}, Inventory: {hero.Inventory}");
        Console.WriteLine($"Enemy: {enemy.Name}, Hair: {enemy.HairColor}, Eyes: {enemy.EyeColor}, Clothes: {enemy.Clothes}, Inventory: {enemy.Inventory}");
    }
}
