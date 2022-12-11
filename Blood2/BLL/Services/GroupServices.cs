using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class GroupServices
    {
        public static List<GroupDTO> GetGroup()
        {

            var data = DataAccessFactory.GroupDataAccess().Get();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, GroupDTO>());
            var mapper = new Mapper(config);
            var groups = mapper.Map<List<GroupDTO>>(data);
            return groups;


        }


        public static GroupDTO Get(int id)
        {

            var data = DataAccessFactory.GroupDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, GroupDTO>());
            var mapper = new Mapper(config);
            var group = mapper.Map<GroupDTO>(data);
            return group;

        }

        public static GroupDTO Add(GroupDTO dto)
        {

            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<GroupDTO, Group>();
                cfg.CreateMap<Group, GroupDTO>();
            });
            var mapper = new Mapper(config);
            var group = mapper.Map<Group>(dto);
            var result = DataAccessFactory.GroupDataAccess().Add(group);
            return mapper.Map<GroupDTO>(result);

        }

        public static GroupDTO Remove(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, GroupDTO>());
            var mapper = new Mapper(config);
            var rmv = DataAccessFactory.GroupDataAccess().Delete(id);
            return mapper.Map<GroupDTO>(rmv);

        }

        public static GroupDTO Update(Group obj) {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, GroupDTO>());
            var mapper = new Mapper(config);
            var updt = DataAccessFactory.GroupDataAccess().Update(obj);
            var group = mapper.Map<GroupDTO>(updt);
            return mapper.Map<GroupDTO>(group);
        }

        public static List<GroupDTO> Get()
        {
            var data = DataAccessFactory.GroupDataAccess().Get();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, GroupDTO>());
            var mapper = new Mapper(config);
            var groups = mapper.Map<List<GroupDTO>>(data);
            return groups;

        }
    }
}