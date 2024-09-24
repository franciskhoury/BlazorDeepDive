using Microsoft.AspNetCore.Components;

namespace ServerManagement.Components.Controls;

public class BaseComponent : ComponentBase
{
    protected bool IsFirstRender { get; set; } = true;

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);

        IsFirstRender = firstRender;
    }

}
