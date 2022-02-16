namespace blastoff
{    public class Q06{
        public static string matchDuration(string initialTime, string endTime){
            string[] initialTimeSplit = initialTime.Split(":");
            string[] endTimeSplit = endTime.Split(":");
            double endTimeHour = Int64.Parse(endTimeSplit[0]);
            double initialTimeHour = Int64.Parse(initialTimeSplit[0]);
            double endTimeMinute = Int64.Parse(endTimeSplit[1]);
            double initialTimeMinute = Int64.Parse(initialTimeSplit[1]);

            double hoursMatchDuration = endTimeHour - initialTimeHour;
            double minutesMatchDuration = endTimeMinute - initialTimeMinute;
            if(endTimeHour < initialTimeHour){
                hoursMatchDuration = 24 - initialTimeHour + endTimeHour;
            }

            if(endTimeMinute < initialTimeMinute){
                hoursMatchDuration = hoursMatchDuration - 1;
                minutesMatchDuration = 60 - initialTimeMinute + endTimeMinute;
            }
            return hoursMatchDuration + " horas e " + minutesMatchDuration + " minutos";
        }       
    }
}