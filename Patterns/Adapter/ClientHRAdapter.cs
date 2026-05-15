using StaffUniformTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Actaul Adapter implementation (structural).
namespace StaffUniformTracker.Patterns.Adapter;

public sealed class ClientHRAdapter : IStaffSource
{
    private readonly ExternalHRSystem _ext;
    public ClientHRAdapter(ExternalHRSystem ext) => _ext = ext;
    public IReadOnlyList<Staff> ReadAll(string clientId)
    {
        var rows = _ext.FetchPersonnel(clientId);
        var list = new List<Staff>(rows.Count);
        foreach (var r in rows)
            list.Add(new Staff($"S-{r["EMP_NO"]}", clientId, r["FULL_NM"], r["JOB_TITLE"]));
        return list;
    }
}
