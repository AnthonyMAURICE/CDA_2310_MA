using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLoan.Models
{
    internal interface ISaveLoad
    {
        void SaveDataInDB();
        void LoadDataFromDB();
    }
}
