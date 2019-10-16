using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1_Connor_Clarkson.Models
{
    public static class Repository
    {
        public static int Count = 0;
        private static List<Request> _requests = new List<Request>();

        public static void AddResponse(Request request)
        {

            Count++;
            request.Id = Count;
            _requests.Add(request);
        }

        public static IEnumerable<Request> GetRequests()
        {
            return _requests;
        }
        private static List<Equipment> _equipment = new List<Equipment>();

        public static void AddEquipment(Equipment equipment)
        {
            _equipment.Add(equipment);
        }

        public static IEnumerable<Equipment> GetEquipments()
        {
            return _equipment;
        }

    }
}
