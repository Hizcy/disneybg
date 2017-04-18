using Jnwf.Utils.CycleEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupStatusUpdate
{
    class Program
    {
       
        static void Main(string[] args)
        { 
            AgileCycleEngine agile = new AgileCycleEngine(new EngineActor());
            agile.DetectSpanInSecs = 5;
            agile.Start();
            Console.Read();
        }
        public class EngineActor : IEngineActor
        {
            UpdateGroupStatus model = new UpdateGroupStatus();
            GetUserHead insertHead = new GetUserHead();
            public bool EngineAction()
            {　
                DateTime dt = DateTime.Now;
                //每五分钟
                //if (dt.Minute % 1 == 0 && dt.Second == 0)
                //{
                    //model.UpdateGroupStatusT();
                    //Console.WriteLine(string.Format("{0}执行:UpdateGroupStatus", dt));
                    insertHead.SetUserData();
                    Console.WriteLine(string.Format("{0}执行:SetUserData", dt));
                //}
                return true;
            }
        } 
    }
}
