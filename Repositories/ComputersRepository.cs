



namespace C_First_Steps.Repositories;

public class ComputersRepository
{
    private List<Computer> _computers;
    public ComputersRepository()
    {
        _computers = [
            new Computer(1, "intel i5 10500K", "RTX 4090", 32, 1028, "ATX")
        ];
    }

    internal Computer CreateComputer(Computer computerData)
    {
        _computers.Add(computerData);
        return computerData;
    }

    internal string DeleteComputer(Computer computer)
    {
        _computers.Remove(computer);
        return $"Computer with id: {computer.Id} was deleted";
    }

    internal Computer GetComputerById(int computerId)
    {
        Computer foundComputer = _computers.Find(computer => computer.Id == computerId);
        return foundComputer;
    }

    internal List<Computer> GetComputers()
    {
        return _computers;
    }
}