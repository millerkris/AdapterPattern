﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class ComputerGameAdapter : PCGame
    {
        private readonly ComputerGame computerGame;

        public ComputerGameAdapter(ComputerGame computerGame)
        {
            this.computerGame = computerGame;
        }

        public string getTitle()
        {
            return computerGame.getName();
        }

        public int getPegiAllowedAge()
        {
            switch (computerGame.getPegiAgeRating())
            {
                case PegiAgeRating.P3:
                    return 3;
                case PegiAgeRating.P7:
                    return 7;
                case PegiAgeRating.P12:
                    return 12;
                case PegiAgeRating.P16:
                    return 16;
                case PegiAgeRating.P18:
                    return 18;
                default:
                    return 0;
            }
        }

        public bool isTripleAGame()
        {
            return computerGame.getBudgetInMillionsOfDollars() > 50;
        }

        public Requirements getRequirements()
        {
            int gpuMemoryInGb = computerGame.getMinimumGpuMemoryInMegabytes() / 1024;  // Convert GPU memory from megabytes to gigabytes
            int diskSpaceNeeded = computerGame.getDiskSpaceNeededInGB();
            int ramNeeded = computerGame.getRamNeededInGb();
            double coreSpeed = computerGame.getCoreSpeedInGhz();
            int coresNeeded = computerGame.getCoresNeeded();

            return new Requirements(gpuMemoryInGb, diskSpaceNeeded, ramNeeded, coreSpeed, coresNeeded);
        }
    }
}
