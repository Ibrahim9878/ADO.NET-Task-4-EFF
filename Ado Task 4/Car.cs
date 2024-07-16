namespace Ado_Task_4;

public class Car
{
    public int Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string StNumber { get; set; }

    public override string ToString()
    {
        return $"{Id} {Make} {Model} {Year} {StNumber}"; 
    }
    public Car()
    {
        
    }

    public Car(string make, string model, int year,string stNumber)
    {
        Year = year;
        Make = make;
        Model = model;
        StNumber = stNumber;
    }
}
