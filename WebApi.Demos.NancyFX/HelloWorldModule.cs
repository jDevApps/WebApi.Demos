namespace WebApi.Demos.NancyFX
{
    public class HelloWorldModule : Nancy.NancyModule
    {
        public HelloWorldModule()
        {
            Get["/"] = _ => "Hello world!";
        }
    }
}