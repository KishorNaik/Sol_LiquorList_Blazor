using Sol_List.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_List.ViewModels
{
    public class LiquorViewModel
    {
        #region Constructor
        public LiquorViewModel()
        {
            LiquorList = new List<LiquorModel>();
        }
        #endregion 

        #region Property
        public IEnumerable<LiquorModel> LiquorList { get; set; }
        #endregion 
    }
}
