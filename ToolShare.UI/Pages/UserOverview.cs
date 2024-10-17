using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolShare.Data;

namespace ToolShare.UI.Pages
{
    public partial class UserOverview
    {
        public IEnumerable<User> Users { get; set; }
        public List<Pod> Pods { get; set; }
        public List<Tool> Tools { get; set; }

        protected override Task OnInitializedAsync()
        {
            InitializeUsers();
            InitializePods();
            InitializeTools();
            
            return base.OnInitializedAsync();
        }

        private void InitializePods()
        {
            Pods = new List<Pod>()
            {
                new Pod { PodId = 1, Name = "Thompson Family"},
                new Pod { PodId = 2, Name = "Neighborhood Pod"}
            };
        }

        private void InitializeTools()
        {
            Tools = new List<Tool>()
            {
                new Tool { ToolId = 1, Name = "Scroll Saw", BorrowingPeriodInDays = 7, CreatedAt = DateTime.Now, Description = "A Scroll Saw", IsOwnedById = 1, IsPossessedById = 2 },
                new Tool { ToolId = 2, Name = "Power Washer", BorrowingPeriodInDays = 14, CreatedAt = DateTime.Now, Description = "A Powerwasher", IsOwnedById = 2, IsPossessedById = 1}
            };
        }

        private void InitializeUsers()
        {
            var u1 = new User 
            {
                UserId = "1",
                UserName = "tomSmith",
                Email = "tomsmith@aol.com",
                FirstName = "Tom",
                LastName = "Smith",
                AboutMe = "I am Tom Smith",
                PodId = 1,
            };

            var u2 = new User 
            {
                UserId = "2",
                UserName = "bettySmith",
                Email = "bettysmith@aol.com",
                FirstName = "Betty",
                LastName = "Smith",
                AboutMe = "I am Betty Smith",
                PodId = 2,
            };

            Users = new List<User> { u1, u2 }; 
        }
    }
}