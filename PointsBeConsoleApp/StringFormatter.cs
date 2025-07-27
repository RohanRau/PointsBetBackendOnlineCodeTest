using System.Text;

namespace PointsBeConsoleApp
{
    public class StringFormatter
    {

        public static string ToCommaSeparatedList(string[] items, char quoteChar)
        {
            if (items.Length < 1)
            {
                return string.Empty;
            }

            StringBuilder query = new StringBuilder();

            for (int i = 0; i < items.Length; i++)
            {
                if (i > 0)
                {
                    query.AppendFormat(", ");
                }
                query.AppendFormat("{0}{1}{0}", quoteChar, items[i]);
            }

            return query.ToString();
        }
    }
}
