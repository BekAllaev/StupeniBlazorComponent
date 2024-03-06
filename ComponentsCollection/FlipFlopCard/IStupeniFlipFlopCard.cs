using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsCollection.FlipFlopCard
{
    internal interface IStupeniFlipFlopCard
    {
        [Parameter]
        public string? Icon { get; set; }

        [Parameter]
        public string? Title { get; set; }

        /// <summary>
        /// Text of the button when main content is shown
        /// </summary>
        [Parameter]
        public string MainContentButtonText { get; set; }

        /// <summary>
        /// Text of the button when alternative content is shown
        /// </summary>
        [Parameter]
        public string AlternativeContentButtonText { get; set; }

        [Parameter]
        public Color ButtonColor { get; set; }

        /// <summary>
        /// Content that is shown when component is loaded
        /// </summary>
        [Parameter]
        public RenderFragment MainChildContent { get; set; }

        [Parameter]
        public RenderFragment AlternativeChildContent { get; set; }

        [Parameter]
        public bool IsButtonDisabled { get; set; }
    }
}
