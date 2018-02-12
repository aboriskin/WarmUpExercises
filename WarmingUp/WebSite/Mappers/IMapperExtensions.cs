using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Mappers
{
    public static class IMapperExtensions
    {
        public static TTo Map<TFrom,TTo>(this IMapper<TFrom, TTo> mapper, TFrom from) where TTo : new()
        {
            TTo to = new TTo();
            mapper.Map(from, to);            
            return to;
        }

        public static TFrom MapBack<TFrom, TTo>(this IMapper<TFrom, TTo> mapper, TTo from) where TFrom : new()
        {
            TFrom to = new TFrom();
            mapper.MapBack(from, to);
            return to;
        }
    }
}
