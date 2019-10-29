using AutoMapper;
using AutoMapperLibrary.DTO;
using AutoMapperLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperLibrary
{
    public class MainProgram
    {
        static public void Main(String[] args)
        {
            var iMapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AuthorModel, AuthorDTO>()
                    .ForMember(dest => dest.Contact, opts => opts.MapFrom(src => src.ContactDetails))
                    .ForMember(dest => dest.Country, map => map.MapFrom(src => src.Address.Country))
                    .ForMember(dest => dest.State, map => map.MapFrom(src => src.Address.State))
                    .ForMember(dest => dest.City, map => map.MapFrom(src => src.Address.City));
            }).CreateMapper();
           
            var source = new AuthorModel();
            source.Id = 1;
            source.FirstName = "Renato";
            source.LastName = "Matos";
            source.Address = new Address
            {
                Country = "Brasil",
                State = "CE",
                City = "Fortaleza"
            };
            source.ContactDetails = "May May +1 236 125 144";
            
            var destination = iMapper.Map<AuthorModel, AuthorDTO>(source);

            Console.WriteLine($"Author Name: {destination.FirstName}  {destination.LastName}");
            Console.WriteLine($"Contact: {destination.Contact}");
            Console.WriteLine($"Address: {destination.City}/{destination.State} ({destination.Country})");
            Console.ReadLine();
        }        
    }
}
