namespace HW5_16._09.Domain.Navigator
{
    public class BicyclePath : IGetPath
    {
        public double GetTime(double kilometers)
        {
            return Convert.ToInt32(kilometers / 15);
        }
    }

}
