using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateFactory factory = new CreateFactory("window");
            IPlatformFactory winFactory = factory.create();
            IButton winButton =  winFactory.createButton();
            ICheckbox winCheckbox = winFactory.createCheckBox();
            winButton.create();
            winCheckbox.create();
            Console.WriteLine("........................................");
            CreateFactory factory2 = new CreateFactory("mac");
            IPlatformFactory macFactory = factory2.create();
            IButton macButton = macFactory.createButton();
            ICheckbox macCheckbox = macFactory.createCheckBox();
            macButton.create();
            macCheckbox.create();

        }
    }
}
