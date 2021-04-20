using NWN.Services;

namespace MyPlugin
{
  [ServiceBinding(typeof(NewPluginService))]
  public class NewPluginService
  {
    public NewPluginService()
    {
      // Your startup service code
    }
  }
}
