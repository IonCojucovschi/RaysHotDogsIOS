using System;
using System.Collections.Generic;
using System.Linq;
using RaysHotDogs.Core.Model;

namespace RaysHotDogs.Core.Repository
{
    public class HotDogRepository
    {
        public HotDogRepository()
        {
        }

        ///method who work wit hotdiog groups
        public List<HotDogGroup> GetHotDogGroups()
        {
            return hotDogGroups;
        }


        public List<HotDog> GetHotDogsFromGroup(int grID)
        {

            ///may be not do what i want
            var hotDogs =
              from HotDoggroup in hotDogGroups
              where HotDoggroup.HotDogGroupID == grID
              select HotDoggroup.HotDogs;

            return hotDogs.FirstOrDefault();
        }

        public List<HotDog> GetFavoriteHotDogs()
        {
            IEnumerable<HotDog> hotDogs =
               from htdgGR in hotDogGroups
               from htdg in htdgGR.HotDogs
               where htdg.IsFavorite
               select htdg;
            return hotDogs.ToList<HotDog>();
        }

        /// <summary>
        /// /mnethot wo work woth hotDogs
        /// </summary>
        /// <returns>The all hot dogs.</returns>
        public List<HotDog> GetAllHotDogs()
        {
            IEnumerable<HotDog> hotDogs =
                from HotDoggroup in hotDogGroups
                from Hotdog in HotDoggroup.HotDogs
                select Hotdog;

            return hotDogs.ToList<HotDog>();
        }
        public HotDog GetHotDogById(int idHot)
        {
            IEnumerable<HotDog> hotDogs =
                from htdgGR in hotDogGroups
                from htdg in htdgGR.HotDogs
                where htdg.HotDogId == idHot
                select htdg;
            return hotDogs.FirstOrDefault();
        }



        // <summary>
        /// initialize method who initialize all groups of hot dogs
        /// </summary>
        private static List<HotDogGroup> hotDogGroups = new List<HotDogGroup>()
        {
            new HotDogGroup()
            {
                HotDogGroupID=1,
                Title="Meat Lovers",
                ImagePath="",
                HotDogs=new List<HotDog>()
                {
                    new HotDog()
                    {
                        HotDogId=1,
                        Name="Regular Hot Dog",
                        ShortDescription="Id 1 Short description some text tra la la",
                        Description="ID 1 description of hot dog with id 1 sdfgs sdf gsd fg sdf gsd fg sd fg sdfg sdf g tra la la ",
                        ImagePath="hotDog1",
                        Available=true,
                        PrepTime=10,
                        Ingredients=new List<string>(){"ingredient 1","ingredient 2","ingredient 3","ingredient 4", "ingredient 5"},
                        Price=8,
                        IsFavorite=true
                     },
                    new HotDog()
                    {
                        HotDogId=2,
                        Name="Regular2 Hot2 Dog2",
                        ShortDescription="Id 2 Short description some text tra la la",
                        Description="ID 2 description of hot dog with id 2 sdfgs sdf gsd fg sdf gsd fg sd fg sdfg sdf g tra la la ",
                        ImagePath="hotDog2",
                        Available=true,
                        PrepTime=10,
                        Ingredients=new List<string>(){"ingredient 1","ingredient 2","ingredient 3","ingredient 4", "ingredient 5"},
                        Price=10,
                        IsFavorite=true
                     },
                    new HotDog()
                    {
                        HotDogId=3,
                        Name="Regular3 Hot3 Dog3",
                        ShortDescription="Id 3 Short description some text tra la la",
                        Description="ID 3 description of hot dog with id 3 sdfgs sdf gsd fg sdf gsd fg sd fg sdfg sdf g tra la la ",
                        ImagePath="hotDog1",
                        Available=true,
                        PrepTime=15,
                        Ingredients=new List<string>(){"ingredient 1","ingredient 2","ingredient 3","ingredient 4", "ingredient 5"},
                        Price=15,
                        IsFavorite=false
                     }
                }
            },
            new HotDogGroup()
            {
                HotDogGroupID=2,
                Title="Vegie Lovers",
                ImagePath="",
                HotDogs=new List<HotDog>()
                {
                    new HotDog()
                    {
                        HotDogId=4,
                        Name="Vegie1 Hot Dog",
                        ShortDescription="Id 4 Short description some text tra la la",
                        Description="ID 4 description of hot dog with id 1 sdfgs sdf gsd fg sdf gsd fg sd fg sdfg sdf g tra la la ",
                        ImagePath="hotDog1",
                        Available=true,
                        PrepTime=10,
                        Ingredients=new List<string>(){"ingredient 1","ingredient 2","ingredient 3","ingredient 4", "ingredient 5"},
                        Price=8,
                        IsFavorite=true
                     },
                    new HotDog()
                    {
                        HotDogId=5,
                        Name="Vegie5 Hot Dog",
                        ShortDescription="Id 5 Short description some text tra la la",
                        Description="ID 5 description of hot dog with id 1 sdfgs sdf gsd fg sdf gsd fg sd fg sdfg sdf g tra la la ",
                        ImagePath="hotDog5",
                        Available=true,
                        PrepTime=15,
                        Ingredients=new List<string>(){"ingredient 1","ingredient 2","ingredient 3","ingredient 4", "ingredient 5"},
                        Price=81,
                        IsFavorite=false
                     },
                    new HotDog()
                    {
                        HotDogId=6,
                        Name="Vegie6 Hot Dog",
                        ShortDescription="Id 6 Short description some text tra la la",
                        Description="ID 6 description of hot dog with id 1 sdfgs sdf gsd fg sdf gsd fg sd fg sdfg sdf g tra la la ",
                        ImagePath="hotDog6",
                        Available=true,
                        PrepTime=16,
                        Ingredients=new List<string>(){"ingredient 1","ingredient 2","ingredient 3","ingredient 4", "ingredient 5"},
                        Price=61,
                        IsFavorite=true
                     }
                }
            },
            new HotDogGroup()
            {

                HotDogGroupID=2,
                Title="Vegie Lovers",
                ImagePath="",
                HotDogs=new List<HotDog>()
                {
                    new HotDog()
                    {
                        HotDogId=7,
                        Name="Vegie7 Hot Dog",
                        ShortDescription="Id 7 Short description some text tra la la",
                        Description="ID 7 description of hot dog with id 1 sdfgs sdf gsd fg sdf gsd fg sd fg sdfg sdf g tra la la ",
                        ImagePath="hotDog7",
                        Available=true,
                        PrepTime=7,
                        Ingredients=new List<string>(){"ingredient 1","ingredient 2","ingredient 3","ingredient 4", "ingredient 5"},
                        Price=77,
                        IsFavorite=true
                     },
                    new HotDog()
                    {
                        HotDogId=7,
                        Name="Vegie7 Hot Dog",
                        ShortDescription="Id 7 Short description some text tra la la",
                        Description="ID 5 description of hot dog with id 1 sdfgs sdf gsd fg sdf gsd fg sd fg sdfg sdf g tra la la ",
                        ImagePath="hotDog5",
                        Available=true,
                        PrepTime=15,
                        Ingredients=new List<string>(){"ingredient 1","ingredient 2","ingredient 3","ingredient 4", "ingredient 5"},
                        Price=81,
                        IsFavorite=false
                     },
                    new HotDog()
                    {
                        HotDogId=8,
                        Name="Vegie6 Hot Dog",
                        ShortDescription="Id 8 Short description some text tra la la",
                        Description="ID 8 description of hot dog with id 1 sdfgs sdf gsd fg sdf gsd fg sd fg sdfg sdf g tra la la ",
                        ImagePath="hotDog6",
                        Available=true,
                        PrepTime=8,
                        Ingredients=new List<string>(){"ingredient 1","ingredient 2","ingredient 3","ingredient 4", "ingredient 5"},
                        Price=61,
                        IsFavorite=false
                     }
                }
            }
        };
    }
}
