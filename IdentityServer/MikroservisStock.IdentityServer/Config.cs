// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace MikroservisStock.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
          new ApiResource("ResourceCatalog"){Scopes={"CatalogReadPermisson"}},
          new ApiResource("ResourceCatalog2"){Scopes={"CatalogFullPermisson"}},
          new ApiResource("ResourceOrder"){Scopes={"OrderFullPermisson"}},
          new ApiResource("ResourceCargo"){Scopes={"CargoFullPermisson"}},
          new ApiResource("ResourceBasket"){Scopes={"BasketFullPermisson"}},
          new ApiResource("ResourcePayment"){Scopes={"PaymentFullPermisson"}},
          new ApiResource("ResourceMessage"){Scopes={"MessageFullPermisson"}},
          new ApiResource("ResourceDiscount"){Scopes={"DiscountFullPermisson"}},
        };
    }
}