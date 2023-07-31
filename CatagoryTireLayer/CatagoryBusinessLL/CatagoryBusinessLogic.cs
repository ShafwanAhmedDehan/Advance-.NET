using AutoMapper;
using CatagoryBusinessLL.ModelDTO;
using CatagoryDataAL;
using CatagoryDataAL.DataBase;
using CatagoryDataAL.DatabaseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatagoryBusinessLL
{
    public class CatagoryBusinessLogic
    {
        public static List<CatagoryDTO> AllCatagory()
        {
            var allCatagory = CatagoryDatabase.All();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Catagory, CatagoryDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<List<CatagoryDTO>>(allCatagory);
            return converted;
        }

        public static bool CreateCata(CatagoryDTO newCat)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CatagoryDTO, Catagory>();
            });
            var mapper = new Mapper(config);
            var conv = mapper.Map<Catagory>(newCat);
            return CatagoryDatabase.createCatagory(conv);
        }

        public static bool updateCata(CatagoryDTO updateCat)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CatagoryDTO, DataBaseDTO>();
            });
            var mapper = new Mapper(config);
            var conv = mapper.Map<DataBaseDTO>(updateCat);
            return CatagoryDatabase.updateCatagory(conv);
        }

        public static bool deleteCata (CatagoryDTO deleteCat)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CatagoryDTO, Catagory>();
            });
            var mapper = new Mapper(config);
            var conv = mapper.Map<Catagory>(deleteCat);
            return CatagoryDatabase.createCatagory(conv);
        }
    }
}
