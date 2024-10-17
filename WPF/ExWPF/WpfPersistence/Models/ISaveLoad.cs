using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPersistence.Models
{
    internal interface ISaveLoad
    {
        void SaveDataInDB();
        SLoan LoadDataFromDB();
    }
}
