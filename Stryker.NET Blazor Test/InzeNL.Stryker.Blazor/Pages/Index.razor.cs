using System;

namespace InzeNL.Stryker.Blazor.Pages
{
    public partial class Index
    {
        protected override void OnAfterRender(bool firstRender)
        {
            Console.WriteLine("Testing This Stuff");
            base.OnAfterRender(firstRender);
        }
    }
}
