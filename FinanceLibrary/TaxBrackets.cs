namespace FinanceLibraries;

internal static class TaxBrackets
{
    internal static readonly List<Dictionary<string, decimal>> SingleTaxBracket =
        new List<Dictionary<string, decimal>>();
    internal static readonly List<Dictionary<string, decimal>> MarriedTaxBracket =
        new List<Dictionary<string, decimal>>();
    internal static readonly List<Dictionary<string, decimal>> HeadHouseTaxBracket =
        new List<Dictionary<string, decimal>>();

    static TaxBrackets()
    {
        SeedSingleTaxBracket();
        SeedMarriedTaxBracket();
        SeedHeadHouseTaxBracket();
    }

    static readonly decimal MaxAmount = 999999999999.99m;

    static void SeedSingleTaxBracket()
    {
        SingleTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 0 },
            { "Max", 5999.99m },
            { "ApproxWithold", 0 },
            { "AddPercent", 0 },
        });
        SingleTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 6000m },
            { "Max", 17599.99m },
            { "ApproxWithold", 0 },
            { "AddPercent", 0.10m }
        });
        SingleTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 17600m },
            { "Max", 53149.99m },
            { "ApproxWithold", 1160m },
            { "AddPercent", 0.12m }
        });
        SingleTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 53150m },
            { "Max", 106524.99m },
            { "ApproxWithold", 5426m },
            { "AddPercent", 0.22m }
        });
        SingleTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 106525m },
            { "Max", 197949.99m },
            { "ApproxWithold", 17168.5m },
            { "AddPercent", 0.24m }
        });
        SingleTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 197950m },
            { "Max", 249724.99m },
            { "ApproxWithold", 39110.5m },
            { "AddPercent", 0.32m }
        });
        SingleTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 249725m },
            { "Max", 615349.99m },
            { "ApproxWithold", 55678.5m },
            { "AddPercent", 0.35m }
        });
        SingleTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 615350m },
            { "Max", MaxAmount },
            { "ApproxWithold", 183647.25m },
            { "AddPercent", 0.37m }
        });
    }

    static void SeedMarriedTaxBracket()
    {
        MarriedTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 0 },
            { "Max", 16299.99m },
            { "ApproxWithold", 0 },
            { "AddPercent", 0 }
        });
        MarriedTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 16300m },
            { "Max", 39499.99m },
            { "ApproxWithold", 0 },
            { "AddPercent", 0.10m }
        });
        MarriedTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 39500m },
            { "Max", 110599.99m },
            { "ApproxWithold", 2320m },
            { "AddPercent", 0.12m }
        });
        MarriedTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 110600m },
            { "Max", 217349.99m },
            { "ApproxWithold", 10852m },
            { "AddPercent", 0.22m }
        });
        MarriedTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 217350m },
            { "Max", 400199.99m },
            { "ApproxWithold", 34337m },
            { "AddPercent", 0.24m }
        });
        MarriedTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 400200m },
            { "Max", 503749.99m },
            { "ApproxWithold", 78221m },
            { "AddPercent", 0.32m }
        });
        MarriedTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 503750m },
            { "Max", 747499.99m },
            { "ApproxWithold", 111357m },
            { "AddPercent", 0.35m }
        });
        MarriedTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 747500m },
            { "Max", MaxAmount },
            { "ApproxWithold", 196669.5m },
            { "AddPercent", 0.37m }
        });
    }

    static void SeedHeadHouseTaxBracket()
    {
        HeadHouseTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 0 },
            { "Max", 13299.99m },
            { "ApproxWithold", 0 },
            { "AddPercent", 0 }
        });
        HeadHouseTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 13300m },
            { "Max", 29849.99m },
            { "ApproxWithold", 0 },
            { "AddPercent", 0.10m }
        });
        HeadHouseTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 29850m },
            { "Max", 76399.99m },
            { "ApproxWithold", 1655m },
            { "AddPercent", 0.12m }
        });
        HeadHouseTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 76400m },
            { "Max", 113799.99m },
            { "ApproxWithold", 7241m },
            { "AddPercent", 0.22m }
        });
        HeadHouseTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 113800m },
            { "Max", 205249.99m },
            { "ApproxWithold", 15469m },
            { "AddPercent", 0.24m }
        });
        HeadHouseTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 205250m },
            { "Max", 256999.99m },
            { "ApproxWithold", 37417m },
            { "AddPercent", 0.32m }
        });
        HeadHouseTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 257000m },
            { "Max", 622649.99m },
            { "ApproxWithold", 53977m },
            { "AddPercent", 0.35m }
        });
        HeadHouseTaxBracket.Add(new Dictionary<string, decimal>
        {
            { "Min", 622650m },
            { "Max", MaxAmount },
            { "ApproxWithold", 181954.5m },
            { "AddPercent", 0.37m }
        });
    }
}
