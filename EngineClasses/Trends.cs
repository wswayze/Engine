using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClasses
{
    /// <summary>
    /// Trends shows the market trend direction.
    /// </summary>
    public enum Trends
    {
        /// <summary>
        /// The trend cannot be determined.
        /// </summary>
        Unassigned,
        /// <summary>
        /// Bull trend in progress.
        /// </summary>
        Bull,
        /// <summary>
        /// Bear trend in progress.
        /// </summary>
        Bear
    }
}
