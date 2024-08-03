using System;
using AcutionService.DTOs;
using AcutionService.Entities;
using AutoMapper;

namespace AcutionService.RequestHelpers;

public class MappingProfiles:Profile
{
    public MappingProfiles(){
        CreateMap<Auction,AuctionDTO>().IncludeMembers(x => x.Item);
        CreateMap<Item,AuctionDTO>();
        CreateMap<CreateAuctionDTO,Auction>().ForMember(d=>d.Item , o=>o.MapFrom(s=>s));
        CreateMap<CreateAuctionDTO,Item>();
    }

}