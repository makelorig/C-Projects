namespace HW5_16._09.Domain.Navigator
{
    public class CarPath : IGetPath
    {
        public double GetTime(double kilometers)
        {
            return Convert.ToInt32((kilometers / 60));
        }
    }

}
