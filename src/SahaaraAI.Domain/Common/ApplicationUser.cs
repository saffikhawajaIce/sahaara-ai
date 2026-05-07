using Microsoft.AspNetCore.Identity;
using SahaaraAI.Domain.Entities;

namespace SahaaraAI.Infrastructure.Persistence;

public class ApplicationUser : IdentityUser
{
    // other properties...

    public ICollection<CaseNote> Notes { get; set; } = new List<CaseNote>();
    public ICollection<ConsentRecord> ConsentRecords { get; set; } = new List<ConsentRecord>();
}
//i need to add a navigation property to the ApplicationUser class that links to the CaseNote entity, so that I can track which user created each case note.
//i need to add the identity framework to the project and create an ApplicationUser class that inherits from IdentityUser, and then add a navigation property to the CaseNote entity that links to the ApplicationUser class.
//to do this i need to run the following command in the terminal: dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
//after that i need to create the ApplicationUser class in the SahaaraAI.Infrastructure.Persistence namespace and add the necessary properties and navigation properties to link it to the CaseNote entity.