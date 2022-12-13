using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DataAccessLayer.Entities;
using Front.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front.Pages
{
    public class SpendingListBase : ComponentBase
    {
        [Inject]
        public ISpendingService SpendingService { get; set; }
        public IEnumerable<Spending> Spendings { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Spendings = (await SpendingService.GetSpendings()).ToList();
        }
    }
}