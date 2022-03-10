using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("StockTesting")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("StockTesting")]
[assembly: AssemblyCopyright("Copyright ©  2022")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("c5039f49-a6d1-4adc-ae53-7cb1c0574514")]

// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

namespace StockTesting
{
    class clsStock
    {
        public string ProductCategory { get; internal set; }
        public string Quantity { get; internal set; }
        public string Date { get; internal set; }
        public string Available { get; internal set; }
        public string ProductName { get; internal set; }
        public string StockId { get; internal set; }
    }
}