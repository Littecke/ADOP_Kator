using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2_IEquitable
{
    public interface IMemberList
    {
        public IMember this[int idx] { get; }

        /// <summary>
        /// number of members in the list
        /// </summary>
        /// <returns>number of members in the list</returns>
        int Count();

        /// <summary>
        /// number of members that joined in a specific year
        /// </summary>
        /// <param name="year"></param>
        /// <returns>number of members that joined in a specific year</returns>
        int Count(int year);

        /// <summary>
        /// Sorts the dates in year, month, day order
        /// </summary>
        void Sort();

    }
}
