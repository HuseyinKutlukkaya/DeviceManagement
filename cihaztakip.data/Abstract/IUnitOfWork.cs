﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cihaztakip.data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IDeviceRepository Devices { get; }
        IUserRepository Users { get; }
        void Save();
        Task<int> SaveAsync();

    }
}