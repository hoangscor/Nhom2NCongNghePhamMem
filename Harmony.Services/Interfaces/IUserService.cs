using Harmony.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harmony.Repositories.Entities;

namespace Harmony.Services.Interfaces
{
	internal interface IUserService
	{
		Task<List<User>> Users();
	}
}
