using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS.ScheduleSystem.Data;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\UTS.ScheduleSystem.Data"));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            IEnumerable<string> passing;
            using (var context = new ScheduleSystemContext())
            {
                passing = from fixedConversationalRule in context.FixedConversationalRules
                          where fixedConversationalRule.Input.Equals("haha")
                          select fixedConversationalRule.Output;
            }
            foreach(var output in passing)
            {
                Console.WriteLine(output);
            }
                Console.ReadLine();
        }
    }
}
