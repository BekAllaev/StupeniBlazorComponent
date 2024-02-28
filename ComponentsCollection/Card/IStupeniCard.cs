using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsCollection.Card;

/// <summary>
/// Card which have title, content and button in the right top corner
/// </summary>
public interface IStupeniCard
{
    [Parameter]
    public string? Icon { get; set; }

    [Parameter]
    public string? Title { get; set; }

    [Parameter]
    public string? ButtonText { get; set; }

    [Parameter]
    public Color ButtonColor { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public bool IsButtonDisabled { get; set; }

}
