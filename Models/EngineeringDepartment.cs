namespace MVC_App.Models;

public class EngineeringDepartment
{
    public string[] CurrentSoftwareProjects { get; set; }

    public EngineeringDepartment()
    {
        // Retrieve data from DB or web service
        CurrentSoftwareProjects = ["Cool Web App", "Mobile App Update", "Data Visual App"];
    }
}