using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IObserver
    {
        // értékék amiket megkapnak az observerek a Subjecttől, push-os megoldás
        void Update(float temp, float humidity, float pressure);

    }
}
