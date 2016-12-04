using Orleans;
using Sample.Interfaces;
using System.Threading.Tasks;
using System;

namespace Sample.Implements
{
    public class UserService : Grain, IUserService
    {
        public Task<bool> Exist(string userName) => Task.FromResult(userName == "qizl");
    }
}