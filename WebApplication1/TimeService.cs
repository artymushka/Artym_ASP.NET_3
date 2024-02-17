namespace WebApplication1
{ 
    using System;

    public class TimeService : IService
    {
        public string GetTimeOfDay()
        {
            var currentTime = DateTime.Now;
            var hour = currentTime.Hour;

            if (hour >= 6 && hour < 12)
            {
                return "Ранок";
            }
            else if (hour >= 12 && hour < 18)
            {
                return "День";
            }
            else if (hour >= 18 && hour < 24)
            {
                return "Вечір";
            }
            else
            {
                return "Ніч";
            }
        }
    }

}
