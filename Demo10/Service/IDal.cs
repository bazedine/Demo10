using Demo10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10.Models
{
    public interface IDal : IDisposable
    {
        List<Resto> ObtienTousLesRestaurants();
        void CreerRestaurant(string nom, string telephone);

    }
}
