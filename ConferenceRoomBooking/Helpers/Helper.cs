namespace ConferenceRoomBooking.Helpers
{
    public static class Helper
    {
        public static string CodeGenerator(DateTime date, DateTime startDate, DateTime endDate, string roomId)
        {
            string formatDate = date.ToString("yyyyMMdd");
            string formatStartDate = date.ToString("hhmm");
            string formatEndDate = date.ToString("hhmm");

            string code = $"{formatDate}-{formatStartDate}-{formatEndDate}-{roomId}";
            return code;
        }
    }
}
