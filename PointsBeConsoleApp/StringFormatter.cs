using System.Text;

namespace PointsBeConsoleApp
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public class StringFormatter
    {

        //Code to improve
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
