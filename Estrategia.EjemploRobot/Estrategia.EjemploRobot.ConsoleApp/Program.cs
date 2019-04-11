using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estrategia.EjemploRobot.Core;

namespace Estrategia.EjemploRobot.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("v1");
            var robot = new Core.v1.RobotCasero();
            Console.WriteLine(robot.Caminar());
            //Console.WriteLine(robot.Disparar()); //Este robot no dispara

            var robotRobotMilitar = new Core.v1.RobotMilitar();
            Console.WriteLine(robotRobotMilitar.Caminar());
            Console.WriteLine(robotRobotMilitar.Disparar());

            var robotVigilante = new Core.v1.RobotVigilante();
            //Console.WriteLine(robotVigilante.Caminar()); //Este robot no camina
            Console.WriteLine(robotVigilante.Disparar());

            Console.WriteLine("v1.1");
            var robot1_1 = new Core.v1._1.RobotCasero();
            Console.WriteLine(robot1_1.Caminar());
            //Console.WriteLine(robot.Disparar()); //Este robot no dispara

            //No programar contra implementaciones
            //robot = new Estrategia.EjemploRobot.Core.v1.RobotMilitar();
            //Console.WriteLine(robot.Caminar());

            var robotRobotMilitar1_1 = new Core.v1._1.RobotMilitar();
            Console.WriteLine(robotRobotMilitar1_1.Caminar());
            Console.WriteLine(robotRobotMilitar1_1.Disparar());

            var robotVigilante1_1 = new Core.v1._1.RobotVigilante();
            //Console.WriteLine(robotVigilante.Caminar()); //Este robot no camina
            Console.WriteLine(robotVigilante1_1.Disparar());

            Console.WriteLine("v2");
            var robot2 = new Core.v2.RobotCasero();
            Console.WriteLine(robot2.Caminar());
            //Console.WriteLine(robot.Disparar()); //Este robot no dispara

            //No programar contra implementaciones
            //robot = new Estrategia.EjemploRobot.Core.v1.RobotMilitar();
            //Console.WriteLine(robot.Caminar());

            var robotRobotMilitar2 = new Core.v2.RobotMilitar();
            Console.WriteLine(robotRobotMilitar2.Caminar());
            Console.WriteLine(robotRobotMilitar2.Disparar());

            var robotVigilante2 = new Core.v2.RobotVigilante();
            //Console.WriteLine(robotVigilante.Caminar()); //Este robot no camina
            Console.WriteLine(robotVigilante2.Disparar());

            Console.WriteLine("v3");
            var robot3 = new Core.v3.RobotCasero();
            Console.WriteLine(robot3.Caminar());
            robot3.Caminador = new Core.v3.NoCaminar();
            robot3.Disparador = new Core.v3.DisparaNormal();
            Console.WriteLine(robot3.Caminar());
            Console.WriteLine(robot3.Disparar());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
