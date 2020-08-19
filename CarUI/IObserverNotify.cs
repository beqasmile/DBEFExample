using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarUI
{
    public interface IObserverNotify
    {
        void Notification(object somedata);
    }
}
