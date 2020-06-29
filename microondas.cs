using System;

namespace Microondas
{
    class Microondas
    {
        private bool OpenDoor = false;
        Contenedor InsideBowl = null;




        public void AbrirPuerta()
        {
            if (OpenDoor == false)
            {
                OpenDoor = true;
                System.Console.WriteLine("Puerta Abierta");
            }
            else
            {
                System.Console.WriteLine("puerta ya abierta");
            }
        }

        public void IntroducirAlimento(Contenedor contenedor, Comida comida)
        {
            if (InsideBowl != null)
            {
                throw new InvalidOperationException("hay algo dentro del microondas");
                return;
            }
            else
            {
                if (contenedor == null)
                {
                    throw new InvalidOperationException("No contenedor");
                    return;
                }
                else
                {
                    if (comida == null)
                    {
                        throw new InvalidOperationException("No comida");
                        return;
                    }

                }
            }
            System.Console.WriteLine($"un {contenedor.Tomarnombre} con {comida.Tomarnombre} dentro");
            InsideBowl = contenedor;
        }

        public void CerrarPuerta()
        {
            if (OpenDoor == true)
            {
                OpenDoor = false;
                System.Console.WriteLine("puerta cerrada");
            }
            else
            {
                System.Console.WriteLine("puerta cerrada");
            }
        }
                //TODO: Calentar la comida y avisar cuando esta ya esta

    }
}