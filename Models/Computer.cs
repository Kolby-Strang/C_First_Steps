namespace C_First_Steps.Models;

public class Computer(int id, string cpu, string gpu, int ramSize, int storageSize, string formFactor)
{
    public int Id { get; set; } = id;
    public string CPU { get; set; } = cpu;
    public string GPU { get; set; } = gpu;
    public int RamSize { get; set; } = ramSize;
    public int StorageSize { get; set; } = storageSize;
    public string FormFactor { get; set; } = formFactor;
}
