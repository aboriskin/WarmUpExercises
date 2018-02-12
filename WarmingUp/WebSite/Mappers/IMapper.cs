using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Mappers
{
    public interface IMapper<TFrom, TTo>
    {
        void Map(TFrom from, TTo to);
        void MapBack(TTo from, TFrom to);
    }
}
