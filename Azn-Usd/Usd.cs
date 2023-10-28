
namespace Azn_Usd
{
    public class Usd
    {
        public double Value { get; set; }
        public Usd(double value)
        {
            this.Value = value;
        }
        public static implicit operator Usd(Azn azn)
        {
            return new Usd(azn.Value/1.7);
        }
    }
}
