using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPatternExample
{
    internal sealed class ManagementInstance
    {
        private static readonly ManagementInstance Instance = new ManagementInstance();

        private readonly List<ShoppingCart> _carts;
        private readonly Random _random = new Random();

        private ManagementInstance()
        {
            _carts = new List<ShoppingCart>
            {
                new ShoppingCart{ Id = Guid.NewGuid(), OwnerName = "Jeff" },
                new ShoppingCart{ Id = Guid.NewGuid(), OwnerName = "Mary" },
                new ShoppingCart{ Id = Guid.NewGuid(), OwnerName = "Rick" },
                new ShoppingCart{ Id = Guid.NewGuid(), OwnerName = "Tedd"  },
            };
        }

        public static ManagementInstance GetManagementInstance()
        {
            return Instance;
        }

        public ShoppingCart NextCart
        {
            get 
            {
                var r = _random.Next(_carts.Count);
                return _carts[r];
            }
        }
    }
}
