using Microsoft.Ajax.Utilities;

namespace BasicASP.NETMvc.Models
{
    public class JsonObject
    {
        public string Controller { get; set; }

        public string Action { get; set; }

        public JsonObject(string controller,string action)
        {
            this.Controller = controller;
            this.Action = action;
        }
        
        
        public override string ToString()
        {
            return Controller+Action;
        }
    }
}