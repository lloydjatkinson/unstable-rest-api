using System;
using System.Threading.Tasks;

namespace UnstableRestApi.Services
{
    public static class RandomDelayHelper
    {
        public static async Task DelayRandomly(int maximum)
        {
            bool shouldDelay = new Random().Next(0, 2) == 0 ? true : false;
            int delay = 0;

            if (shouldDelay)
            {
                delay = new Random().Next(1, maximum) * 1000;
            }

            await Task.Delay(delay);
        }
    }
}