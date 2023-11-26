using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xrocter.Models;
using Xrocter.Vault_Models.ID;

namespace Xrocter.Controllers.VaultControllers.IDControllers
{
    public class DriversLicenseController
    {
        // Database context
        private readonly AppDbContext _appDBContext;

        // Constructor injecting the database context
        public DriversLicenseController(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        // Retrieve all driver's licenses asynchronously
        public async Task<List<DriversLicense>> GetAllDriverLicensesAsync()
        {
            return await _appDBContext.DriversLicenses.ToListAsync();
        }

        // Retrieve driver's license by LicenseId asynchronously
        public async Task<DriversLicense> GetDriversLicenseByLicenseIdAsync(string licenseId)
        {
            return await _appDBContext.DriversLicenses.FirstOrDefaultAsync(dl => dl.LicenseId == licenseId);
        }

        // Retrieve driver's license by VaultId asynchronously
        public async Task<DriversLicense> GetDriversLicenseByVaultIdAsync(Guid vaultId)
        {
            return await _appDBContext.DriversLicenses.FirstOrDefaultAsync(dl => dl.VaultId == vaultId);
        }

        // Add a new driver's license asynchronously
        public async Task<bool> AddDriversLicenseAsync(DriversLicense driversLicense)
        {
            await _appDBContext.DriversLicenses.AddAsync(driversLicense);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Update an existing driver's license asynchronously
        public async Task<bool> UpdateDriversLicenseAsync(DriversLicense driversLicense)
        {
            _appDBContext.DriversLicenses.Update(driversLicense);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

        // Delete an existing driver's license asynchronously
        public async Task<bool> DeleteDriversLicenseAsync(string licenseId)
        {
            var driversLicense = await _appDBContext.DriversLicenses.FirstOrDefaultAsync(dl => dl.LicenseId == licenseId);
            if (driversLicense == null)
            {
                return false;
            }

            _appDBContext.DriversLicenses.Remove(driversLicense);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
    }
}