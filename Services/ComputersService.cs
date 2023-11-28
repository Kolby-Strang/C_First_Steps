

using Microsoft.AspNetCore.Http.HttpResults;

namespace C_First_Steps.Services;

public class ComputersService
{
    private readonly ComputersRepository _repo;

    public ComputersService(ComputersRepository repo)
    {
        _repo = repo;
    }

    internal Computer CreateComputer(Computer computerData)
    {
        Computer computer = _repo.CreateComputer(computerData);
        return computer;
    }

    internal string DeleteComputer(int computerId)
    {
        Computer computer = GetComputerById(computerId);
        string message = _repo.DeleteComputer(computer);
        return message;
    }

    internal Computer GetComputerById(int computerId)
    {
        Computer computer = _repo.GetComputerById(computerId);
        if (computer == null)
        {
            throw new Exception($"Computer Id Invalid: {computerId}");
        }
        return computer;
    }

    internal List<Computer> GetComputers()
    {
        List<Computer> computers = _repo.GetComputers();
        return computers;
    }
}