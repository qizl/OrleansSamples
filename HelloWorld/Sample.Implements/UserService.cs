using Orleans;
using Sample.Interfaces;
using System.Threading.Tasks;

namespace Sample.Implements
{
    public class UserService : Grain, IUserService
    {
        public Task<bool> Exist(string userName) => Task.FromResult(userName == "qizl");
    }
}