using AdapterPattern;

ComputerGame computerGame = new ComputerGame("Cool Game", PegiAgeRating.P16, 60, 2048, 50, 16, 8, 3.2);


ComputerGameAdapter adapter = new ComputerGameAdapter(computerGame);


Console.WriteLine("Title: " + adapter.getTitle());
Console.WriteLine("PEGI Allowed Age: " + adapter.getPegiAllowedAge());
Console.WriteLine("Is Triple-A Game: " + (adapter.isTripleAGame() ? "Yes" : "No"));

Requirements gameRequirements = adapter.getRequirements();
Console.WriteLine("Minimum GPU Memory: " + gameRequirements.getGpuGb() + " GB");
Console.WriteLine("Disk Space Needed: " + gameRequirements.getHDDGb() + " GB");
Console.WriteLine("RAM Needed: " + gameRequirements.getRAMGb() + " GB");
Console.WriteLine("Core Speed: " + gameRequirements.getCpuGhz() + " GHz");
Console.WriteLine("Number of Cores Needed: " + gameRequirements.getCoresNum() + ".");

