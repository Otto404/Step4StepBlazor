using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace WebassemblyBlazor.Client.Components
{
    /*
     * In der Vorgängerversion musste die Componente von einer Basis-Klasse abgeleitet werden,
     * die ihrerseits von ComponentBase abgeleitet ist. 
     * Seit Blazor 3.0 ist das nicht mehr notwendig; die (Code-Behind) Klasse muss nun den gleichen
     * Namen wir die Componente tragen (bis auf .blazor, .cs)
     * 
     * */
    // wichtig - partial
    public partial class IntCounterCodeBehind
    {
        [Parameter]
        public EventCallback<int> OnUpdate { get; set; }

        int _currentCount;

        protected async Task IncrementCount()
        {
            _currentCount++;
            await OnUpdate.InvokeAsync(_currentCount);
        }
    }
}
