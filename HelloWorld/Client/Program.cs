using Orleans;
using Sample.Interfaces;
using System;

namespace Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GrainClient.Initialize();

            while (true)
            {
                Console.WriteLine("请输入用户名来判断是否存在：");
                var userName = Console.ReadLine();
                var userService = GrainClient.GrainFactory.GetGrain<IUserService>(0);
                Console.WriteLine($"用户{userName}，{(userService.Exist(userName).Result ? "已存在！" : "不存在！")}");
            }
        }
    }
}