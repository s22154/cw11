// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace cw11.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using cw11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using cw11.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using cw11.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/_Imports.razor"
using cw11.Data.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class Students : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "/Users/Dynia/Desktop/Studia/PJATK/APBD/APBD11/cw11/cw11/Pages/Students.razor"
       
    public IEnumerable<Student> StudentsList { get; set; }
    private bool IsSortedAscending;
    private string CurrentSortColumn;

    protected override void OnInitialized()
    {
        StudentsList = StudentService.GetStudents();
    }

    private void OpenDetails(int id)
    {
        NavigationManager.NavigateTo($"/students/{id}");
    }

    private async Task Delete(int id)
    {
        if(await js.InvokeAsync<bool>("confirm", "Are you sure?"))
        {
            StudentService.DeleteStudent(id);
        }
    }

    private void SortTable(string columnName)
    {
        if (columnName != CurrentSortColumn)
        {
            StudentsList = StudentsList.OrderBy(x => x.GetType()
                .GetProperty(columnName)?.GetValue(x, null))
                .ToList();
            CurrentSortColumn = columnName;
            IsSortedAscending = true;
        }
        else
        {
            if (IsSortedAscending)
            {
                StudentsList = StudentsList.OrderByDescending(x => x.GetType()
                    .GetProperty(columnName)?.GetValue(x, null))
                    .ToList();
            }
            else
            {
                StudentsList = StudentsList.OrderBy(x => x.GetType()
                    .GetProperty(columnName)?.GetValue(x, null))
                    .ToList();
            }

            IsSortedAscending = !IsSortedAscending;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService StudentService { get; set; }
    }
}
#pragma warning restore 1591
