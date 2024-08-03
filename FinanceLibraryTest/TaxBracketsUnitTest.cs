using FinanceLibraries;

namespace FinanceLibraryTest
{
    [TestClass]
    public class TaxBracketsUnitTest
    {
        [TestMethod]
        public void TestSocialSecurityTax()
        {
            decimal result = TaxLibrary.CalculateSocialSecurity(1000m);
            Assert.IsTrue(result == 62m);
            result = TaxLibrary.CalculateSocialSecurity(2650m);
            Assert.IsTrue(result == 164.30m);
            result = TaxLibrary.CalculateSocialSecurity(2650.50m);
            Assert.IsTrue(result == 164.33m);
        }

        [TestMethod]
        public void TestMedicareTax()
        {
            decimal result = TaxLibrary.CalculateMedicare(1000m);
            Assert.IsTrue(result == 14.50m);
            result = TaxLibrary.CalculateMedicare(2650m);
            Assert.IsTrue(result == 38.43m);
            result = TaxLibrary.CalculateMedicare(2650.50m);
            Assert.IsTrue(result == 38.43m);
        }

        [TestMethod]
        public void TestFederalIncomeTax()
        {
            decimal result = TaxLibrary.CalculateFederalIncome(1000m, true, 26);
            Assert.IsTrue(result == 43.85m);
            result = TaxLibrary.CalculateFederalIncome(3250m, true, 26);
            Assert.IsTrue(result == 401.19m);
            result = TaxLibrary.CalculateFederalIncome(3250m, false, 26);
            Assert.IsTrue(result == 237.38m);
        }
    }
}