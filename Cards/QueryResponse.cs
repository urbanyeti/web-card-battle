using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cards
{
    public class QueryResponse<TResult> where TResult : IQueryResult
    {
        public QueryStatus Status { get; set; }
        public TResult Result { get; set; } 
    }
}
