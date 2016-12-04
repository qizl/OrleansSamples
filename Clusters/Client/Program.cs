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
                if (string.IsNullOrEmpty(userName)) continue;
                var userService = GrainClient.GrainFactory.GetGrain<IUserGrain>(userName);
                Console.WriteLine($"用户{userName}，{(userService.Exist().Result ? "已存在！" : "不存在！")}");
                if (userName == "exit")
                    GrainClient.Uninitialize();
            }
        }
    }
}