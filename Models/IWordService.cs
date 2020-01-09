using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordAPP.Models
{
    public interface IWordService
    {
        string NumWordsWrapper(double n);
    }
}