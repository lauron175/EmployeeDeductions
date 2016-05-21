using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDeductions.Domain.Models
{
    public abstract class AbstractExample
    {
        //public abstract void Foo();        
        public virtual void DoStuff()
        {
            var test = string.Empty;
        }
    }

    public class Another : AbstractExample
    {
        //public override void Foo()
        //{            
        //    throw new NotImplementedException();
        //}

        //public override void DoStuff()
        //{
        //    var test = 1;
        //}

        public void Foo()
        {
            
        }

        public override void DoStuff()
        {
            var test = 1;
        }
    }


}
