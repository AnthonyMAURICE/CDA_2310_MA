using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WpfPersistence
{
    public class LocalPersistence : IPersistence
    {
        public static readonly string savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\loanWPF\\save\\";
        public void Insert(SLoan sLoan)
        {
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }
            File.WriteAllText(savePath + "save.json", CreateJSon(), Encoding.UTF8);
        }

        private string CreateJSon()
        {
            string jsonSave = JsonSerializer.Serialize(this);

            return jsonSave;
        }

        public SLoan Select()
        {
            if (!File.Exists(savePath + "save.json"))
            {
                return new SLoan();
            }
            else
            {
                string jsonLoad = File.ReadAllText(savePath + "save.json");
                return JsonSerializer.Deserialize<SLoan>(jsonLoad)!;
            }
        }
    }
}
