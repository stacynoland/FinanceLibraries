namespace FinanceLibraries;

public static class TaxLibrary
{
    public static decimal CalculateSocialSecurity(decimal value)
    {
        decimal ssPercent = 0.062m;
        if (value.Equals(0))
            return 0;
        return Math.Round((value * ssPercent), 2, MidpointRounding.AwayFromZero);
    }

    public static decimal CalculateMedicare(decimal value)
    {
        decimal medPercent = 0.0145m;
        if (value.Equals(0))
            return 0;
        return Math.Round((value * medPercent), 2, MidpointRounding.AwayFromZero);
    }

    public static decimal CalculateFederalIncome(decimal payPerPeriod, bool single, int numPayPeriods)
    {
        Dictionary<string, decimal> result = new Dictionary<string, decimal>();
        List<Dictionary<string, decimal>> taxBracket;
        decimal deduction;

        if (single)
        {
            deduction = 8600m;
            taxBracket = TaxBrackets.SingleTaxBracket;
        }
        else
        {
            deduction = 12900m;
            taxBracket = TaxBrackets.MarriedTaxBracket;
        }

        decimal annualGrossPay = payPerPeriod * numPayPeriods - deduction;

        foreach (var bracket in taxBracket)
        {
            if (annualGrossPay >= bracket["Min"] && annualGrossPay < bracket["Max"])
            {
                result = bracket;
                break;
            }
        }
        decimal annualTaxAmount = ((annualGrossPay - result["Min"]) * result["AddPercent"]) + result["ApproxWithold"];
        decimal taxPerPayPeriod = annualTaxAmount / numPayPeriods;
        return Math.Round(taxPerPayPeriod, 2, MidpointRounding.AwayFromZero);
    }
}
