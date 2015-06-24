using System;
using TogglDesktop.WPF.AutoComplete;

namespace TogglDesktop.AutoCompletion.Implementation
{
    class DescriptionItem : SimpleItem<DescriptionAutoCompleteEntry, Toggl.AutocompleteItem>
    {
        public DescriptionItem(Toggl.AutocompleteItem item) : base(item, item.Description)
        {
        }

        protected override DescriptionAutoCompleteEntry createElement(Action selectWithClick)
        {
            return new DescriptionAutoCompleteEntry(this.Item, selectWithClick);
        }
    }
}