using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Abp.BG.Dto;
using Abp.BG.Entities;

namespace Abp.BG.Mapper
{
    internal static class CustomDtoMapper
    {
        //业务实体映射关系
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<PdBrandEditDto, PdBrand>();
        }
    }
}
