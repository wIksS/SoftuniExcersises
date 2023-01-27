


Func<int, DateTime, string, decimal> func = CalculateFinancialIndex;

CalculateFinancialIndexDelegate delegateVar = CalculateFinancialIndex;


decimal CalculateFinancialIndex(int param1, DateTime date, string something)
{
    return 0;
}

delegate decimal CalculateFinancialIndexDelegate(int param1, DateTime date, string something);

