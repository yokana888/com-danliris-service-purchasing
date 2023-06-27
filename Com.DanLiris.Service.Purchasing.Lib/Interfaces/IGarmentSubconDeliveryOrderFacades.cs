﻿using Com.DanLiris.Service.Purchasing.Lib.Models.GarmentSubconDeliveryOrderModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.DanLiris.Service.Purchasing.Lib.Interfaces
{
    public interface IGarmentSubconDeliveryOrderFacades
    {
        Tuple<List<GarmentSubconDeliveryOrder>, int, Dictionary<string, string>> Read(int Page = 1, int Size = 25, string Order = "{}", string Keyword = null, string Filter = "{}");
        GarmentSubconDeliveryOrder ReadById(int id);
        Task<int> Create(GarmentSubconDeliveryOrder m, string user, int clientTimeZoneOffset = 7);
        Task<int> Delete(int id, string user);
        Task<int> Update(int id, GarmentSubconDeliveryOrder newModel, string user, int clientTimeZoneOffset = 7);
    }
}
