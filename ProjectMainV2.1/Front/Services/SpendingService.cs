using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Front.Services
{
    public class SpendingService : ISpendingService
    {
        private readonly HttpClient _httpClient;

        public SpendingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Spending>> GetSpendings()
        {
            return await _httpClient.GetJsonAsync<Spending[]>("api/Spending");
        }
    }
}
