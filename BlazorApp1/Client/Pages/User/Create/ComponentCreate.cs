

using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Client.Pages.User.Create
{
    public partial class ComponentCreate
    {
        private string Name;

        private string? validInput;
        private void Send()
        {
            //if (string.IsNullOrEmpty(name))
            //{
            //    Console.WriteLine(name);
            //}
            
            //validInput = string.IsNullOrEmpty(Name) ? "is-invalid" : "is-valid";
        }

        private void ValidateInput(ChangeEventArgs e)
        {
            //validInput = string.IsNullOrEmpty(Name) ? "is-invalid" : "is-valid";
            Name = e.Value.ToString();
            //validInput = string.IsNullOrEmpty(Name) ? "is-invalid" : "is-valid";

        }
    }
}
