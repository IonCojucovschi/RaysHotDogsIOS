using System;
using System.Collections.Generic;
using RaysHotDogs.Core.Model;
using RaysHotDogs.Core.Repository;

namespace RaysHotDogs.Core.Service
{
    public class HotDogDetailServices
    {

        private static HotDogRepository hotDogRepository = new HotDogRepository();
        public HotDogDetailServices()
        {
        }

        ///method who work wit hotdiog groups
        public List<HotDogGroup> GetHotDogGroups()
        {
            return hotDogRepository.GetHotDogGroups();
        }


        public List<HotDog> GetHotDogsFromGroup(int grID)
        {

            ///may be not do what i want
            return hotDogRepository.GetHotDogsFromGroup(grID);
        }

        public List<HotDog> GetFavoriteHotDogs()
        {
            return hotDogRepository.GetFavoriteHotDogs();
        }

        /// <summary>
        /// /mnethot wo work woth hotDogs
        /// </summary>
        /// <returns>The all hot dogs.</returns>
        public List<HotDog> GetAllHotDogs()
        {
            return hotDogRepository.GetAllHotDogs();
        }

        public HotDog GetHotDogById(int idHot)
        {
            return hotDogRepository.GetHotDogById(idHot);
        }

    }
}
