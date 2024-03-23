
public abstract class Subscription
{
    public abstract double MonthlyFee { get; }
    public abstract int MinimumSubscriptionPeriod { get; }
    public abstract List<string> ChannelList { get; }
}
public class DomesticSubscription : Subscription
{
    public override double MonthlyFee => 10.0;
    public override int MinimumSubscriptionPeriod => 1;
    public override List<string> ChannelList => new List<string> { "Channel 1", "Channel 2" };
}

public class EducationalSubscription : Subscription
{
    public override double MonthlyFee => 5.0;
    public override int MinimumSubscriptionPeriod => 6;
    public override List<string> ChannelList => new List<string> { "Educational Channel 1", "Educational Channel 2" };
}

public class PremiumSubscription : Subscription
{
    public override double MonthlyFee => 20.0;
    public override int MinimumSubscriptionPeriod => 1;
    public override List<string> ChannelList => new List<string> { "Premium Channel 1", "Premium Channel 2", "Premium Channel 3" };
}
public abstract class SubscriptionCreator
{
    public abstract Subscription CreateSubscription();
}
public class WebSite : SubscriptionCreator
{
    public override Subscription CreateSubscription()
    {
       
        return new DomesticSubscription();
    }
}

public class MobileApp : SubscriptionCreator
{
    public override Subscription CreateSubscription()
    {
       
        return new EducationalSubscription();
    }
}

public class ManagerCall : SubscriptionCreator
{
    public override Subscription CreateSubscription()
    {
      
        return new PremiumSubscription();
    }
}

class Program
{
    static void Main(string[] args)
    {
        SubscriptionCreator creator = new WebSite();
        Subscription subscription = creator.CreateSubscription();
        Console.WriteLine($"Created {subscription.GetType().Name} with monthly fee {subscription.MonthlyFee}");
    }
}
