namespace HW5_16._09.Domain.Navigator
{
    public class Navigator
    {
        public double GetNavigate(IGetPath getTime, double km)
        {
           return getTime.GetTime(km);
        }
    }

}
