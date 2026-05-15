using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Pretend legacy HR system; would be replaced with real call out to a vendor API in production.
namespace StaffUniformTracker.Patterns.Adapter;

public sealed class ExternalHRSystem
{
    public IReadOnlyList<IDictionary<string, string>> FetchPersonnel(string clientCode)
    {
        var rows = new List<IDictionary<string, string>>();
        if (clientCode == "C-001")
        {
            rows.Add(new Dictionary<string, string>
            {
                ["EMP_NO"] = "98011",
                ["FULL_NM"] = "Jane Smith",
                ["JOB_TITLE"] = "Nurse"
            });
            rows.Add(new Dictionary<string, string>
            {
                ["EMP_NO"] = "98012",
                ["FULL_NM"] = "Aaron Patel",
                ["JOB_TITLE"] = "Nurse"
            });
        }
        else if (clientCode == "C-002")
        {
            rows.Add(new Dictionary<string, string>
            {
                ["EMP_NO"] = "20001",
                ["FULL_NM"] = "Maria Garcia",
                ["JOB_TITLE"] = "Chef"
            });
        }
        return rows;
    }
}
