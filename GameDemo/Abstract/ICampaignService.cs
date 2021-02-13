using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface ICampaignService : IRepositoryService<Campaign>
    {
        Console.WriteLine("abc");
    }
}