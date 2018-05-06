using AutoMapper;
using Rest.DAL.DTOs;
using RestaurantData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResterauntWeb.App_Start
{
    public class MappingProfile : Profile
    {


        public MappingProfile()
        {
            // Domain to Dto
            CreateMap<Restauraunt, RestaurantDto>();
            CreateMap<Reviews, ReviewsDto>();
        }

    }
}