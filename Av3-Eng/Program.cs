using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsAPI.Interfaces;

namespace GraphicsAPI
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("<---------------------FIRST API--------------------->");
            AbstractFactory directXFactory = new DirectXFactory();
            GameFunction(directXFactory);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("<---------------------SECOND API--------------------->");
            AbstractFactory openGLFactory = new OpenGLFactory();
            GameFunction(openGLFactory);
            // invoke user game for second API


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("<---------------------THIRD API--------------------->");
            AbstractFactory vulkanFactory = new VulkanFactory();
            GameFunction(vulkanFactory);
        }

        static void GameFunction(AbstractFactory factory)
        {
            IRenderer renderer = factory.CreateRenderer();

            I3DModel first3DModel = factory.Create3DModel();
            first3DModel.Position = new Vector3(1, 1, 1);
            I3DModel second3DModel = factory.Create3DModel();
            second3DModel.Position = new Vector3(2, 2, 2);

            ITexture firstTexture = factory.CreateTexture();
            firstTexture.Content = "DistinctFileName1";
            ITexture secondTexture = factory.CreateTexture();
            secondTexture.Content = "SuperFileName2";

            renderer.Model = first3DModel;
            renderer.Texture = firstTexture;

            renderer.Render(true);

            renderer.Model = second3DModel;
            renderer.Texture = secondTexture;

            renderer.Render(true);
        }
	}
}
