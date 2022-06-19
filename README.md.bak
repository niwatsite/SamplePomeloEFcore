
# Sample Pomelo EFcore
Sample Project Pomelo EFcore (.net6)


# Install Packages

**Entity Framework Core Tools:**
`Install-Package Microsoft.EntityFrameworkCore.Tools`

**Pomelo MySQL provider for Entity Framework:**
`Install-Package Pomelo.EntityFrameworkCore.MySql`

## Create files and folders with command

dotnet ef dbcontext scaffold "server=**localhost**;port=**3306**;database=**applicationdb**;uid=**root**;password=**pwd**" "Pomelo.EntityFrameworkCore.MySql"  --context **ApplicationDbContext** --context-dir Context  --output-dir **Models** --use-database-names --force **--project SamplePomeloEFcore**

## Add a Connection String

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "ApplicationDbContext": "Server=localhost; Port=3306; Database=applicationdb; Uid=root; Pwd=pwd;"
  }
}

```

## Configure App To Use MySQL
open file **Program.cs**.
```csharp
using Microsoft.EntityFrameworkCore;
using SamplePomeloEFcore.Context;

var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContext");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

```

## Configure controller To Use DbContext
open file **SampleController.cs**.
```csharp
using Microsoft.AspNetCore.Mvc;
using SamplePomeloEFcore.Context;
using SamplePomeloEFcore.Models;

namespace SamplePomeloEFcore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {

        private ApplicationDbContext context;
        public SampleController(ApplicationDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public IList<sample> Get()
        {
            return (this.context.samples.ToList());
        }

    }
}

```

