namespace DB_DateTime
{
   public class CDB_DateTime
   {
      public static string GetDbTime()
      {
         return GetDbTime(DateTime.Now);
      }

      public static string GetDbTime(DateTime dt)
      {
         return string.Format("{0:G}-{1:G}-{2:G} {3:G}:{4:G}:{5:G}.{6:G}",
            dt.Year.ToString("D4"),
            dt.Month.ToString("D2"),
            dt.Day.ToString("D2"),
            dt.Hour.ToString("D2"),
            dt.Minute.ToString("D2"),
            dt.Second.ToString("D2"),
            dt.Millisecond.ToString("D3")
            );
      }
   }
}
