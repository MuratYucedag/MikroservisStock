// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
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

        public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email()
        };

        public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
        {
            new ApiScope("CatalogReadPermisson","Reading Authority for Catalog Operations"),
            new ApiScope("CatalogFullPermisson","Full Authority for Catalog Operations"),
            new ApiScope("OrderFullPermisson","Full Authority for Order Operations"),
            new ApiScope("CargoFullPermisson","Full Authority for Cargo Operations"),
            new ApiScope("BasketFullPermisson","Full Authority for Basket Operations"),
            new ApiScope("PaymentFullPermisson","Full Authority for Payment Operations"),
            new ApiScope("MessageFullPermisson","Full Authority for Message Operations"),
            new ApiScope("DiscountFullPermisson","Full Authority for Discount Operations")
        };

        public static IEnumerable<Client> Clients => new Client[]
        {
            //Visitor
            new Client
            {
                ClientId="MikroservisStockUserId",
                ClientName="Mikroservis Stok Visitor User",
                AllowedGrantTypes=GrantTypes.ClientCredentials,
                ClientSecrets={new Secret("mikroservisstock".Sha256())},
                AllowedScopes={ "CatalogReadPermisson",IdentityServerConstants.LocalApi.ScopeName }
            },

            //Store Manager
             new Client
            {
                ClientId="MikroservisStockStoreManagerId",
                ClientName="Mikroservis Stok Store Manager User",
                AllowedGrantTypes=GrantTypes.ResourceOwnerPassword,
                ClientSecrets={new Secret("mikroservisstock".Sha256())},
                AllowedScopes={ "CatalogReadPermisson", "CatalogFullPermisson", "OrderFullPermisson", IdentityServerConstants.LocalApi.ScopeName,
                 IdentityServerConstants.StandardScopes.Email,
                 IdentityServerConstants.StandardScopes.OpenId,
                 IdentityServerConstants.StandardScopes.Profile
                 }
             },

               //Admin Manager
             new Client
            {
                ClientId="MikroservisStockAdminId",
                ClientName="Mikroservis Stok Admin User",
                AllowedGrantTypes=GrantTypes.ResourceOwnerPassword,
                ClientSecrets={new Secret("mikroservisstock".Sha256())},
                AllowedScopes={ "CatalogReadPermisson", "CatalogFullPermisson", "OrderFullPermisson","CargoFullPermisson","BasketFullPermisson","PaymentFullPermisson","MessageFullPermisson","DiscountFullPermisson", IdentityServerConstants.LocalApi.ScopeName,
                 IdentityServerConstants.StandardScopes.Email,
                 IdentityServerConstants.StandardScopes.OpenId,
                 IdentityServerConstants.StandardScopes.Profile
                 },
                AccessTokenLifetime=600
             }
        };
    }
}