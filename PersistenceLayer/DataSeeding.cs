using DomainLayer.Contracts;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using PersistenceLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PersistenceLayer
{
    public class DataSeeding(StoreDbContext _storeDbContext) : IDataSeeding
    {
        public void DataSeed()
        {
            try
            {
                if (_storeDbContext.Database.GetPendingMigrations().Any())
                {

                    _storeDbContext.Database.Migrate();
                }
                if (!_storeDbContext.productBrands.Any())
                {
                    var ProductBrandsData = File.ReadAllText("C:\\Users\\maiab\\source\\repos\\TalabatDemoSolution\\PersistenceLayer\\Data\\DataSeeding\\brands.json");
                    //convert string to c# object
                    var brands = JsonSerializer.Deserialize<List<ProductBrand>>(ProductBrandsData);

                    if (brands is not null && brands.Any())
                    {
                        _storeDbContext.productBrands.AddRange(brands);
                    }
                }
                if (!_storeDbContext.productTpes.Any())
                {
                    var ProductTypesData = File.ReadAllText("C:\\Users\\maiab\\source\\repos\\TalabatDemoSolution\\PersistenceLayer\\Data\\DataSeeding\\types.json");
                    //convert string to c# object
                    var Types = JsonSerializer.Deserialize<List<ProductType>>(ProductTypesData);

                    if (Types is not null && Types.Any())
                    {
                        _storeDbContext.productTpes.AddRange(Types);
                    }
                }
                if (!_storeDbContext.products.Any())
                {
                    var ProductData = File.ReadAllText("C:\\Users\\maiab\\source\\repos\\TalabatDemoSolution\\PersistenceLayer\\Data\\DataSeeding\\products.json");
                    //convert string to c# object
                    var products = JsonSerializer.Deserialize<List<Product>>(ProductData);

                    if (products is not null && products.Any())
                    {
                        _storeDbContext.products.AddRange(products);
                    }
                }
                _storeDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

                }
            }
            }
        
    








    

    

