﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deac_Renata_Lab11.Models;

namespace Deac_Renata_Lab11.Data
{ 
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();

        Task SaveShopListAsync(ShopList item, bool isNewItem);

        Task DeleteShopListAsync(int id);
    }
}
