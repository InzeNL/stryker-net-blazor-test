using Microsoft.AspNetCore.Components;
using System;

namespace InzeNL.Stryker.Blazor.NoPartialClasses.Pages
{
    public class IndexPage : ComponentBase
    {
        protected override void OnAfterRender(bool firstRender)
        {
            Console.WriteLine("Testing This Stuff");
            base.OnAfterRender(firstRender);
        }
    }
}
