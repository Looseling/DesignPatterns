using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBurgerBuilder<T> 
    {
        void reset();
        IBurgerBuilder<T> AddPatty();
        IBurgerBuilder<T> AddBun();
        IBurgerBuilder<T> AddKetchup();
        T Build();
    }
}
