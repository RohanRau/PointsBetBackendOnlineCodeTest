using System.Text;

namespace PointsBeConsoleApp
{
    /// <summary>
    /// Formats a string array with specified quote character and joining them with commas
    /// </summary>
    /// <param name="items">Takes array of strings to be formatted</param>
    /// <param name="quoteChar">Character to put around each item</param>
    /// <returns>
    /// Returns a single string with each item surrounded with specified character and separated by commas.
    /// </returns>
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
