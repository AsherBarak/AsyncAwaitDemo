using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{

    public class MyWorkload
    {
        IMyService _service;

        private const int WORK_TIME_SECONDS = 3;

        public MyWorkload(IMyService service)
        {
            _service = service;
        }

        public int DoWork()
        {
            // Do lengthy stuff:
            DateTime startTime = DateTime.Now;
            while (!(DateTime.Now > startTime.AddSeconds(WORK_TIME_SECONDS)))
            {

            }
            return _service.GetInt();
        }
    }

}
