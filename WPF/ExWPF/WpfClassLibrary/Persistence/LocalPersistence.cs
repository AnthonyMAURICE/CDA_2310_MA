using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WpfClassLibrary.Models;

namespace WpfClassLibrary.Persistence
{
    public class LocalPersistence : Persistence, IPersistence
    {
        public void Insert(SLoan sLoan)
        {
            if (!Directory.Exists(Loan.savePath))
            {
                Directory.CreateDirectory(Loan.savePath);
            }
            File.WriteAllText(Loan.savePath + "save.json", CreateJSon(), Encoding.UTF8);
        }

        private string CreateJSon()
        {
            string jsonSave = JsonSerializer.Serialize(this);

            return jsonSave;
        }

        public SLoan Select()
        {
            if (!File.Exists(Loan.savePath + "save.json"))
            {
                return new(new Loan());
            }
            else
            {
                string jsonLoad = File.ReadAllText(Loan.savePath + "save.json");
                return JsonSerializer.Deserialize<SLoan>(jsonLoad)!;
            }
        }
    }
}
